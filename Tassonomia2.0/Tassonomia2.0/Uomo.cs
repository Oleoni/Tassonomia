using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Uomo:Mammifero_Terrestre,Bipede,Animale_Peloso
    {
        public Uomo():base("Uomo","Ovunque","Camminare")
        {
        }
        public override string Nome()
        {
            return "Uomo";
        }
        public override string Habitat()
        {
            return "Ovunque";
        }
        public override string Movimento()
        {
            return "Camminare";
        }
        public int getZampe()
        {
            return 2;
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
