using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eljaras_hyak
{
    internal class Program
    {
        /*
        static void koszonto(string nev_be)
        {
            Console.WriteLine($"Űdv {nev_be}!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Köszöntés");
            Console.Write("Add meg a nevedet:");
            string nev = Console.ReadLine();
            koszonto(nev);


            Console.ReadLine();
        }
        */
        /*
        static void tomb_feltoltes(int[] tomb_be, int mettol, int meddig)
        {
            Random random = new Random();
            for (int i = 0; i < tomb_be.Length; i++)
            {
                tomb_be[i] = random.Next(mettol, meddig);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Köszöntés");
            Console.Write("Add meg a tömn elemszámát:");
            int t_elemszam = int.Parse(Console.ReadLine());
            int[] tomb = new int[t_elemszam];
            tomb_feltoltes(tomb, 500, 1200);
            foreach (var i in tomb)
            {
                Console.Write(i + ", ");
            }

            Console.ReadLine();
        }
        */
        static int EllBekerf(string bekeresuzi, int mettol, int meddig)
        {   
            int szam;
            do
            {
                Console.Write(bekeresuzi);
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            return szam;
        }

        static void Main(string[] args)
        {
            int a = 0; int b = 1000;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "ablak";
            Console.WriteLine("Köszöntés");
            string tajek = $"Adj meg a számot [{a}-{b}]:";
            EllBekerf(tajek, a, b);
        }
    }
}
