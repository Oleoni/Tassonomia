using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Tonno:Animale_Marino
    {
        public Tonno():base("Tonno","Oceani e mari","Nuotare")
        {
        }
        public override string Nome()
        {
            return "Tonno";
        }
        public override string Habitat()
        {
            return "Oceani e mari";
        }
        public override string Movimento()
        {
            return "Nuotare";
        }
    }
}
