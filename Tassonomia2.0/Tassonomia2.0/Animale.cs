using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    abstract class Animale
    {
        protected string nome;
        protected string tipoAnimale;
        protected string specie;
        protected string habitat;
        protected int numeroZampe;
        protected string siMuove;
        protected string manto;

        public abstract string Nome();
        public abstract string TipoAnimale();
        public abstract string Specie();
        public abstract string Habitat();
        public abstract int NumeroZampe();
        public abstract string Movimento();
        public abstract string Manto();

        public Animale(string type)
        {
            tipoAnimale = type;
        }

        public void StampaTutto()
        {
            Console.WriteLine("Nome: " + Nome());
            Console.WriteLine("Tipo: " + TipoAnimale());
            Console.WriteLine("Specie: " + Specie());
            Console.WriteLine("Habitat: " + Habitat());
            Console.WriteLine("Zampe: " + NumeroZampe());
            Console.WriteLine("Movimento: " + Movimento());
            Console.WriteLine("Manto: " + Manto());
        }

    }
}
