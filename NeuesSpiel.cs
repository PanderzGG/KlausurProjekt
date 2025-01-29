
namespace SaschaKleinen
{
    public partial class NeuesSpiel : Form
    {
        private Datenbank db = new Datenbank(); // Erstellt eine Instanz der Datenbankklasse

        private List<Spieler> liSpieler; // Liste zum Speichern der Spieler
        private bool isNeuerSpieler; // Boolescher Wert zur Unterscheidung neuer oder vorhandener Spieler

        // Konstruktor der NeuesSpiel-Klasse
        public NeuesSpiel()
        {
            InitializeComponent(); 
            hideTabs();
            onLoadSpieler();
        }

        // Blendet bestimmte Tabs im TabControl aus
        private void hideTabs()
        {
            tabControlNeuesSpiel.Appearance = TabAppearance.FlatButtons;
            tabControlNeuesSpiel.ItemSize = new Size(0, 1);
            tabControlNeuesSpiel.SizeMode = TabSizeMode.Fixed;
        }

        // Lädt die Liste der vorhandenen Spieler aus der Datenbank
        private void onLoadSpieler()
        {
            liSpieler = db.getSpieler();
        }

        #region Buttons
        // Klick-Event für den Button "Neuer Spieler"
        private void btnNeuerSpieler_Click(object sender, EventArgs e)
        {
            tabControlNeuesSpiel.SelectedTab = tabPageNeuerSpieler; // Wechselt zum Tab für neuen Spieler
            isNeuerSpieler = true; // Setzt den booleschen Wert auf 'neuer Spieler'
        }

        // Klick-Event für den Button "Vorhandener Spieler"
        private void btnVorhandenerSpieler_Click(object sender, EventArgs e)
        {
            tabControlNeuesSpiel.SelectedTab = tabPageVorhandenerSpieler; // Wechselt zum Tab für vorhandenen Spieler
            isNeuerSpieler = false; // Setzt den booleschen Wert auf 'vorhandener Spieler'
        }

        // Klick-Event für den Button "Spiel starten"
        private void btnSpielerNeuSpielen_Click(object sender, EventArgs e)
        {
            int spielerid;
            Spieler spieler = new Spieler();

            if (isNeuerSpieler)
            {
                spieler.Benutzername = tbBenutzername.Text;
                
                if (spieler.Benutzername != "")
                {
                    db.newSpieler(spieler); // Fügt den neuen Spieler in der Datenbank hinzu
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie einen Benutzernamen ein."); // Zeigt Fehlermeldung an
                    return; // Methode hier beenden
                }
            }
            else
            {
                if (cbBenutzernamen.Text != "") // Prüft, ob ein Benutzername ausgewählt wurde
                {
                    spieler.Benutzername = cbBenutzernamen.Text; // Übernimmt den ausgewählten Namen
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie einen Benutzernamen aus."); // Zeigt Fehlermeldung an
                    return; // Methode hier beenden
                }
            }

            liSpieler = db.getSpieler();
            spielerid = liSpieler.Find(x => x.Benutzername == spieler.Benutzername).SpielerID;
            spieler.SpielerID = spielerid;

            Spiel s = new Spiel(spieler); // Erstellt ein neues Spiel-Formular mit dem Spielernamen
            //s.FormClosed += new FormClosedEventHandler(s_FormClosed); Event, wenn das Spiel-Formular geschlossen wird
            s.Show(); // Zeigt das Spiel-Formular an
            this.Close();
        }
        #endregion

        // Event, wenn sich der ausgewählte Tab ändert
        private void tabControlNeuesSpiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlNeuesSpiel.SelectedIndex == 2) // Wenn Tab 3 ausgewählt ist
            {
                cbBenutzernamen.Items.Clear(); // Leert die Combobox

                foreach (Spieler s in liSpieler)
                {
                    cbBenutzernamen.Items.Add(s.Benutzername); // Fügt jeden vorhandenen Spielernamen hinzu
                }
            }
        }
    }
}
