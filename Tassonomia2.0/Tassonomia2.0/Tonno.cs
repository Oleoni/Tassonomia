using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Tonno:Pesce
    {
        public Tonno():base("Tonno","Mare e oceani","Nuotare",0)
        {
        }
        public override string Nome()
        {
            return "Tonno";
        }
        public override string Habitat()
        {
            return "Mare e oceani";
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
