using System.Text;

namespace SaschaKleinen
{
    // Hauptformular für das Spiel
    public partial class Spiel : Form
    {

        private string spieler; // Speichert den aktuellen Spielernamen
        private string checkedFrage; // Speichert den ausgewählten Fragetyp

        private int anwNr; // Speichert die aktuelle Antwortnummer
        private int maxFragen = 10; // Speichert die maximale Anzahl an Fragen
        private int streakmult; // Variable für Streak-Multiplikator
        private int difmult; // Variable für Schwierigkeitsgrad-Multiplikator
        private int score; // Aktueller Punktestand
        private int endScore; // Endpunktestand

        private Random ran = new Random(); // Zufallsgenerator

        private Datenbank db = new Datenbank();

        // Listen zur Speicherung verschiedener Datenbankeinträge
        private List<Spieler> liSpieler = new List<Spieler>();
        private List<Laender> liLaender = new List<Laender>();
        private List<Kontinente> liKontinente = new List<Kontinente>();
        private List<Scores> liScores = new List<Scores>();

        // Konstruktor, erwartet den Spielernamen als Parameter
        public Spiel(string spieler)
        {
            InitializeComponent();
            this.spieler = spieler; // Weist den übergebenen Spielernamen der lokalen Variable zu
            onLoadLists(); // Lädt die benötigten Listen mit Daten
            hideTabs(); // Blendet Tabs im TabControl aus
        }

        #region onLoad

        // Lädt die Listen aus der Datenbank
        public void onLoadLists()
        {
            liSpieler = db.getSpieler();
            liScores = db.getScores();
            liLaender = db.getLaender();
        }

        // Passt das TabControl-Layout an
        private void hideTabs()
        {
            tabControlSpiel.Appearance = TabAppearance.FlatButtons;
            tabControlSpiel.ItemSize = new Size(0, 1);
            tabControlSpiel.SizeMode = TabSizeMode.Fixed;
        }

        #endregion

        #region Checkboxes

        // Eventhandler, wenn die Checkbox 'Alle' an-/abgewählt wird
        private void checkBoxAlle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlle.Checked)
            {
                // Aktiviert alle Checkboxen für Kontinente
                checkBoxAfrica.Checked = true;
                checkBoxAsien.Checked = true;
                checkBoxEuropa.Checked = true;
                checkBoxNordamerika.Checked = true;
                checkBoxSuedamerika.Checked = true;
                checkBoxAusOz.Checked = true;
                panelKontinentSingleSelect.Enabled = false; // Deaktiviert Einzelauswahl
            }
            else
            {
                // Deaktiviert alle Checkboxen für Kontinente
                checkBoxAfrica.Checked = false;
                checkBoxAsien.Checked = false;
                checkBoxEuropa.Checked = false;
                checkBoxNordamerika.Checked = false;
                checkBoxSuedamerika.Checked = false;
                checkBoxAusOz.Checked = false;
                panelKontinentSingleSelect.Enabled = true; // Aktiviert Einzelauswahl
            }
        }

        #endregion

        #region Calculations

        #region Schwierigkeitsgrad

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

        #endregion

        #endregion

        // Klick-Event für den Button, um zum nächsten Tab zu wechseln
        private void btnKontinentWeiter_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); // Erstellt einen neuen StringBuilder

            difmult = 0; // Setzt den Multiplikator zurück
            setzeDifmult();

            if (checkBoxAlle.Checked && panelKontinentSingleSelect.Enabled == false)
            {
                liKontinente = db.getKontinente(); // Lädt alle Kontinente
            }
            else if (!checkBoxAlle.Checked && panelKontinentSingleSelect.Enabled == true)
            {
                foreach (CheckBox cb in panelKontinentSingleSelect.Controls)
                {
                    if (cb.Checked)
                    {
                        sb.Append("'" + cb.Text + "'" + ", "); // Fügt den ausgewählten Kontinenten den StringBuilder hinzu
                    }
                }
                if (sb.Length > 0)
                {
                    sb.Length -= 2; // Entfernt die letzten beiden Zeichen
                }

                liKontinente = db.difKontinente(sb.ToString()); // Lädt die ausgewählten Kontinente

            }

            tabControlSpiel.SelectedTab = tabPageFrageAntworttyp; // Wechselt zum nächsten Tab

        }

        private void rbFrageFlaggen_CheckedChanged(object sender, EventArgs e)
        {
            frageRadioHandling();
        }

        private void btnSpielbeginnen_Click(object sender, EventArgs e)
        {
            tabControlSpiel.SelectedTab = tabPageSpiel; // Wechselt zum Spiel-Tab

            MessageBox.Show(checkedFrage);

            switch (checkedFrage)
            {
                case "Flaggen":
                    if(rbAntworttyp1.Checked || rbAntworttyp2.Checked)
                    {
                        panelSpielBildFrage.BringToFront();                        
                        panelSpielBildAntwort.SendToBack();
                        panelSpielTextOnly.SendToBack();
                        
                        // Eigentliches Spiel
                        textSpiel();


                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie einen Antworttyp aus");
                    }
                    break;
                case "Hauptstädte":
                    if (rbAntworttyp1.Checked)
                    {
                        panelSpielBildFrage.SendToBack();
                        panelSpielBildAntwort.SendToBack();
                        panelSpielTextOnly.BringToFront();
                    }
                    else if (rbAntworttyp2.Checked)
                    {
                        panelSpielBildFrage.SendToBack();
                        panelSpielBildAntwort.BringToFront();
                        panelSpielTextOnly.SendToBack();
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie einen Antworttyp aus");
                    }
                    break;
                case "Länder":
                    if(rbAntworttyp1.Checked)
                    {
                        panelSpielBildFrage.SendToBack();
                        panelSpielBildAntwort.SendToBack();
                        panelSpielTextOnly.BringToFront();
                    }
                    else if (rbAntworttyp2.Checked)
                    {
                        panelSpielBildFrage.SendToBack();
                        panelSpielBildAntwort.BringToFront();
                        panelSpielTextOnly.SendToBack();
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie einen Antworttyp aus");
                    }
                    break;
            }


        }

        #region Spiellogik

        private void textSpiel()
        {
            



        }


        #endregion

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
    }

}
