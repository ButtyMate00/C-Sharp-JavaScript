using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BM 2023-09-20
            //Téglalap kerülete és területe

            Console.WriteLine("Téglalap kerülete és területe");
            Console.WriteLine("------------------------------");

            Console.Write("Add meg a téglalap a alapoldalának hosszát (cm): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Add meg a téglalap b alapoldalának hosszát (cm): ");
            int b = int.Parse(Console.ReadLine());

            //Console.WriteLine(a + " " + b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.Write("A téglalap kerülete: " );
            //Console.Write(2*a+2*b);
            Console.WriteLine(2 * (a + b) + "cm");

            Console.Write("A téglalap területe: ");
            Console.WriteLine(a * b + "cm2");



            Console.ReadKey();

        }
    }
}
