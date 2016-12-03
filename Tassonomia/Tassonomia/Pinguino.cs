using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Pinguino:Uccello
    {
        public Pinguino():base("Pinguino","Antardite")
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
    }
}
