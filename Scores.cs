using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaschaKleinen
{
    public class Scores
    {
        private int scoreID;
        private int spielerID;
        private int punkte;

        public int ScoreID { get => scoreID; set => scoreID = value; }
        public int SpielerID { get => spielerID; set => spielerID = value; }
        public int Punkte { get => punkte; set => punkte = value; }

        public Scores(int scoreID, int spielerID, int punkte)
        {
            this.scoreID = scoreID;
            this.spielerID = spielerID;
            this.punkte = punkte;
        }
    }
}
