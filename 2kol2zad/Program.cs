using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol2zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Ivoznja iv = new Auto();

            iv.start();
         // iv.ubrzaj();  GRESKA  zato sto je u Ivoznja ne nalazi ubrzaj
            iv.zaustavi();
            iv.parkiraj();
            Console.WriteLine();

            Avion a = new Avion();

            a.start();
            a.ubrzaj();
            a.zaustavi();
            a.parkiraj();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
