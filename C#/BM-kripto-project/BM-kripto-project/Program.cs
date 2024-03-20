using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace KD_Bizonyitvany
{
    internal class Program
    {
        class elem
        {
            public elem(string BTClista)
            {
                var BTC_lista = BTClista.Split(',');
                BTCUnix = BTC_lista[0];
                BTCDate = BTC_lista[1];
                BTCSymbol = BTC_lista[2];
                BTCOpen = BTC_lista[3];
                BTCHigh = BTC_lista[4];
                BTCLow = BTC_lista[5];
                BTCClose = BTC_lista[6];
            }
            //BTC
            public string BTCUnix; public string BTCDate; public string BTCSymbol; public string BTCOpen; public string BTCHigh; public string BTCLow; public string BTCClose;                        
        }
        class elem1
        {
            public elem1(string ETHlista)
            {
                var ETH_lista = ETHlista.Split(',');
                ETHUnix = ETH_lista[0];
                ETHDate = ETH_lista[1];
                ETHSymbol = ETH_lista[2];
                ETHOpen = ETH_lista[3];
                ETHHigh = ETH_lista[4];
                ETHLow = ETH_lista[5];
                ETHClose = ETH_lista[6];
            }
            //ETH
            public string ETHUnix; public string ETHDate; public string ETHSymbol; public string ETHOpen; public string ETHHigh; public string ETHLow; public string ETHClose;
        }
        class elem2
        {
            public elem2(string SOLlista)
            {
                var SOL_lista = SOLlista.Split(',');
                SOLUnix = SOL_lista[0];
                SOLDate = SOL_lista[1];
                SOLSymbol = SOL_lista[2];
                SOLOpen = SOL_lista[3];
                SOLHigh = SOL_lista[4];
                SOLLow = SOL_lista[5];
                SOLClose = SOL_lista[6];
            }
            //BTC
            public string SOLUnix; public string SOLDate; public string SOLSymbol; public string SOLOpen; public string SOLHigh; public string SOLLow; public string SOLClose;
        }

        static void Main(string[] args)
        {
            //BTC
            ArrayList BTClista = new ArrayList();
            var BTC = File.ReadAllLines("Binance_BTCEUR_d.csv");
            List<string> BTClist = BTC.ToList();
            BTClist.RemoveAt(0); BTClist.RemoveAt(1);
            foreach (string s in BTClist) BTClista.Add(new elem(s));
            //ETH
            ArrayList ETHlista = new ArrayList();
            var ETH = File.ReadAllLines("Binance_ETHEUR_d.csv");
            List<string> ETHlist = BTC.ToList();
            ETHlist.RemoveAt(0); ETHlist.RemoveAt(1);
            foreach (string s in ETHlist)
            {
                ETHlista.Add(new elem1(s));
            }
            //SOL
            ArrayList SOLlista = new ArrayList();
            var SOL = File.ReadAllLines("Binance_SOLEUR_d.csv");
            List<string> SOLlist = BTC.ToList();
            SOLlist.RemoveAt(0); SOLlist.RemoveAt(1);
            foreach (string s in SOLlist)
            {
                SOLlista.Add(new elem2(s));
            }
            var szamlalo = 10;
            while (szamlalo != 0)
            {
                Console.WriteLine(" 1 - Kriptovaluta kiválasztása\n 2 - Statisztika\n 3 - Befektetési számítás\n 0 - Kilépés a programból\n");
                Console.Write("választásod:");
                szamlalo = int.Parse(Console.ReadLine());
                if (szamlalo == 1)
                {
                    Console.WriteLine("Kriptovaluta kiválasztása");
                    Console.WriteLine(" 1 - BTC\n 2 - ETH\n 3 - SOL\n 0 - Vissza\n");
                    int k_szamlalo = int.Parse(Console.ReadLine());
                    if (k_szamlalo == 1)
                    {
                        var db = 0;
                        var BTCHigh = "";
                        var BTCLow = "";
                        double atlag = 0;
                        foreach (object s in BTClista)
                        {
                            db++;
                            elem ertek = s as elem;
                            if (db >= 2)
                            {
                                BTCLow = ertek.BTCLow;
                                BTCHigh = ertek.BTCHigh;
                                atlag = double.Parse(BTCLow + BTCHigh);
                            }
                            Console.WriteLine($"{ertek.BTCDate}\t{ertek.BTCOpen}\t{ertek.BTCHigh}\t{ertek.BTCLow}\t{ertek.BTCClose}\t{atlag*2}");
                        }
                    }
                    else if (k_szamlalo == 2)
                    {

                    }
                    else if (szamlalo == 3)
                    {

                    }
                    else Console.WriteLine("Hiba");
                }
                else if (szamlalo == 2)
                {
                    Console.WriteLine("Statisztika");
                }
                else if ( szamlalo == 3)
                {
                    Console.WriteLine("Befektetési számítás");
                }
                else Console.WriteLine("Hibás parancs");
            }
            Console.ReadKey();
        }
    }
}
