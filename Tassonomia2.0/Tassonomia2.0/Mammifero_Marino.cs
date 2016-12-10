using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Mammifero_Marino:Animale_Marino
    {
        public Mammifero_Marino(string name,string hab, string action,int number,string mantle):base("Mammifero Marino")
        {
            nome = name;
            habitat = hab;
            siMuove = action;
            numeroZampe = number;
            manto = mantle;
        }
        public override string Specie()
        {
            return "Mammifero Marino";
        }
    }
}
