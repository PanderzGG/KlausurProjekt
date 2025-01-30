using IniParser;
using IniParser.Model;
using System.Text;

namespace SaschaKleinen
{
    // Hauptformular für das Spiel
    public partial class Spiel : Form
    {

        private Spieler spieler = new Spieler(); // Speichert den aktuellen Spielernamen
        private string checkedFrage; // Speichert den ausgewählten Fragetyp

        private string[] currentGame = new string[2];

        private bool spielt = false;

        private int frageNr; // Speichert die aktuelle Antwortnummer
        private int maxFragen = 10; // Speichert die maximale Anzahl an Fragen
        private int streakmult; // Variable für Streak-Multiplikator
        private int maxstreak; // Variable für maximalen Streak
        private int difmult; // Variable für Schwierigkeitsgrad-Multiplikator
        private int score; // Aktueller Punktestand
        private int endScore; // Endpunktestand

        private Random ran = new Random(); // Zufallsgenerator

        private Datenbank db = new Datenbank();

        // Listen zur Speicherung verschiedener Datenbankeinträge

        private List<Laender> liLaender = new List<Laender>();
        private List<Kontinente> liKontinente = new List<Kontinente>();


        // Konstruktor, erwartet den Spielernamen als Parameter
        public Spiel(Spieler spieler)
        {
            InitializeComponent();
            onLoadLists(); // Lädt die benötigten Listen mit Daten
            hideTabs(); // Blendet Tabs im TabControl aus
            onLoadini(); // Lädt die Einstellungen aus der INI-Datei
            this.spieler = spieler; // Weist den übergebenen Spielernamen der lokalen Variable zu
            panelSchwierigkeitsini.Enabled = false; // Deaktiviert das Schwierigkeitsgrad-Panel
        }

        #region onLoad

        // Lädt die Listen aus der Datenbank
        public void onLoadLists()
        {
            liLaender = db.getLaender();
        }

        // Passt das TabControl-Layout an
        private void hideTabs()
        {
            tabControlSpiel.Appearance = TabAppearance.FlatButtons;
            tabControlSpiel.ItemSize = new Size(0, 1);
            tabControlSpiel.SizeMode = TabSizeMode.Fixed;
        }

        private void onLoadini()
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile("difficulty.ini");

            foreach (SectionData section in data.Sections)
            {
                comboBoxSchwierigkeitsIni.Items.Add(section.SectionName);
            }
        }

        #endregion

        #region Checkboxes

        // Eventhandler, wenn die Checkbox 'Alle' an-/abgewählt wird
        private void checkBoxAlle_CheckedChanged(object sender, EventArgs e)
        {
            bool check;
            if (checkBoxAlle.Checked)
            {
                check = true;
                checkBoxHandling(check);
            }
            else
            {
                check = false;
                checkBoxHandling(check);
            }
        }

        private void checkBoxHandling(bool check)
        {
            if (check)
            {
                panelKontinentSingleSelect.Enabled = false;
                foreach (CheckBox cb in panelKontinentSingleSelect.Controls)
                {
                    cb.Checked = check;
                }
            }
            else
            {
                panelKontinentSingleSelect.Enabled = true;
                foreach (CheckBox cb in panelKontinentSingleSelect.Controls)
                {
                    cb.Checked = check;
                }
            }
        }

        #endregion

        #region Calculations      

        // Bestimmt den Schwierigkeitsgrad basierend auf ausgewählten Kontinenten
        public void setzeDifmult()
        {
            if (checkBoxAlle.Checked)
            {
                difmult = 6; // Setzt Multiplikator auf 6, wenn alle Kontinente ausgewählt sind
            }
            else
            {
                foreach (CheckBox cb in panelKontinentSingleSelect.Controls)
                {
                    if (cb.Checked)
                    {
                        difmult++; // Erhöht den Multiplikator um 1 pro ausgewähltem Kontinent
                    }
                }
            }
        }

        private void endScoreBerechnen()
        {
            endScore = score * difmult * (maxstreak * score);
        }

        #endregion

        #region Misc. Methoden

