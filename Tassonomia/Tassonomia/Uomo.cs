using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Uomo:Bipede
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
    }
}
