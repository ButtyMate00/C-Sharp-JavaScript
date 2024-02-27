using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BM_E_F_Gyakorlás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.Write("Add meg a neved:");
            var neve = Console.ReadLine();
            Console.WriteLine(Osszeg(neve));
            // 2 
            Console.Write("Add meg a hőmérsékletet(Celsius):");
            var celsius = double.Parse(Console.ReadLine());
            Console.WriteLine(Celsius(celsius) + " F");
            //3 
            Console.Write("Add meg a keresztneved:");
            var neve_kereszt = Console.ReadLine();
            Console.Write("Add meg a vezetek:");
            var neve_vezetek = Console.ReadLine();
            Console.WriteLine(VezKer(neve_kereszt, neve_vezetek));
            Console.ResetColor();
            //4
            Console.Write("Add meg a számot:");
            string szam = (Console.ReadLine());
            Console.WriteLine(Szor(szam));
            //5
            int[] tomb = new int[10];
            Random random = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(0, 50);
            }
            // Console.WriteLine(Sor(tomb));
            //6
            Console.Write("Add meg a számot:");
            int afa_szam = int.Parse(Console.ReadLine());
            Console.WriteLine("AFA(egesz): " + Afa(afa_szam));
            Console.ReadLine();
            //7
            Console.Write("Add meg a korod:");
            int evszam = int.Parse(Console.ReadLine());
            Console.WriteLine(Kor(evszam));
            Console.ReadLine();
        }
        static string Osszeg(string nev)
        {
            var tel_nev = "Üdv " + nev + "!";
            return tel_nev;
        }
        static double Celsius(double cel)
        {
            cel = ((cel / 5) * 9) + 32;
            return cel;
        }
        static string VezKer(string ker, string vez)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ker);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(vez);
            return "";
        }
        static string Szor(string szam)
        {
            string szam1 = "10x:" + int.Parse(szam)*10 + " 100x:" + int.Parse(szam) * 100 + " 1000x:" + int.Parse(szam) * 1000;

            return szam1;
        }
        static void Sor(int[] szam)
        {
            for (int i = 0; i < szam.Length; i++)
            {
                for (int j = 1; j < szam.Length; i++)
                {
                    if (i > j) szam[i] = j;
                }
            }
        }
        static int Afa(double szam)
        {
            szam = szam * 0.27;
            return (int)szam;
        }
        static int Kor(int szam)
        {
            szam = 2024 - szam;
            return szam;
        }
    }
}
