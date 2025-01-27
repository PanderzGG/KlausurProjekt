using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaschaKleinen
{
    public class Spieler
    {
        private int spielerID;
        private string benutzername;

        public int SpielerID { get => spielerID; set => spielerID = value; }
        public string Benutzername { get => benutzername; set => benutzername = value; }

        public Spieler(int spielerID, string benutzername)
        {
            this.spielerID = spielerID;
            this.benutzername = benutzername;
        }
    }
}
