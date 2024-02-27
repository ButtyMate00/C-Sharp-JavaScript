using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BM_OOP
{
    internal class Program
    {
        class Ember
        {
            public string Név;
            public int Életkor;
            public string Lakhely;
            public string Munkahely;
            public Ember(string név, int életkor, string lakhely, string munkahely)
            {
                this.Név = név; this.Életkor = életkor;
                this.Lakhely = lakhely; this.Munkahely = munkahely;
            }
            // public Ember(string név) : this(név, 0) { }
            public void Kiír()
            {
                Console.WriteLine("Név:       " + Név);
                Console.WriteLine("Életkor:   " + Életkor);
                Console.WriteLine("Lakhely:   " + Lakhely);
                Console.WriteLine("Munkahely: " + Munkahely);

            }
        }
        static (string, int, string, string) emberadatgen()
        {
            Random rnd = new Random();  
            Console.Write("Add meg a dolgozó nevét:");
            var tempNev = Console.ReadLine();
            var tempEletkor = rnd.Next(17, 65);
            string[] telepulesek = new string[] { "Kecskemét", "Ogorvány", "Csengele", "Gátér", "Kunszállás" };
            var tempLakhely = telepulesek[rnd.Next(0, telepulesek.Length-1)];
            Console.Write("Adje meg a munkehely cégnevét:");
            var tempMunkahely = Console.ReadLine();

            return (tempNev, tempEletkor, tempLakhely, tempMunkahely);
        }

        static void Main(string[] args)
        {
            var tempNev       = "Tóth József";
            var tempEletkor   = 32;
            var tempLakhely   = "Eger";
            var tempMunkahely = "XYZ Kft.";

            Ember cegvezeto = new Ember(tempNev, tempEletkor, tempMunkahely, tempLakhely);
            cegvezeto.Kiír();
            Console.ReadKey();
            var eredmeny = emberadatgen();
            Ember dolgozo = new Ember(eredmeny.Item1, eredmeny.Item2, eredmeny.Item3, eredmeny.Item4);
            dolgozo.Kiír();

            Console.ReadKey();
        }
    }
}
