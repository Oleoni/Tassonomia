using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Salmone:Animale_Fluviale
    {
        public Salmone():base("Salmone","Fiumi e laghi","Nuotare")
        {
        }
        public override string Nome()
        {
            return "Salmone";
        }
        public override string Habitat()
        {
            return "Fiumi, laghi e raramente nei mari e oceani";
        }
        public override string Movimento()
        {
            return "Nuotare";
        }
    }
}
