using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Mammifero_Fluviale:Animale_Terrestre
    {
        public Mammifero_Fluviale(string name,string hab,string action,string mantle):base("Mammifero")
        {
            nome = name;
            habitat = hab;
            siMuove = action;
            manto = mantle;
        }
        public override string Specie()
        {
            return "Mammifero fluviale";
        }
    }
}
