using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Fluviale:Pesce
    {
        public Animale_Fluviale(string name,string hab,string action ):base("Fluviale")
        { 
        }
        public override string Tipo()
        {
            return "Fluviale";
        }
    }
}
