using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiatalalos
{
    internal class Kitalalos : Program
    {
        public string rejtettszo;
        public string tipp;
        public string valasz;
        public int tippSzam = 0;
        public struct szavak
        {
            public string rejtettszo;
            public string tipp;
            public string valasz;
        }
        public Kitalalos(string rejtettszo, string tipp, string valasz, int tippSzam)
        {
            this.rejtettszo = rejtettszo;
            this.tipp = tipp;
            this.valasz = valasz;
            this.tippSzam = tippSzam;
        }
        public override string ToString()
        {
            return this.rejtettszo;
        }
    }
}
