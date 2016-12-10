using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Pinguino:Uccello_Marino,Animale_Piumoso
    {
        public Pinguino(): base("Pinguino", "Antartide", "Volare e nuotare",2)
        {
        }
        public override string Nome()
        {
            return "Pinguino";
        }
        public override string Habitat()
        {
            return "Antartide";
        }
        public override string Movimento()
        {
            return "Volare e nuotare";
        }
        public string getMantoPiumato()
        {
            return "Sono pieno di piume";
        }
        public override string Manto()
        {
            return getMantoPiumato();
        }
        public override int NumeroZampe()
        {
            return 2;
        }
    }
}
