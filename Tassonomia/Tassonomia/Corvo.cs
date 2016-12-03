using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Corvo:Uccello
    {
        public Corvo():base("Corvo","Ovunque")
        { 
        }
        public override string Nome()
        {
            return "Corvo";
        }
        public override string Habitat()
        {
            return "Ovunque, eccetto nei posto estremi";
        }
    }
}
