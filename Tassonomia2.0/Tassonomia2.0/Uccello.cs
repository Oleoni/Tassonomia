using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Uccello:Animale_Terrestre,Animale_Piumoso
    {
        public Uccello(string name, string hab, string action,int number):base("Uccello")
        {
            nome = name;
            habitat = hab;
            siMuove = action;
            numeroZampe = number;
        }
        public override string Specie()
        {
            return "Uccello";
        }
        public string getMantoPiumato()
        {
            return "Sono pieno di piume";
        }
        public override string Manto()
        {
            return getMantoPiumato();
        }
    }
}
