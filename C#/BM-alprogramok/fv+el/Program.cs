﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fv_el
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            Kiir(); //Meghívás
            Osszeg();
            int i = Pelda();
            Console.WriteLine(i);

            Console.ReadLine();  
        }
        static void Kiir()
        { //Maga az alprogram
            int eredmeny = Osszeg();
            Console.WriteLine(Osszeg());
            Console.WriteLine("Üdvözöllek a programban! ");

        } //visszatérés
        static int Osszeg()
        {
            return 5 + 7;
        } // visszatérés int 12-vel
        static int Pelda()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) return i;
            }
            return 0;
        }
        */
        /*
        static void Main(string[] args)
        {
            Udvozlet(); //nézzük meg mi lesz a kimenet ez és
            Udvozlet("Helló!", 9); //ez esetén
            Console.ReadLine();
        }
        static void Udvozlet(string s = "Köszöntelek a programban!", int db = 0) { Console.WriteLine(s + db); }        */
        static void Main(string[] args)
        {
            int a = 6, b = 4, c;
            c = KetszeresetOsszeadoFuggveny(a, b);
            Console.WriteLine("\'a\' értéke:{0}\n\'b\' értéke:{1}\n\'c\' értéke:{2}", a, b, c);
            //a: 6, b: 4, c: 20
            Console.ReadKey();
        }
        static int KetszeresetOsszeadoFuggveny(int szam1, int szam2)
        {
            szam1 = szam1 * 2; szam2 = szam2 * 2;
            return szam1 + szam2;
        }
    }
}


