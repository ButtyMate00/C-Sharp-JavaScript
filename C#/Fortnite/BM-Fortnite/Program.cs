using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Frontnite
{
    internal class Program
    {
        static (string HP, string Szint, string Nev) eredmeny;
        static List<(string Fegyver, int Loszer, int Sebzes)> fegyverek = new List<(string, int, int)>();
        static void Main(string[] args)
        {
            string valaszt = " ";
            var bekerve = false;
            var harc_belep = false;
            while (valaszt != "2")
            {
                Console.Write("Belépés[1] \nKilépéa[2]\n\nAdd meg a valasztasod:");
                valaszt = Console.ReadLine();
                if (int.Parse(valaszt) == 1)
                {
                    string mellek_szam = " ";
                    while (mellek_szam != "0")
                    {
                        Console.Write("Játékosinformációk[1] \nFegyverek és Lőszerek[2] \nCsata Szimuláció[3] \nKincsek és Pontszámok[4] \nKilépés[0] \n\nAdd meg a valasztasod:");
                        mellek_szam = Console.ReadLine();
                        if (mellek_szam == "1")
                        {
                            if (!bekerve)
                            {
                                eredmeny = Jatekos_be();
                                bekerve = true;
                            }
                            Console.WriteLine();
                            harc_true = true;
                            Console.Write("Meszeretnéd nézni a Jatákos információit [igen/nem]:");
                            string valaszt1 = Console.ReadLine();
                            if (valaszt1 == "igen") { Jatekos_ki(eredmeny); }
                            Console.WriteLine();
                        }
                        else if (mellek_szam == "2")
                        {
                            Console.Write("Szeretnél fegyvert hozzáadni [igen/nem]:");
                            string valaszt2 = Console.ReadLine();
                            if (valaszt2 == "igen")
                            {
                                Console.Write("Fegyver neve:");
                                string fegyver_neve = Console.ReadLine();
                                Console.Write("Lőszer mennyiség:");
                                int fegyver_ammo = int.Parse(Console.ReadLine());
                                Console.Write("Sebzés (pl.:10):");
                                int fegyver_sebzes = int.Parse(Console.ReadLine());
                                Fegyver_be(fegyver_neve, fegyver_ammo, fegyver_sebzes);
                                Console.WriteLine();
                            }
                            Fegyver_ki();
                            Console.WriteLine();


                        }
                        else if (mellek_szam == "3" && harc_belep == true)
                        {
                            Harc();
                        }
                        else if (mellek_szam == "4")
                        {
                            Rang();
                            Console.WriteLine();
                        }
                        else Console.WriteLine("Hiba");

                    }

                }
                else
                {
                    StreamWriter rang = new StreamWriter("ranglista.txt", append: true);
                    rang.Write(eredmeny.Nev + " ");
                    rang.Write(eredmeny.HP + " ");
                    rang.Write(eredmeny.Szint + " ")
                    rang.Write(fegyverek[1] + " ")
                    rang.Close();
                    System.Environment.Exit(0);
                }
            }
            Console.ReadLine();
        }
        static (string, string, string) Jatekos_be()
        {
            var hp = "100";
            var szint = "1";

            Console.Write("Add meg a neved:");
            var nev = Console.ReadLine();

            return (hp, szint, nev);
        }
        static void Jatekos_ki((string HP, string Szint, string Nev) jatekos)
        {
            Console.WriteLine("HP: " + jatekos.HP);
            Console.WriteLine("Szint: " + jatekos.Szint);
            Console.WriteLine("Név: " + jatekos.Nev);
        }
        static void Fegyver_be(string fegyver_neve, int fegyver_ammo, int fegyver_sebzes)
        {
            fegyverek.Add((fegyver_neve, fegyver_ammo, fegyver_sebzes));
            Console.WriteLine($"{fegyver_neve} hozzáadva a fegyverekhez.");
            Console.WriteLine();
        }
        static void Fegyver_ki()
        {
            Console.WriteLine("Játékos fegyverei:");
            foreach (var s in fegyverek)
            {
                Console.WriteLine($"Fegyver: {s.Fegyver}, Lőszer: {s.Loszer}, Sebzés: {s.Sebzes}");
            }
        }
        static void Harc()
        {
            Random random = new Random();

            var ellenfel_hp = random.Next(70, 101);

            int jatekosHP = int.Parse(eredmeny.HP);
            int seb = 10;
            foreach (var s in fegyverek)
            {
                seb = s.Sebzes;
            }

            Console.WriteLine("Csata kezdődik!");

            while (jatekosHP > 0 && ellenfel_hp > 0)
            {
                Console.WriteLine($"Játékos életerő: {jatekosHP}");
                Console.WriteLine($"Ellenfél életerő: {ellenfel_hp}");

                int damage = random.Next(seb - 5, seb + 5);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{eredmeny.Nev} támad! Ellenfél -{damage} életerő");
                ellenfel_hp -= damage;

                var damage1 = random.Next(5, 21);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ellenfél támad! Játékos -{damage1} életerő");
                Console.ForegroundColor = ConsoleColor.White;
                jatekosHP -= damage1;
                eredmeny.HP = jatekosHP.ToString();
                var szint = eredmeny.Szint;
                var szint1 = int.Parse(szint);
                szint1++;
                eredmeny.Szint = szint1.ToString();
                Console.WriteLine();
            }

            if (jatekosHP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vesztettél a csatában.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Kilépés [Enter]");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Megnyerted a csatát!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
        static void Rang()
        {
            Console.WriteLine("Játékos fegyverei:");
            foreach (var s in fegyverek)
            {
                Console.WriteLine($"Fegyver: {s.Fegyver}, Lőszer: {s.Loszer}");
            }
        }
    }
}