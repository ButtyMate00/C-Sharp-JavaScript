using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM_OOP_kutya
{
    internal class Program
    {
        class Kutya
        {
            public string Név;
            private int ÉhségJelző = 50;
            public Kutya(string n, int éh)
            {
                this.Név = n; this.ÉhségJelző = éh;
            }
            public void Etet(int étel)
            {
                ÉhségJelző -= étel;
                Console.WriteLine($"{Név} kapott {étel} ételt.");
            }
            public void Játék()
            {
                if (ÉhségJelző <= 80)
                {
                    ÉhségJelző += 50;
                    Console.WriteLine($" {Név} Játszik...");
                }
                else Console.WriteLine($"A {Név} éhes, nem tudsz játszani vele!");
                Console.WriteLine($"{Név} éhsége:{ÉhségJelző}");
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Add meg a nevét:");
            var kutyanev = Console.ReadLine();
            var kutyehseg = rnd.Next(90);
            Kutya k = new Kutya(kutyanev, kutyehseg);
            k.Játék();
            k.Etet(rnd.Next(90));
            k.Játék();
            Console.ReadKey();

        }
    }
}
