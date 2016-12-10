using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Cavallo:Mammifero_Terrestre,Quadrupede,Animale_Peloso
    {
        public Cavallo():base("Cavallo","Praterie","Camminare")
        {
        }
        public override string Nome()
        {
            return "Cavallo";
        }
        public override string Habitat()
        {
            return "Praterie";
        }
        public override string Movimento()
        {
            return "Camminare";
        }
        public int getZampe()
        {
            return 4;
        }
        public override int NumeroZampe()
        {
            return getZampe();
        }
        public string getMantoPeloso()
        {
            return "Sono pieno di peli";
        }
        public override string Manto()
        {
            return getMantoPeloso();
        }
    }
}
