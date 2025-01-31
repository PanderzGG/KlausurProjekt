namespace SaschaKleinen
{
    public partial class MainMenu : Form
    {
        // Konstruktor der MainMenu-Klasse
        public MainMenu()
        {
            InitializeComponent(); // Initialisiert die Formularkomponenten
        }

        // Ereignishandler für den Klick auf den "Neues Spiel" Button
        private void btnNeuesSpiel_Click(object sender, EventArgs e)
        {
            NeuesSpiel nS = new NeuesSpiel(); // Erstellt eine neue Instanz des NeuesSpiel-Formulars

            nS.Show(); // Zeigt das NeuesSpiel-Formular an
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            Highscores hS = new Highscores();

            hS.Show();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
