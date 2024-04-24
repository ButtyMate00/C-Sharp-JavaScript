using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BM_etterem
{
    internal class Program
    {
        class elem
        {
            public elem(string BevetelLista)
            {
                var Bevetel = BevetelLista.Split(',');
                Összeg = int.Parse(Bevetel[0]);

            }
            public int Összeg;
        }
        static void Main(string[] args)
        {
            ArrayList BevetelLista = new ArrayList();
            var Bevetel = File.ReadAllLines("bevetel.csv");
            List<string> BevetelAddList = Bevetel.ToList();
            foreach (string s in BevetelAddList) BevetelLista.Add(new elem(s));

            //#1
            Console.WriteLine("#1");
            int all = 0;
            int db = 0;
            foreach (object s in BevetelLista)
            {
                elem ertek = s as elem;
                all += ertek.Összeg;
                db++;
            }
            Console.WriteLine($"Teljes bevétel:{all}Ft");
            Console.WriteLine($"Napi átlag:{all/db}Ft");

            Console.WriteLine();
            Console.WriteLine("#2");
            db = 0;
            int hetvege_db = 0;
            all = 0;
            foreach (object s in BevetelLista)
            {
                elem ertek = s as elem;
                db++;
                if (db % 6 == 0 || db % 7 == 0)
                {
                    all += ertek.Összeg;
                    hetvege_db++;
                }
            }
            Console.WriteLine($"A hetvégék bevételének az átlaga:{all/hetvege_db}");

            
            Console.WriteLine("#3");


            List<DateTime> Schedule = new List<DateTime>();

            DateTime Base = new DateTime(2023, 01, 01);

            for (int i = 0; i < 365; i++)
                Schedule.Add(Base.AddDays(i));
            Console.WriteLine(string.Join(System.Environment.NewLine,Schedule));


            Console.ReadLine();
        }
    }
}
