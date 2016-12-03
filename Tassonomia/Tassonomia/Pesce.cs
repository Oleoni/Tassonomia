using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Pesce:Animale_Acquatico
    {
        public Pesce(string type):base(0)
        {
        }
        public override int NumeroZampe()
        {
            return 0;
        }
    }
}
