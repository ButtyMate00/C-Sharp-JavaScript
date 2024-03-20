using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace BM_elemek
{
    internal class Program
    {
        class Kémia
        {
            public string rendszám;
            public string vegyjel;
            public string név;
            public string atomtömeg;
            public string sűrűség;
            public string olvadáspont;
            public string forráspont;
            public string fajhő;

            public Kémia(string rendszam, string vegyjel, string nev, string atomtomeg, string suruseg, string olvadaspont, string forraspont, string fajho)
            {
                this.rendszám = rendszam; this.vegyjel = vegyjel; this.név = nev;
                this.atomtömeg = atomtomeg; this.sűrűség = suruseg;
                this.olvadáspont = olvadaspont; this.forráspont = forraspont; this.fajhő = fajho;
            }

            public void elemek()
            {
                Console.WriteLine(rendszám);
            }


        }

        static void Main(string[] args)
        {
        var file = File.ReadAllLines("..\\..\\elemek.csv");
        List<string> osztalyadatok = file.ToList();
        foreach (var item in osztalyadatok)
        {
            var elem = item.Split('\t');
            var item1 = new Kémia(elem[0], elem[1], elem[2], elem[3], elem[4], elem[5], elem[6], elem[7]);
        }
        Console.ReadLine();
        }
    }
}
