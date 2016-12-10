using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Mammifero_Terrestre:Animale_Terrestre
    {
        public Mammifero_Terrestre(string name, string hab, string action):base("Mammifero terrestre")
        {
            nome = name;
            habitat = hab;
            siMuove = action;
        }
        public override string Specie()
        {
            return "Mammifero terrestre";
        }
    }
}
