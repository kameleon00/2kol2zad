using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol2zad
{
    class Avion : Vozilo
    {
        public int rasponKrila;

        public override void ubrzaj()
        {
            trenutnaBrzina++;
        }
    }
}
