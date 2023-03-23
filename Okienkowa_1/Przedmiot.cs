using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okienkowa_1
{
    internal class Przedmiot
    {
        public int id;
        public int waga;
        public int wartosc;

        public Przedmiot(int id, int waga, int wartosc)
        {
            this.id = id;
            this.waga = waga;
            this.wartosc = wartosc;
        }
    }
}
