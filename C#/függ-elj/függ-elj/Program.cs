using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace függ_elj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.Write("Add meg egy szót:");
            var szo = Console.ReadLine();
            Console.WriteLine(szoh(szo));
            // 2
            Console.Write("Add meg egy számot:");
            string szam = Console.ReadLine();
            Console.WriteLine(sum(szam));
            // 3
            Console.WriteLine("Add meg egy számot:");
            Console.Write("1. :");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("2. :");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine(osszeg(szam1,szam2));
            // 4
            List<int> szamok = new List<int>() {1, 2, 3, 4, 5, 6, 7 ,8 ,9, 10 };
            var eredmeny = ParatlanParos(szamok);
            foreach (var item in eredmeny.Paros)
            {
                Console.WriteLine(item);
            }
            foreach (var item in eredmeny.Paratlan)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ParatlanParos(szamok));
            // 5
            Console.Write("Add meg egy szót:");
            var szo3 = Console.ReadLine();
            Console.WriteLine(vissza(szo3));
            // 7
            Console.Write("Add meg egy szót:");
            var buzz = Console.ReadLine();
            Console.WriteLine(Fizz(buzz));

            Console.ReadLine();
        }
        //1
        static string szoh(string nev)
        {
            var szhossz = nev.Length;
            Console.Write(szhossz);
            return " db";
        }
        //2
        static string sum(string szam)
        {
            var eredmeny = szam.Select(x => int.Parse(x.ToString())).Sum();
            Console.WriteLine(eredmeny);
            return null;
        }
        //3
        static int osszeg(int szam, int szam1)
        {
            szam += szam1;
            return szam;
        }
        //4
        static (List<int> Paratlan, List<int> Paros) ParatlanParos(List<int> ParatlanParos)
        {
            List<int> Paratlan = new List<int>();
            List<int> Paros = new List<int>();

            foreach(var szam in ParatlanParos)
            {
                if (szam % 2 ==0)
                    Paratlan.Add(szam);
                else Paratlan.Add(szam);


            }
            return (Paratlan, Paros);
        }
        //5
        static string vissza(string szo)
        {
            char[] asd = szo.ToArray();
            Array.Reverse(asd);
            Console.WriteLine(asd);
            return null;
        }
        //7
        static string Fizz(string szam)
        {
            string eredmeny = "";
            if (int.Parse(szam) % 3 == 0)
                eredmeny = "Fizz";
            else if (int.Parse(szam) % 5 == 0)
                eredmeny = "FizzBuzz";
            else if (int.Parse(szam) % 5 == 0 && int.Parse(szam) % 3 == 0);
            else Console.WriteLine(szam);
                eredmeny = szam.ToString();
            return eredmeny;

        }

    }
    
}
