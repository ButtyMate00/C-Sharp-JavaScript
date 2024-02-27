using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feltételvizsgálat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BM 2023-09-20
            //Feltételvizsgálat kszámítása

            Console.WriteLine("Átlag kszámítása");
            Console.WriteLine("----------------");

            Console.Write("Add meg az életkorodat");
            int eletkor = int.Parse(Console.ReadLine());

            if (eletkor >= 18)
              { Console.WriteLine("Vehetsz sört!"); }
            else
              { Console.WriteLine("Nem vehetsz sört!"); }

            Console.ReadKey();
        }
    }
}
