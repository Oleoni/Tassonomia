using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Animale_Terrestre:Animale
    {
        public Animale_Terrestre(string species):base("Terrestre")
        {
            specie = species;
        }
        public override string TipoAnimale()
        {
            return "Terrestre";
        }
    }
}
