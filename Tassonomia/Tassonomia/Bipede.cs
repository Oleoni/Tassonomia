using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Bipede:Animale_Terrestre
    {
        public Bipede(string name, string hab,string action):base(2)
        {
        }
        public override int NumeroZampe()
        {
            return 2;
        }
    }
}
