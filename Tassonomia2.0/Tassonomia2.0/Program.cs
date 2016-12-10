using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo u = new Uomo();
            u.StampaTutto();
            Console.WriteLine("--------------");
            Cavallo c = new Cavallo();
            c.StampaTutto();
            Console.WriteLine("--------------");
            Ippopotamo i = new Ippopotamo();
            i.StampaTutto();
            Console.WriteLine("--------------");
            Corvo co = new Corvo();
            co.StampaTutto();
            Console.WriteLine("--------------");
            Pinguino p = new Pinguino();
            p.StampaTutto();
            Console.WriteLine("--------------");
            Balena b = new Balena();
            b.StampaTutto();
            Console.WriteLine("--------------");
            Salmone s = new Salmone();
            s.StampaTutto();
            Console.WriteLine("--------------");
            Tonno t = new Tonno();
            t.StampaTutto();
            Console.ReadLine();
        }
    }
}
