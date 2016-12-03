using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cavallo c = new Cavallo();
            c.StampaTutto();
            Console.WriteLine("-------------------------------");
            Uomo u = new Uomo();
            u.StampaTutto();
            Console.WriteLine("-------------------------------");
            Pinguino p = new Pinguino();
            p.StampaTutto();
            Console.WriteLine("-------------------------------");
            Corvo co = new Corvo();
            co.StampaTutto();
            Console.WriteLine("-------------------------------");
            Salmone s = new Salmone();
            s.StampaTutto();
            Console.WriteLine("-------------------------------");
            Tonno t = new Tonno();
            t.StampaTutto();
            Console.WriteLine("-------------------------------");
            Console.ReadLine();

        }
    }
}
