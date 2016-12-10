using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Salmone:Pesce
    {
        public Salmone():base("Salmone","Fiumi e laghi","Nuotare",0)
        { 
        }
        public override string Nome()
        {
            return "Salmone";
        }
        public override string Habitat()
        {
            return "Fiumi e laghi";
        }
        public override string Movimento()
        {
            return "Nuotare";
        }
        public override int NumeroZampe()
        {
            return 0;
        }
    }
}
