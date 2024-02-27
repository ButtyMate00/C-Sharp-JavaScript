using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace aruhitel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BM-2023.09.27     
            //áruhitel

            Console.WriteLine("Áruhitel");
            Console.WriteLine("--------");

            Console.Write("Adja meg a termék árát: ");
            int termek_ar = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a számlája fedezetét: ");
            int szamla_fedezet = int.Parse(Console.ReadLine());

            if (szamla_fedezet >= termek_ar)
            {
                Console.WriteLine("Sikeres vásárlás!");
            }
            else
            {
                Console.WriteLine("Van hitelkártyája? [Van/Nincs]: ");
                string hitel_kartya_van = Console.ReadLine();
                if (hitel_kartya_van == "Van" || hitel_kartya_van == "van")
                {
                    Console.WriteLine("Sikeres vásárlás.");
                }
                else 
                {
                    Console.WriteLine("Nincs fedezet a vásárláshoz.");
                }
            }

            Console.ReadKey();


        }
    }
}
