using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Quadrupede:Animale_Terrestre
    {
        public Quadrupede(string name,string hab,string action):base(4)
        {
            nomeAnimale = name;
            habitat = hab;
            siMuove = action;
        }
        public override int NumeroZampe()
        {
            return 4;
        }
    }
}
