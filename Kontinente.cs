using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaschaKleinen
{

    // Definiert Kontinente mit eindeutiger ID für die Spiel-Logik
    public class Kontinente
    {
        private int kontinentID;
        private string kontinentName;

        public int KontinentID { get => kontinentID; set => kontinentID = value; }
        public string KontinentName { get => kontinentName; set => kontinentName = value; }

        public Kontinente(int kontinentID, string kontinentName)
        {
            this.kontinentID = kontinentID;
            this.kontinentName = kontinentName;
        }
    }
}
