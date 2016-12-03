using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Cavallo:Quadrupede
    {
        public Cavallo():base("Cavallo","Prateria","Cammina")
        {

        }
        public override string Nome()
        {
            return "Cavallo";
        }
        public override string Habitat()
        {
            return "Prateria e pianura";
        }
        public override string Movimento()
        {
            return "Andatura";
        }
    }
}
