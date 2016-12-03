using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
   abstract class Animale_Marino:Pesce
    {
        public Animale_Marino(string name, string hab, string action):base("Marino")
        {
        }
        public override string Tipo()
        {
            return "Marino";
        }
    }
}
