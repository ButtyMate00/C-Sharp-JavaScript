using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BM_bizonyitvan
{
    internal class Program
    {
        class Diák

        {
            public string név;
            public int magyar;
            public int tortenelem;
            public int matek;
            public int angol;
            public int igazolt;
            public int igazolatlan;
            public void Adatsor()
            {
                Console.WriteLine($"{név,15}Magyar: {magyar} Tört: {tortenelem} Matek: {matek} Nyelv: {angol} Ig: {igazolt}, NemIg: {igazolatlan}");
                /*Console.Write(név              + "\t");
                Console.Write("Magyar: "       + magyar);
                Console.Write(" Tört: "        + tortenelem);           
                Console.Write(" Matek: "       + matek);           
                Console.Write(" Nyelv: "       + angol);           
                Console.Write(" Ig: "          + igazolt);
                Console.WriteLine(", NemIg: "  + igazolatlan);
                */
            }
            public override string ToString()
            {

                return
                    $"{név,15}Magyar: {magyar} Tört: {tortenelem} Matek: {matek} Nyelv: {angol} Ig: {igazolt}, NemIg: {igazolatlan}";
            }

            public Diák(string nev, int mag, int tort, int mat, int ang, int iga, int nig)
            {
             this.név         = nev; this.magyar = mag; this.tortenelem = tort;
             this.matek       = mat; this.angol  = ang; this.igazolt    = iga;
             this.igazolatlan = nig;
            }
        }

        static void Main(string[] args)
        {
            ArrayList diaklista = new ArrayList();
            diaklista.Add(new Diák("Kázmér", 3, 2, 5, 5, 10, 0));
        var file = File.ReadAllLines("osztaly.txt");
        List<string> osztalyadatok = file.ToList();
        foreach (var item in osztalyadatok)
        {
                var kislista = item.Split(',');
                diaklista.Add(new Diák(kislista[0], int.Parse(kislista[1]), int.Parse(kislista[2]), int.Parse(kislista[3]), int.Parse(kislista[4]), int.Parse(kislista[5]), int.Parse(kislista[6])));
        }
            Console.WriteLine("Az osztaly naplója");
            foreach(var item2 in diaklista)
            {
                Console.Write(szamlalo + ".: " + item2);
            }
            Console.ReadLine();
        }
    }
}
