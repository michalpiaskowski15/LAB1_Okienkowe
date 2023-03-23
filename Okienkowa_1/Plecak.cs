using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okienkowa_1
{
    internal class Plecak
    {
        public int pojemnosc;
        public List<Przedmiot> przedmioty;

        public Plecak(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
            przedmioty = new List<Przedmiot>();
        }

        public void DodajPrzedmiot(Przedmiot przedmiot)
        {
            przedmioty.Add(przedmiot);
        }

        public int[] Rozwiaz()
        {
            przedmioty.Sort((x, y) => (y.wartosc / y.waga).CompareTo(x.wartosc / x.waga));
            int wagaSum = 0;
            int wartoscSum = 0;
            foreach (Przedmiot przedmiot in przedmioty)
            {
                if (wagaSum + przedmiot.waga <= pojemnosc)
                {
                    wagaSum += przedmiot.waga;
                    wartoscSum += przedmiot.wartosc;
                }
                else
                {
                    break;
                }
            }
            int[] a = new int[] { wagaSum, wartoscSum };
            return a;
        }
    }
}