        private void clearKontinentCheckboxes()
        {
            foreach (Control ctrl in panelKontinentSingleSelect.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }

            checkBoxAlle.Checked = false;
        }

        private void rbFrageFlaggen_CheckedChanged(object sender, EventArgs e)
        {
            frageRadioHandling();
        }

        private void setDifficultyIni(string difficulty)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile("difficulty.ini");

            foreach (KeyData key in data[difficulty])
            {
                foreach (Control ctrl in panelKontinentSingleSelect.Controls)
                {
                    if (ctrl is CheckBox cb)
                    {
                        if (cb.Text == key.KeyName && key.Value == "1")
                        {
                            cb.Checked = true;
                        }
                    }
                }
            }
        }

        // Klick-Event für den Button, um zum nächsten Tab zu wechseln
        private void btnKontinentWeiter_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            difmult = 0;
            setzeDifmult();

            // Füge diesen Abschnitt hinzu, um INI-basierte Kontinente zu laden
            if (checkBoxSchwierigkeitIni.Checked)
            {
                // Lade die aus der INI ausgewählten Kontinente
                foreach (CheckBox cb in panelKontinentSingleSelect.Controls)
                {
                    if (cb.Checked)
                    {
                        sb.Append("'" + cb.Text + "'" + ", ");
                    }
                }
                if (sb.Length > 0)
                {
                    sb.Length -= 2;
                }
                liKontinente = db.difKontinente(sb.ToString());
            }
            else if (checkBoxAlle.Checked)
            {
                liKontinente = db.getKontinente();
            }
            else
            {
                foreach (CheckBox cb in panelKontinentSingleSelect.Controls)
                {
                    if (cb.Checked)
                    {
                        sb.Append("'" + cb.Text + "'" + ", ");
                    }
                }
                if (sb.Length > 0)
                {
                    sb.Length -= 2;
                }
                liKontinente = db.difKontinente(sb.ToString());
            }

            tabControlSpiel.SelectedTab = tabPageFrageAntworttyp;

        }

        // Methode die ausgeführt wird, wenn der Button 'Spiel beginnen' geklickt wird
        private void btnSpielbeginnen_Click(object sender, EventArgs e)
        {
            string Fragetyp;
            string Antworttyp;
            bool catchExecuted = false;

            try
            {
                switch (checkedFrage)
                {
                    case "Flaggen":
                        if (rbAntworttyp1.Checked)
                        {
                            panelSpielBildFrage.BringToFront(); // Bringt das Bild-Frage-Panel in den Vordergrund
                            panelSpielBildAntwort.Visible = false; // Blendet das Bild-Antwort-Panel aus
                            panelSpielTextOnly.Visible = false; // Blendet das Text-Panel aus

                            if (!spielt) // Überprüfung, ob das Spiel schon läuft
                            {
                                frageNr = 1;
                                spielt = true;
                                Fragetyp = "BildFrage";
                                Antworttyp = "land";

                                spielLogik(Fragetyp, Antworttyp);
                                tabControlSpiel.SelectedTab = tabPageSpiel;
                            }
                            else
                            {
                                MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                                return; // Beendet die Methode, um keine weitere Spielinstanz zu starten
                            }

                        }
                        else if (rbAntworttyp2.Checked)
                        {
                            panelSpielBildFrage.BringToFront(); // Bringt das Bild-Frage-Panel in den Vordergrund
                            panelSpielBildAntwort.Visible = false; // Blendet das Bild-Antwort-Panel aus
                            panelSpielTextOnly.Visible = false; // Blendet das Text-Panel aus

                            if (!spielt)
                            {
                                frageNr = 1; // Setzt die aktuelle Frage auf 1
                                spielt = true;
                                Fragetyp = "BildFrage";
                                Antworttyp = "hauptstadt";

                                spielLogik(Fragetyp, Antworttyp);
                                tabControlSpiel.SelectedTab = tabPageSpiel;
                            }
                            else
                            {
                                MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                                return; // Beendet die Methode, um keine weitere Spielinstanz zu starten
                            }
                        }
                        else
                        {
                            throw new Exception("Bitte wähle eine Antwortmöglichkeit");
                        }
                        break;

                    case "Hauptstädte":
                        if (rbAntworttyp1.Checked)
                        {
                            panelSpielBildFrage.SendToBack(); // Schickt das Bild-Frage-Panel in den Hintergrund
                            panelSpielBildAntwort.SendToBack(); // Schickt das Bild-Antwort-Panel in den Hintergrund
                            panelSpielTextOnly.BringToFront(); // Zeigt das reine Text-Frage-Panel an

                            if (!spielt)
                            {
                                frageNr = 1;
                                spielt = true;
                                Fragetyp = "TextAntwort";
                                Antworttyp = "land";

                                spielLogik(Fragetyp, Antworttyp);
                                tabControlSpiel.SelectedTab = tabPageSpiel;
                            }
                            else
                            {
                                MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                                return; // Beendet die Methode, um keine weitere Spielinstanz zu starten
                            }
                        }
                        else if (rbAntworttyp2.Checked)
                        {
                            panelSpielBildFrage.SendToBack(); // Schickt das Bild-Frage-Panel in den Hintergrund
                            panelSpielBildAntwort.BringToFront(); // Bringt das Bild-Antwort-Panel in den Vordergrund
                            panelSpielTextOnly.SendToBack(); // Schickt das Text-Panel in den Hintergrund

                            if (!spielt)
                            {
                                frageNr = 1; // Setzt die aktuelle Frage auf 1
                                spielt = true;
                                Fragetyp = "BildAntwort";
                                Antworttyp = "hauptstadt";
                                // bildAntwortSpiel(hauptstadt); 
                                spielLogik(Fragetyp, Antworttyp);
                                tabControlSpiel.SelectedTab = tabPageSpiel;
                            }
                        }
                        else
                        {
                            throw new Exception("Bitte wähle eine Antwortmöglichkeit");
                        }
                        break;

                    case "Länder":
                        if (rbAntworttyp1.Checked)
                        {
                            panelSpielBildFrage.SendToBack(); // Schickt das Bild-Frage-Panel in den Hintergrund
                            panelSpielBildAntwort.SendToBack(); // Schickt das Bild-Antwort-Panel in den Hintergrund
                            panelSpielTextOnly.BringToFront(); // Zeigt das reine Text-Frage-Panel an

                            if (!spielt)
                            {
                                frageNr = 1; // Setzt die aktuelle Frage auf 1
                                spielt = true;
                                Fragetyp = "TextAntwort";
                                Antworttyp = "land";

                                spielLogik(Fragetyp, Antworttyp);
                                tabControlSpiel.SelectedTab = tabPageSpiel;
                            }
                            else
                            {
                                MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                                return; // Methode beenden, wenn Spiel bereits läuft
                            }
                        }
                        else if (rbAntworttyp2.Checked)
                        {
                            panelSpielBildFrage.SendToBack(); // Schickt das Bild-Frage-Panel in den Hintergrund
                            panelSpielBildAntwort.BringToFront(); // Zeigt das Bild-Antwort-Panel an
                            panelSpielTextOnly.SendToBack(); // Blendet das Text-Panel aus

                            if (!spielt)
                            {
                                frageNr = 1; // Setzt die aktuelle Frage auf 1
                                spielt = true;
                                Fragetyp = "BildAntwort";
                                Antworttyp = "land";

                                spielLogik(Fragetyp, Antworttyp);
                                tabControlSpiel.SelectedTab = tabPageSpiel;
                            }
                            else
                            {
                                MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                                return; // Methode beenden
                            }
                        }
                        else
                        {
                            throw new Exception("Bitte wähle eine Antwortmöglichkeit");
                        }
                        break;
                    default:
                        MessageBox.Show("Bitte wähle Frage- und Antworttyp aus");
                        break;
                }
            }
            catch (Exception ex)
            {
                catchExecuted = true;
                MessageBox.Show("Fehler: " + ex.Message);
            }
            finally
            {
                if (catchExecuted)
                {
                    tabControlSpiel.SelectedTab = tabPageFrageAntworttyp;
                }
            }

        }

        private void checkBoxSchwierigkeitIni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSchwierigkeitIni.Checked)
            {
                panelKontinentSelectAll.Enabled = false;
                panelKontinentSingleSelect.Enabled = false;
                panelSchwierigkeitsini.Enabled = true;

                clearKontinentCheckboxes();
            }
            else
            {
                panelKontinentSelectAll.Enabled = true;
                panelKontinentSingleSelect.Enabled = true;
                panelSchwierigkeitsini.Enabled = false;

                clearKontinentCheckboxes();
            }
        }

        private void comboBoxSchwierigkeitsIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ini handling
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile("difficulty.ini");

            string difficulty = comboBoxSchwierigkeitsIni.SelectedItem.ToString();

            switch (difficulty)
            {
                case "Leicht":
                    clearKontinentCheckboxes();
                    setDifficultyIni(difficulty);
                    break;
                case "Mittel":
                    clearKontinentCheckboxes();
                    setDifficultyIni(difficulty);
                    break;
                case "Schwer":
                    clearKontinentCheckboxes();
                    setDifficultyIni(difficulty);
                    break;
                default:
                    break;
            }
        }

        private void btnFATZurueck_Click(object sender, EventArgs e)
        {
            tabControlSpiel.SelectedTab = tabPageKontinente;
        }

        #endregion

        #region Spiellogik

        private void spielLogik(string Fragetyp, string Antworttyp)
        {
            int indexGesucht;
            int falscherIndex;
            int istVorhanden;
            int radioIndex;

            List<Laender> antworten = new List<Laender>();

            Laender gesuchteAntwort;
            Laender falscheAntwort;

            currentGame = new string[] { Fragetyp, Antworttyp };

            string quellPfad;

            do
            {
                indexGesucht = ran.Next(0, liLaender.Count);
                gesuchteAntwort = liLaender[indexGesucht];

                istVorhanden = liKontinente.FindIndex(k => k.KontinentID == gesuchteAntwort.KontinentID);
            }
            while (istVorhanden == -1);

            antworten.Clear();
            antworten.Add(gesuchteAntwort);

            while (antworten.Count < 4)
            {
                falscherIndex = ran.Next(0, liLaender.Count);
                falscheAntwort = liLaender[falscherIndex];

                if (!antworten.Contains(falscheAntwort) && falscherIndex != indexGesucht)
                {
                    antworten.Add(falscheAntwort);
                }
            }

            antworten = antworten.OrderBy(a => ran.Next()).ToList();

            switch (Fragetyp)
            {
                case "TextAntwort":
                    switch (Antworttyp)
                    {
                        case "hauptstadt":
                            lbFrageText.Text = "Wie heißt die Hauptstadt von " + gesuchteAntwort.LandName;
                            break;
                        case "land":
                            lbFrageText.Text = "Von welchem Land ist " + gesuchteAntwort.Hauptstadt + " die Hauptstadt?";
                            break;
                    }
                    break;
                case "BildFrage":
                    switch (Antworttyp)
                    {
                        case "hauptstadt":
                            lbFrageBildText.Text = "Wähle die zugehörige Hauptstadt dieses Landes: ";
                            quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchteAntwort.FlaggenPfad);
                            pbFrageFlagge.Image = Image.FromFile(quellPfad);
                            break;
                        case "land":
                            lbFrageBildText.Text = "Zu welchem Land gehört diese Flagge? ";
                            quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchteAntwort.FlaggenPfad);
                            pbFrageFlagge.Image = Image.FromFile(quellPfad);
                            break;
                    }
                    break;
                case "BildAntwort":
                    switch (Antworttyp)
                    {
                        case "hauptstadt":
                            lbAntwortBildFrageText.Text = "Welche Landesflagge gehört zu " + gesuchteAntwort.Hauptstadt + "?";
                            quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchteAntwort.FlaggenPfad);
                            break;
                        case "land":
                            lbAntwortBildFrageText.Text = "Welche Flagge gehört zu " + gesuchteAntwort.LandName.ToString() + "?";
                            quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchteAntwort.FlaggenPfad);
                            break;
                    }
                    break;
            }

            radioIndex = 0;

            switch (Fragetyp)
            {
                case "TextAntwort":
                    if (Antworttyp == "land")
                    {
                        foreach (Control ctrl in groupBoxTextOnly.Controls)
                        {
                            if (ctrl is RadioButton rb)
                            {
                                rb.Text = antworten[radioIndex].LandName;
                                radioIndex++;

                                rb.Tag = (antworten[radioIndex - 1] == gesuchteAntwort);
                            }
                        }
                    }
                    else
                    {
                        foreach (Control ctrl in rbFlaggeAntwort.Controls)
                        {
                            if (ctrl is RadioButton rb)
                            {
                                rb.Text = antworten[radioIndex].LandName;
                                radioIndex++;

                                rb.Tag = (antworten[radioIndex - 1] == gesuchteAntwort);
                            }
                        }
                    }
                    break;
                case "BildFrage":
                    if (Antworttyp == "hauptstadt")
                    {
                        foreach (Control ctrl in rbFlaggeAntwort.Controls)
                        {
                            if (ctrl is RadioButton rb)
                            {
                                rb.Text = antworten[radioIndex].Hauptstadt;
                                radioIndex++;

                                rb.Tag = (antworten[radioIndex - 1] == gesuchteAntwort);
                            }
                        }
                    }
                    else
                    {
                        foreach (Control ctrl in rbFlaggeAntwort.Controls)
                        {
                            if (ctrl is RadioButton rb)
                            {
                                rb.Text = antworten[radioIndex].LandName;
                                radioIndex++;

                                rb.Tag = (antworten[radioIndex - 1] == gesuchteAntwort);
                            }
                        }
                    }

                    break;
                case "BildAntwort":
                    foreach (Control ctrl in groupBildAntworten.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Text = antworten[radioIndex].LandName;

                            try
                            {
                                switch (rb.Name)
                                {
                                    case "rbBildAntwort1":
                                        pbAntwort1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "flags", antworten[radioIndex].FlaggenPfad));
                                        break;
                                    case "rbBildAntwort2":
                                        pbAntwort2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "flags", antworten[radioIndex].FlaggenPfad));
                                        break;
                                    case "rbBildAntwort3":
                                        pbAntwort3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "flags", antworten[radioIndex].FlaggenPfad));
                                        break;
                                    case "rbBildAntwort4":
                                        pbAntwort4.Image = Image.FromFile(Path.Combine(Application.StartupPath, "flags", antworten[radioIndex].FlaggenPfad));
                                        break;
                                }
                            }
                            catch (FileNotFoundException ex)
                            {
                                MessageBox.Show("Fehler beim Laden der Flagge: " + ex.Message);
                            }

                            radioIndex++;

                            rb.Tag = (antworten[radioIndex - 1] == gesuchteAntwort);
                        }
                    }
                    break;
            }
        }

        private void nextButtons(object sender, EventArgs e)
        {
            switch (currentGame[0])
            {
                case "TextAntwort":
                    foreach (Control ctrl in groupBoxTextOnly.Controls)
                    {
                        if (ctrl is RadioButton rb && rb.Checked)
                        {
                            bool istRichtig = (bool)rb.Tag;

                            streakmultCalc(istRichtig);
                        }
                    }

                    if (frageNr < maxFragen)
                    {
                        frageNr++;
                        spielLogik(currentGame[0], currentGame[1]);
                    }
                    else if (frageNr == maxFragen)
                    {
                        scoreSpeichern();
                    }

                    foreach (Control ctrl in groupBoxTextOnly.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Checked = false;
                        }
                    }
                    break;
                case "BildFrage":
                    foreach (Control ctrl in rbFlaggeAntwort.Controls)
                    {
                        if (ctrl is RadioButton rb && rb.Checked)
                        {
                            bool istRichtig = (bool)rb.Tag;

                            streakmultCalc(istRichtig);
                        }
                    }

                    if (frageNr < maxFragen)
                    {
                        frageNr++;
                        spielLogik(currentGame[0], currentGame[1]);
                    }
                    else if (frageNr == maxFragen)
                    {
                        scoreSpeichern();
                    }

                    foreach (Control ctrl in rbFlaggeAntwort.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Checked = false;
                        }
                    }
                    break;
                case "BildAntwort":
                    foreach (Control ctrl in groupBildAntworten.Controls)
                    {
                        if (ctrl is RadioButton rb && rb.Checked)
                        {
                            bool istRichtig = (bool)rb.Tag;

                            streakmultCalc(istRichtig);
                        }
                    }

                    if (frageNr < maxFragen)
                    {
                        frageNr++;
                        spielLogik(currentGame[0], currentGame[1]);
                    }
                    else if (frageNr == maxFragen)
                    {
                        scoreSpeichern();
                    }

                    foreach (Control ctrl in groupBildAntworten.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Checked = false;
                        }
                    }
                    break;
            }
        }

        private void scoreSpeichern()
        {
            endScoreBerechnen();

            Scores score = new Scores();
            score.SpielerID = spieler.SpielerID;
            score.Punkte = endScore;

            db.newScore(score);

            DialogResult result = MessageBox.Show("Das Spiel ist zu ende" + Environment.NewLine +
                                                  "Dein Score ist: " + endScore.ToString() + " Punkte" + Environment.NewLine +
                                                  "Möchtest du ein neues Spiel starten?", "GLÜCKWUNSCH", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (result == DialogResult.Yes)
            {
                gameReset();
            }
            else
            {
                this.Close();
            }
        }

        private void streakmultCalc(bool istRichtig)
        {
            if (istRichtig)
            {
                streakmult++;
                maxstreak = streakmult > maxstreak ? streakmult : maxstreak;

                score += 10;

                MessageBox.Show("Richtig! 🎉");
            }
            else
            {
                maxstreak = streakmult > maxstreak ? streakmult : maxstreak;
                streakmult = 0;
                MessageBox.Show("Falsch! 😞");
            }
        }

        private void frageRadioHandling()
        {

            foreach (Control ctrl in panelFragentyp.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    checkedFrage = rb.Text;
                }
            }

            switch (checkedFrage)
            {
                case "Flaggen":
                    rbAntworttyp1.Text = "Länder";
                    rbAntworttyp2.Text = "Hauptstädte";

                    rbAntworttyp1.Visible = true;
                    rbAntworttyp2.Visible = true;
                    break;
                case "Hauptstädte":
                    rbAntworttyp1.Text = "Länder";
                    rbAntworttyp2.Text = "Flaggen";

                    rbAntworttyp1.Visible = true;
                    rbAntworttyp2.Visible = true;
                    break;
                case "Länder":
                    rbAntworttyp1.Text = "Hauptstädte";
                    rbAntworttyp2.Text = "Flaggen";

                    rbAntworttyp1.Visible = true;
                    rbAntworttyp2.Visible = true;
                    break;
            }
        }

        private void gameReset()
        {
            checkedFrage = "";
            currentGame = new string[] { "", "" };
            frageNr = 1;
            streakmult = 0;
            maxstreak = 0;
            difmult = 0;
            score = 0;
            endScore = 0;
            spielt = false;

            checkBoxAlle.Checked = false;

            foreach (Control ctrl in panelKontinentSingleSelect.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }

            foreach (Control ctrl in panelFragentyp.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }

            foreach (Control ctrl in panelAtnworttyp.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }

            tabControlSpiel.SelectedTab = tabPageKontinente;
        }

        #endregion

        #region Bild click
        private void pbAntwort1_Click(object sender, EventArgs e)
        {
            rbBildAntwort1.Checked = true;
        }

        private void pbAntwort2_Click(object sender, EventArgs e)
        {
            rbBildAntwort2.Checked = true;
        }

        private void pbAntwort3_Click(object sender, EventArgs e)
        {
            rbBildAntwort3.Checked = true;
        }

        private void pbAntwort4_Click(object sender, EventArgs e)
        {
            rbBildAntwort4.Checked = true;
        }
        #endregion

        private void btnFATZurueck_Click_1(object sender, EventArgs e)
        {
            tabControlSpiel.SelectedTab = tabPageKontinente;
        }
    }

}
