using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Acquatico:Animali
    {
        public Animale_Acquatico(int zampe):base("Acquatico")
        {

        }
        public override string Tipo()
        {
            return "Acquatico";
        }
    }
}
