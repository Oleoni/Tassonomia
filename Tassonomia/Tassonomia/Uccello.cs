using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uccello:Bipede
    {
        public Uccello(string name, string hab):base(name,hab,"volare")
        {
        }
        public override string Movimento()
        {
            return "Volare";
        }
    }
}
