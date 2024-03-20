using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BM_eu
{
    internal class Program
    {
        class Eu
        {
            public string Orszag;
            public string Ev;
            public Eu(string lista)
            {
                var kislista = lista.Split(';');
                Orszag = kislista[0];
                Ev = kislista[1];
            }
            
        }

        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            int[] evek = new int[28];

            var file = File.ReadAllLines("EUcsatlakozas.txt");
            List<string> list = file.ToList();
            foreach (string s in list)
            {

                lista.Add(new Eu(s));

            }

            var db = 0;
            foreach (object s in lista)
            {
                db++;
            }
            Console.WriteLine($"3.) {db}");
            var a = -1;
            Console.WriteLine("2.)");
            foreach (object s in lista)
            {
                a++;
                Eu teszt = s as Eu;
                string str = teszt.Ev;
                int res = int.Parse(str.Substring(0, 4));
                if (res == 2007) Console.WriteLine(teszt.Orszag);
            }
            Console.ReadLine();
        }

    }
}
