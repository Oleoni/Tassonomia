using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Pesce:Animale_Marino,Animale_Squamoso
    {
        public Pesce(string name, string hab, string action,int number):base("Pesce")
        {
            nome = name;
            habitat = hab;
            siMuove = action;
            numeroZampe = number;
        }
        public override string Specie()
        {
            return "Pesce";
        }
        public string getMantoSquamoso()
        {
            return "Sono pieno di squame";
        }
        public override string Manto()
        {
            return getMantoSquamoso();
        }
    }
}
