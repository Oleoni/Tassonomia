using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Ippopotamo : Mammifero_Fluviale, Quadrupede
    {
        public Ippopotamo(): base("Ippo", "Fluviale", "Cammina e nuota","Pelle")
        {
        }
        public override string Nome()
        {
            return "Ippopotamo";
        }
        public override string Habitat()
        {
            return "Fiumi";
        }
        public override string Movimento()
        {
            return "Camminare e nuotare";
        }
        public int getZampe()
        {
            return 4;
        }
        public override int NumeroZampe()
        {
            return getZampe();
        }
        public override string Manto()
        {
            return "Pelle";
        }
    }
}

