using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Balena:Mammifero_Marino
    {
        public Balena():base("Balena","Oceani","Nuotare",0,"Pelle")
        {
        }
        public override string Nome()
        {
            return "Balena";
        }
        public override string Habitat()
        {
            return "Oceani";
        }
        public override string Movimento()
        {
            return "Nuotare";
        }
        public override int NumeroZampe()
        {
            return 0;
        }
        public override string Manto()
        {
            return "Pelle";
        }
    }
}
