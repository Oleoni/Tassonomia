using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Animale_Marino:Animale
    {
        public Animale_Marino(string species):base("Marino")
        {
            specie = species;
        }
        public override string TipoAnimale()
        {
            return "Marino";
        }
    }
}
