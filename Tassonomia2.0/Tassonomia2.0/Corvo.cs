using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Corvo:Uccello
    {
        public Corvo():base("Corvo","Alberi","Volare",2)
        {
        }
        public override string Nome()
        {
            return "Corvo";
        }
        public override string Habitat()
        {
            return "Alberi";
        }
        public override string Movimento()
        {
            return "Volare";
        }
        public override int NumeroZampe()
        {
            return 2;
        }
    }
}
