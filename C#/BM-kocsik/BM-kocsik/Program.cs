using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM_kocsik
{
    internal class Program
    {
        class Kocsi
        {
            public Kocsi(string rendszam, string marka)// int evjarat, string szin, int ertek)
            {
                Rendszám = rendszam; Márka = marka; // ÉVjárat = evjarat; Szín = szin; Érték = ertek;

            }
            private string rendszam;
            public string Rendszám
            {
                get { return rendszam; }
                set
                {
                    if (value.Length == 9) rendszam = value;
                    else Console.WriteLine("A rendszám pontossan 9 karakter hosszú kell legyen!");
                }
            }
            private string marka;
            public string Márka
            {
                get { return rendszam; }
                set
                {
                    string[] markak = new string[] {"BMW", "Fiat", "Volvo", "Peugeot", "VolksWagen"};
                    Random rnd = new Random();
                    marka = markak[rnd.Next(markak.Length)];

                }
            }
            private void Exception(string s)
            {
                throw new FormatException(s);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("BM-kocsik-OOP");
            Console.Write("Írj be egy rendszámot(9):");
            string rendszam_temp = Console.ReadLine(); 
            Kocsi k = new Kocsi(rendszam_temp);

            Console.Write(k.Rendszám);
            Console.ReadLine();
        }
    }
}
