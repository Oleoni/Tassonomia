using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
     abstract class Animali
    {
        protected string nomeAnimale;
        protected string habitat;
        protected string tipoAnimale;
        protected int numeroZampe;
        protected string siMuove;


        public abstract string Nome();
        public abstract string Habitat();
        public abstract string Tipo();
        public abstract int NumeroZampe();
        public abstract string Movimento();

        public Animali(string type)
        {
            tipoAnimale = type;
        }

        public void StampaTutto()
        {
            Console.WriteLine("Nome: " + Nome());
            Console.WriteLine("Animale: " + Tipo());
            Console.WriteLine("Habitat: " + Habitat());
            Console.WriteLine("Numero delle zampe: " + NumeroZampe());
            Console.WriteLine("Movimento : " + Movimento());
        }
    }
}
