using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol2zad
{
    abstract class Vozilo : Ivoznja
    {
        protected int trenutnaBrzina;
        protected int maxBrzina;
        protected bool motorStartovan;

        public abstract void ubrzaj();

        public void start()
        {
            trenutnaBrzina = 0;
            motorStartovan = true;
        }
        public void zaustavi()
        {
            trenutnaBrzina = 0;
        }
        public void parkiraj()
        {
            trenutnaBrzina = 0;
            motorStartovan = false;
        }
    }
}
