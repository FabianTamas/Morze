using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    class Szoveg
    {
        private string szerzo;

        public string Szerzo
        {
            get { return szerzo; }
        }

        private string idezet;

        public string Idezet
        {
            get { return idezet; }
        }

        private int hossz;

        public int Hossz
        {
            get { return hossz; }
        }

        public Szoveg(string szerzo, string idezet)
        {
            this.szerzo = szerzo;
            this.idezet = idezet;
            hossz = this.idezet.Length;
        }
    }
}
