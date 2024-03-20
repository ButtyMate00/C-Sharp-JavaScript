using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MM_csudh
{
    internal class Program
    {
        class DomainInfo
        {
            public string DomainNév { get; set; }
            public string SzintRész(int szint)
            {
                string[] részek = DomainNév.Split('.');
                int mélység = részek.Length;

                if (szint <= 0 || szint > mélység)
                    return "nincs";

                return részek[mélység - szint]; 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: ");
            var file = File.ReadAllLines("csudh.txt");
            List<string> list = file.ToList();
            list.RemoveAt(0);
            list.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("3. feladat: Domainek száma: {0}", list.Count);
            Console.WriteLine("5. feladat: Az első domain felépítése: ");

            DomainInfo domainInfo = new DomainInfo();
            domainInfo.DomainNév = "edu.csudh.dhvx20";
            var db = 1;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("\t"+db);
                Console.WriteLine(". szint: {0}", domainInfo.SzintRész(i));
                db++;
            }


            Console.ReadKey();

        }
    }
}