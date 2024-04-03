using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                        int db = 0;
                        foreach (object s in BTClista)
                        {
                            elem ertek = s as elem;

                            Console.Write(ertek.BTCDate + "\t");

                            if (ertek.BTCOpen.Length < 8) { int margo = 8 - ertek.BTCOpen.Length; Console.Write(ertek.BTCOpen.PadRight(margo)); Console.Write("\t"); }
                            else Console.Write(ertek.BTCOpen); Console.Write("\t");

                            if (ertek.BTCHigh.Length < 8) { int margo = 8 - ertek.BTCHigh.Length; Console.Write(ertek.BTCHigh.PadRight(margo)); Console.Write("\t"); }
                            else Console.Write(ertek.BTCHigh); Console.Write("\t");

                            if (ertek.BTCLow.Length < 8) { int margo = 8 - ertek.BTCLow.Length; Console.Write(ertek.BTCLow.PadRight(margo)); Console.Write("\t"); }
                            else Console.Write(ertek.BTCLow); Console.Write("\t");

                            Console.WriteLine(ertek.BTCClose);
                            db++;

                            if (db == 100)
                            {
                                Console.ReadLine();
                            }

                        }
                        Console.WriteLine();
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
                    Console.WriteLine("1 - Teljes időszak\n2 - Intervallum megadása");
                    int k_szamlalo1 = int.Parse(Console.ReadLine());
                    if (k_szamlalo1 == 1)
                    {
                        Console.WriteLine("Teljes időszak");
                        int db = 0;
                        foreach (object s in BTClista)
                        {
                            db++;
                            elem ertek = s as elem;
                            if (db == 1)
                            {
                            Console.WriteLine($"{ertek.BTCDate}\t\t{ertek.BTCClose}");
                            }
                            else if (db > 1)
                            {
                                Console.Write(ertek.BTCLow.PadRight(margo))
                                if (ertek.BTCLow.Length < 8) { int margo = 8 - ertek.BTCLow.Length; Console.Write($"{ertek.BTCDate}\t"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("["); Console.ForegroundColor = ConsoleColor.White; Console.Write(ertek.BTCClose); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("]"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\t"); }
                                else Console.Write($"{ertek.BTCDate}\t"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("["); Console.ForegroundColor = ConsoleColor.White; Console.Write(ertek.BTCClose); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("]"); Console.ForegroundColor = ConsoleColor.White;
                                
                            }                           
                        }
                    }
                    else if (k_szamlalo1 == 2)
                    {
                        Console.WriteLine("Intervallum megadása");
                    }
                    else if (szamlalo == 3)
                    {
                        Console.WriteLine("Befektetési számítás");
                    }
                    else Console.WriteLine("Hibás parancs");
                }
                Console.ReadKey();
            }
        }
    }
}
