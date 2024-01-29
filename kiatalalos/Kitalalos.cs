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
        public Kitalalos(string rejtettszo, string tipp, string valasz)
        {
            this.rejtettszo = rejtettszo;
            this.tipp = tipp;
            this.valasz = valasz;
        }
        public override string ToString()
        {
            return this.rejtettszo;
        }
    }
}
