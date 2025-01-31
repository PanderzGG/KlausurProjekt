
namespace SaschaKleinen
{
    public partial class Highscores : Form
    {
        private Datenbank db = new Datenbank();
        private Spieler spieler = new Spieler();

        private List<Spieler> liSpieler = new List<Spieler>();
        private List<Scores> liScores = new List<Scores>();

        // Konstruktor für die Highscore-Form ohne Spielerkontex
        public Highscores()
        {
            InitializeComponent();
            hideTabs();
            onLoadLists();
            fillComboBox();
        }

        // Konstruktor für Highscore-Form mit aktuellem Spieler und Spielende-Status
        public Highscores(Spieler spieler)
        {
            InitializeComponent();
            this.spieler = spieler;
            hideTabs();
            onLoadLists();
            benutzerScore();
        }

        // Versteckt sichtbare Tab-Reiter im TabControl
        private void hideTabs()
        {
            tabControlHighscores.Appearance = TabAppearance.FlatButtons;
            tabControlHighscores.ItemSize = new Size(0, 1);
            tabControlHighscores.SizeMode = TabSizeMode.Fixed;
        }
        
        // Lädt Spielerdaten und Highscores aus der Datenbank
        private void onLoadLists()
        {
            liSpieler = db.getSpieler();
            liScores = db.getScores();
        }

        // Befüllt die Spielerauswahl-ComboBox mit Benutzernamen
        private void fillComboBox()
        {
            cbSpieler.Visible = true;

            foreach (Spieler spieler in liSpieler)
            {
                cbSpieler.Items.Add(spieler.Benutzername);
            }
        }

        // Event-Handler für Anzeige der persönlichen Highscores
        private void btnMeineScores_Click(object sender, EventArgs e)
        {
            tabControlHighscores.SelectedTab = tabPageEinzelPunkte;
        }

        // Aktualisiert die Score-Anzeige bei Spielerauswahl
        private void cbSpieler_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewEinzelScores.Rows.Clear();

            spieler = liSpieler.Find(x => x.Benutzername == cbSpieler.Text);

            foreach (Scores score in liScores)
            {
                if (score.SpielerID == spieler.SpielerID)
                {
                    dataGridViewEinzelScores.Rows.Add(spieler.Benutzername, score.Punkte, score.Datum);
                }
            }
        }

        // Event-Handler für Anzeige aller gespeicherten Highscores
        private void btnAlleScores_Click(object sender, EventArgs e)
        {
            tabControlHighscores.SelectedTab = tabPageAllePunkte;

            dataGridViewEinzelScores.Rows.Clear();

            foreach(Spieler spieler in liSpieler)
            {
                foreach(Scores score in liScores)
                {
                    if(spieler.SpielerID == score.SpielerID)
                    {
                        dataGridViewAllScores.Rows.Add(spieler.Benutzername, score.Punkte, score.Datum);
                    }
                }
            }
        }

        // Zeigt nur die Highscores des aktuell eingeloggten Spielers an
        private void benutzerScore()
        {
            cbSpieler.Visible = false;

            dataGridViewEinzelScores.Rows.Clear();
            lbSpielerScores.Text = spieler.Benutzername;
            tabControlHighscores.SelectedTab = tabPageEinzelPunkte;

            foreach (Scores score in liScores)
            {
                if (score.SpielerID == spieler.SpielerID)
                {
                    dataGridViewEinzelScores.Rows.Add(spieler.Benutzername, score.Punkte, score.Datum);
                }
            }
        }
    }
}
