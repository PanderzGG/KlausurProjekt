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
        private string curGame;

        private bool spielt = false;

        private int frageNr; // Speichert die aktuelle Antwortnummer
        private int maxFragen = 3; // Speichert die maximale Anzahl an Fragen
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
            endScore = score * difmult * maxstreak * score;
        }

        #endregion

        #region Misc. Methoden

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

        private void rbFrageFlaggen_CheckedChanged(object sender, EventArgs e)
        {
            frageRadioHandling();
        }

        // Methode die ausgeführt wird, wenn der Button 'Spiel beginnen' geklickt wird
        private void btnSpielbeginnen_Click(object sender, EventArgs e)
        {
            tabControlSpiel.SelectedTab = tabPageSpiel; // Wechselt zum Spiel-Tab

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
                            string land = "land"; // Parameter für das Flaggen-Frage-Spiel
                            bildFrageSpiel(land); // Startet das Bild-Frage-Spiel für Flaggen und Länder
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
                            string hauptstadt = "hauptstadt"; // Parameter für die Hauptstadt
                            bildFrageSpiel(hauptstadt); // Startet das Bild-Frage-Spiel für Flaggen und Hauptstädte
                        }
                        else
                        {
                            MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                            return; // Beendet die Methode, um keine weitere Spielinstanz zu starten
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie einen Antworttyp aus"); // Hinweis, wenn kein Antworttyp gewählt wurde
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
                            string hauptstadt = "hauptstadt"; // Parameter für Hauptstadtnamen
                            textFrageSpiel(hauptstadt); // Startet das Text-Frage-Spiel für Hauptstädte
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
                            string hauptstadt = "hauptstadt"; // Parameter für Hauptstadtnamen
                            bildAntwortSpiel(hauptstadt); // Startet das Bild-Antwort-Spiel mit Städten
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie einen Antworttyp aus"); // Hinweis, wenn kein Antworttyp gewählt wurde
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
                            string land = "land"; // Parameter für Landesnamen
                            textFrageSpiel(land); // Startet das Text-Frage-Spiel für Länder
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
                            string land = "land"; // Parameter für Landesnamen
                            bildAntwortSpiel(land); // Startet das Bild-Antwort-Spiel für Länder
                        }
                        else
                        {
                            MessageBox.Show("Es läuft bereits eine Instanz des Spiels"); // Warnung bei laufendem Spiel
                            return; // Methode beenden
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie einen Antworttyp aus"); // Hinweis, wenn kein Antworttyp gewählt wurde
                    }
                    break;
            }
        }




        #endregion

        #region Spiellogik
        private void bildFrageSpiel(string typ)
        {
            int indexGesucht = 0;
            int istVorhanden;
            int radioIndex;

            List<string> antworten = new List<string>();

            string gesuchtesLand;
            string gesuchteStadt;
            string gesuchteFlagge;
            string quellPfad;

            curGame = typ;

            switch (typ)
            {
                case "land":
                    do
                    {
                        indexGesucht = ran.Next(0, liLaender.Count);
                        gesuchtesLand = liLaender[indexGesucht].LandName;
                        gesuchteStadt = liLaender[indexGesucht].Hauptstadt;
                        gesuchteFlagge = liLaender[indexGesucht].FlaggenPfad;

                        istVorhanden = liKontinente.FindIndex(k => k.KontinentID == liLaender[indexGesucht].KontinentID);
                    }
                    while (istVorhanden == -1);

                    quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchteFlagge);

                    antworten.Clear();
                    antworten.Add(gesuchtesLand);

                    while (antworten.Count < 4)
                    {
                        int falscherIndex = ran.Next(0, liLaender.Count);
                        string falschesLand = liLaender[falscherIndex].LandName;

                        if (!antworten.Contains(falschesLand) && falscherIndex != indexGesucht)
                        {
                            antworten.Add(falschesLand);
                        }
                    }

                    antworten = antworten.OrderBy(a => ran.Next()).ToList();

                    lbFrageBildText.Text = "Wähle das zugehörige Land dieser Flagge: ";
                    pbFrageFlagge.Image = Image.FromFile(quellPfad);

                    radioIndex = 0;

                    foreach (Control ctrl in rbFlaggeAntwort.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Text = antworten[radioIndex];
                            radioIndex++;

                            rb.Tag = (antworten[radioIndex - 1] == gesuchtesLand);
                        }
                    }
                    break;

                case "hauptstadt":
                    do
                    {
                        indexGesucht = ran.Next(0, liLaender.Count);
                        gesuchtesLand = liLaender[indexGesucht].LandName;
                        gesuchteStadt = liLaender[indexGesucht].Hauptstadt;
                        gesuchteFlagge = liLaender[indexGesucht].FlaggenPfad;

                        istVorhanden = liKontinente.FindIndex(k => k.KontinentID == liLaender[indexGesucht].KontinentID);
                    }
                    while (istVorhanden == -1);

                    quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchteFlagge);

                    antworten.Clear();
                    antworten.Add(gesuchteStadt);

                    while (antworten.Count < 4)
                    {
                        int falscherIndex = ran.Next(0, liLaender.Count);
                        string falscheHauptstadt = liLaender[falscherIndex].Hauptstadt;

                        if (!antworten.Contains(falscheHauptstadt) && falscherIndex != indexGesucht)
                        {
                            antworten.Add(falscheHauptstadt);
                        }
                    }

                    antworten = antworten.OrderBy(a => ran.Next()).ToList();

                    lbFrageBildText.Text = "Wähle die zugehörige Hauptstadt dieses Landes: ";
                    pbFrageFlagge.Image = Image.FromFile(quellPfad);

                    radioIndex = 0;

                    foreach (Control ctrl in rbFlaggeAntwort.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Text = antworten[radioIndex];
                            radioIndex++;

                            rb.Tag = (antworten[radioIndex - 1] == gesuchteStadt);
                        }
                    }
                    break;
            }
        }

        private void textFrageSpiel(string typ)
        {
            int indexGesucht = 0;
            int istVorhanden;
            int radioIndex;

            string gesuchtesLand = "";
            string gesuchteStadt = "";

            List<string> antworten = new List<string>();

            curGame = typ;

            switch (typ)
            {
                case "hauptstadt":
                    do
                    {
                        indexGesucht = ran.Next(0, liLaender.Count);
                        gesuchtesLand = liLaender[indexGesucht].LandName;
                        gesuchteStadt = liLaender[indexGesucht].Hauptstadt;

                        istVorhanden = liKontinente.FindIndex(k => k.KontinentID == liLaender[indexGesucht].KontinentID);
                    }
                    while (istVorhanden == -1);

                    antworten.Clear();
                    antworten.Add(gesuchteStadt);

                    while (antworten.Count < 4)
                    {
                        int falscherIndex = ran.Next(0, liLaender.Count);
                        string falscheHauptstadt = liLaender[falscherIndex].Hauptstadt;

                        if (!antworten.Contains(falscheHauptstadt) && falscherIndex != indexGesucht)
                        {
                            antworten.Add(falscheHauptstadt);
                        }
                    }

                    antworten = antworten.OrderBy(a => ran.Next()).ToList();

                    lbFrageText.Text = "Wie heißt die Hauptstadt von " + gesuchtesLand;

                    radioIndex = 0;

                    foreach (Control ctrl in groupBoxTextOnly.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Text = antworten[radioIndex];
                            radioIndex++;

                            rb.Tag = (antworten[radioIndex - 1] == gesuchteStadt);
                        }
                    }

                    break;
                case "land":
                    do
                    {
                        indexGesucht = ran.Next(0, liLaender.Count);
                        gesuchtesLand = liLaender[indexGesucht].LandName;
                        gesuchteStadt = liLaender[indexGesucht].Hauptstadt;

                        istVorhanden = liKontinente.FindIndex(k => k.KontinentID == liLaender[indexGesucht].KontinentID);
                    }
                    while (istVorhanden == -1);


                    antworten.Clear();
                    antworten.Add(gesuchtesLand);

                    while (antworten.Count < 4)
                    {
                        int falscherIndex = ran.Next(0, liLaender.Count);
                        string falschesLand = liLaender[falscherIndex].LandName;

                        if (!antworten.Contains(falschesLand) && falscherIndex != indexGesucht)
                        {
                            antworten.Add(falschesLand);
                        }
                    }

                    antworten = antworten.OrderBy(a => ran.Next()).ToList();

                    lbFrageText.Text = "Von welchem Land ist " + gesuchteStadt + " die Hauptstadt?";

                    radioIndex = 0;

                    foreach (Control ctrl in groupBoxTextOnly.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Text = antworten[radioIndex];
                            radioIndex++;

                            rb.Tag = (antworten[radioIndex - 1] == gesuchtesLand);
                        }
                    }

                    break;
            }
        }

        private void bildAntwortSpiel(string typ)
        {
            int indexGesucht = 0;
            int istVorhanden;
            int radioIndex;

            List<Laender> antworten = new List<Laender>();

            Laender gesuchtesLand;
            Laender gesuchteStadt;
            string gesuchteFlagge;
            string quellPfad;

            curGame = typ;

            switch (typ)
            {
                case "land":
                    do
                    {
                        indexGesucht = ran.Next(0, liLaender.Count);
                        gesuchtesLand = liLaender[indexGesucht];

                        istVorhanden = liKontinente.FindIndex(k => k.KontinentID == liLaender[indexGesucht].KontinentID);
                    }
                    while (istVorhanden == -1);

                    quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchtesLand.FlaggenPfad);

                    antworten.Clear();
                    antworten.Add(gesuchtesLand);

                    while (antworten.Count < 4)
                    {
                        int falscherIndex = ran.Next(0, liLaender.Count);
                        Laender falschesLand = liLaender[falscherIndex];

                        if (!antworten.Contains(falschesLand) && falscherIndex != indexGesucht)
                        {
                            antworten.Add(falschesLand);
                        }
                    }

                    antworten = antworten.OrderBy(a => ran.Next()).ToList();

                    lbAntwortBildFrageText.Text = "Welche Flagge gehört zu " + gesuchtesLand.LandName.ToString() + "?";
                    radioIndex = 0;

                    foreach (Control ctrl in groupBildAntworten.Controls)
                    {
                        if (ctrl is RadioButton rb)
                        {
                            rb.Text = antworten[radioIndex].LandName;

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

                            radioIndex++;

                            rb.Tag = (antworten[radioIndex - 1] == gesuchtesLand);
                        }
                    }
                    break;

                case "hauptstadt":
                    do
                    {
                        indexGesucht = ran.Next(0, liLaender.Count);
                        gesuchtesLand = liLaender[indexGesucht];

                        istVorhanden = liKontinente.FindIndex(k => k.KontinentID == liLaender[indexGesucht].KontinentID);
                    }
                    while (istVorhanden == -1);

                    quellPfad = Path.Combine(Application.StartupPath, "flags", gesuchtesLand.FlaggenPfad);

                    antworten.Clear();
                    antworten.Add(gesuchtesLand);

                    while (antworten.Count < 4)
                    {
                        int falscherIndex = ran.Next(0, liLaender.Count);
                        Laender falschesLand = liLaender[falscherIndex];

                        if (!antworten.Contains(falschesLand) && falscherIndex != indexGesucht)
                        {
                            antworten.Add(falschesLand);
                        }
                    }

                    antworten = antworten.OrderBy(a => ran.Next()).ToList();

                    lbAntwortBildFrageText.Text = "Welche Landesflagge gehört zu " + gesuchtesLand.Hauptstadt + "?";

                    radioIndex = 0;

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

                            rb.Tag = (antworten[radioIndex - 1] == gesuchtesLand);
                        }
                    }
                    break;
            }
        }

        private void btnTextOnlyNext_Click(object sender, EventArgs e)
        {
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
                textFrageSpiel(curGame);
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

        }

        private void btnFlaggeAntwortNext_Click(object sender, EventArgs e)
        {
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
                bildFrageSpiel(curGame);
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
        }

        private void btnAntwortBildNext_Click(object sender, EventArgs e)
        {
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
                bildAntwortSpiel(curGame);
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
            curGame = "";
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

        private void setDifficultyIni(string difficulty)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile("difficulty.ini");

            foreach (KeyData key in data[difficulty])
            {
                MessageBox.Show("Key: " + key.KeyName + " Value: " + key.Value);

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
    }

}
