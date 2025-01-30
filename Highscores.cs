using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaschaKleinen
{
    public partial class Highscores : Form
    {
        private Datenbank db = new Datenbank();
        private Spieler spieler = new Spieler();

        private List<Spieler> liSpieler = new List<Spieler>();
        private List<Scores> liScores = new List<Scores>();

        private int highscore;

        public Highscores()
        {
            InitializeComponent();
            hideTabs();
            onLoadLists();
            fillComboBox();
        }

        private void hideTabs()
        {
            tabControlHighscores.Appearance = TabAppearance.FlatButtons;
            tabControlHighscores.ItemSize = new Size(0, 1);
            tabControlHighscores.SizeMode = TabSizeMode.Fixed;
        }

        private void onLoadLists()
        {
            liSpieler = db.getSpieler();
            liScores = db.getScores();
        }

        private void fillComboBox()
        {
            foreach (Spieler spieler in liSpieler)
            {
                cbSpieler.Items.Add(spieler.Benutzername);
            }
        }

        private void btnMeineScores_Click(object sender, EventArgs e)
        {
            tabControlHighscores.SelectedTab = tabPageEinzelPunkte;
        }

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
    }
}
