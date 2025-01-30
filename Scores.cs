using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaschaKleinen
{
    // Repräsentiert Highscores mit Spielerzuordnung, Punkten und Zeitstempel
    public class Scores
    {
        private int scoreID;
        private int spielerID;
        private int punkte;
        private DateTime datum;

        public int ScoreID { get => scoreID; set => scoreID = value; }
        public int SpielerID { get => spielerID; set => spielerID = value; }
        public int Punkte { get => punkte; set => punkte = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public Scores(int scoreID, int spielerID, int punkte, DateTime datum)
        {
            this.scoreID = scoreID;
            this.spielerID = spielerID;
            this.punkte = punkte;
            this.datum = datum;
        }

        public Scores()
        {

        }
    }
}
