using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Uccello_Marino : Animale_Marino
    {
        public Uccello_Marino(string name, string hab, string action,int number): base("Uccello Marino")
        {
            nome = name;
            habitat = hab;
            siMuove = action;
            numeroZampe = number;
        }
        public override string Specie()
        {
            return "Uccello Marino";
        }
    }
}