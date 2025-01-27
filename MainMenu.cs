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
    }
}
