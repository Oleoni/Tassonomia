using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    
    abstract class Animale_Terrestre:Animali
    {
        public Animale_Terrestre(int zampe):base("Terrestre")
        {
            numeroZampe = zampe;
        }
        public override string Tipo()
        {
            return "Terrestre";
        }
    }
}
