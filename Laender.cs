using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaschaKleinen
{
    // Repräsentiert ein Land mit allen relevanten Attributen und Kontinentzuordnung
    public class Laender
    {
        private int landID;
        private string landName;
        private string hauptstadt;
        private string flaggenPfad;
        private int kontinentID;

        public int LandID { get => landID; set => landID = value; }
        public string LandName { get => landName; set => landName = value; }
        public string Hauptstadt { get => hauptstadt; set => hauptstadt = value; }
        public string FlaggenPfad { get => flaggenPfad; set => flaggenPfad = value; }
        public int KontinentID { get => kontinentID; set => kontinentID = value; }

        public Laender(int landID, string landName, string hauptstadt, string flaggenPfad, int kontinentID)
        {
            this.landID = landID;
            this.landName = landName;
            this.hauptstadt = hauptstadt;
            this.flaggenPfad = flaggenPfad;
            this.kontinentID = kontinentID;
        }
    }
}
