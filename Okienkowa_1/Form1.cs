using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okienkowa_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pojemnosc;
            int numprzedmioty;
            if (int.TryParse(pojemnoscTextBox.Text, out pojemnosc) && int.TryParse(numprzedmiotyTextBox.Text, out numprzedmioty))
            {
                Random random = new Random(1); //tworzenie obiektu
                Plecak backpack = new Plecak(pojemnosc);
                wynikTextBox.Clear();
                wynikTextBox.AppendText("Wygenerowane przedmioty:\n");
                wynikTextBox.AppendText("Numer\tWaga\tWartosc\n");
                wynikTextBox.AppendText("\n");
                for (int i = 0; i < numprzedmioty; i++)
                {
                    int waga = random.Next(1, 10);
                    int wartosc = random.Next(1, 20);
                    Przedmiot item = new Przedmiot(i, waga, wartosc);
                    backpack.DodajPrzedmiot(item);
                    wynikTextBox.AppendText(item.id + "\t" + waga + "\t" + wartosc + "\n");
                }
                int wagaSum = backpack.Rozwiaz()[0];
                int wartoscSum = backpack.Rozwiaz()[1];
                wynikTextBox.AppendText("\nW plecaku o pojemnosci " + pojemnosc + " zmieszczono przedmioty o wartosci: " + wartoscSum + " i wadze: " + wagaSum);
            }
            //else
            //{
            //    MessageBox.Show("Brak danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
        }
 