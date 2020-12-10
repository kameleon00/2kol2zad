using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol2zad
{
    class Auto : Vozilo
    {
        private string brojSasije;

        public override void ubrzaj()
        {
            trenutnaBrzina++;
        }

    }
}
