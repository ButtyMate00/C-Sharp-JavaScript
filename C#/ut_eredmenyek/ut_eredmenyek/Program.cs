using System;
using System.Runtime.Intrinsics.X86;
string[] jatekos = new string[] { "examine", "wainscot", "divide", "over", "hyena", "septum", "evolution", "dominant", "sole", "issue" };
Random rnd = new Random();
string valaszt = "";
var szamlalo = 0;
var szam1 = 50;
var szam2 = 100;
var szam10 =   0;
int db = 0;
int[] FFA_kill = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,};
int[] FFA_dead = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
while (valaszt != "5")
{
    Console.WriteLine("Free for All (FFA)(1)");
    Console.WriteLine("Team Deathmatch (TDM)(2)");
    Console.WriteLine("Capture the Flag (CTF)(3)");
    Console.WriteLine("Bomb & Defuse (BM)(4)");
    Console.WriteLine("Kilépés(5)");
    Console.Write("Add meg a választásod: ");
    valaszt = Console.ReadLine();
    if (int.Parse(valaszt) == 1)
    {
        string valaszt1 = "";
        while (valaszt1 != "0")
        {
            Console.WriteLine("Free for All (FFA)");
            for (int i = 1; i < 10000000; i++)
            {
                db++;
                int beosztas = rnd.Next(0, 10);
                FFA_kill[beosztas] += 1;
                int beosztas_ = rnd.Next(0, 10);
                FFA_dead[beosztas_] += 1;
                if (FFA_kill[beosztas] == szam1)
                {
                    File.Delete("FFA_50_kill.txt");
                    for (int j = 0; j < FFA_kill.Length; j++)
                    {
                        szamlalo++;
                        StreamWriter FFA = new StreamWriter("FFA_50_kill.txt", append: true);
                        FFA.WriteLine(jatekos[j] + " " + FFA_kill[j] + " " + FFA_dead[j]);
                        FFA.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("FFA_50_kill");
                    Console.WriteLine("NÉV KILL DEAD");
                    StreamReader be2 = new StreamReader("FFA_50_kill.txt");
                    Console.WriteLine(be2.ReadToEnd());
                    be2.Close();
                    szam1 = 10000;
                }
                if (FFA_kill[beosztas] == szam2)
                {
                    File.Delete("FFA_100_kill.txt");
                    for (int j = 0; j < FFA_kill.Length; j++)
                    {
                        szamlalo++;
                        StreamWriter FFA = new StreamWriter("FFA_100_kill.txt", append: true);
                        FFA.WriteLine(jatekos[j] + " " + FFA_kill[j] + " " + FFA_dead[j]);
                        FFA.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("FFA_100_kill");
                    Console.WriteLine("NÉV KILL DEAD");
                    StreamReader be2 = new StreamReader("FFA_100_kill.txt");
                    Console.WriteLine(be2.ReadToEnd());
                    be2.Close();
                    szam2 = 1000;
                }
                if (FFA_kill[beosztas] == 150)
                {
                    File.Delete("FFA_150_kill.txt");
                    for (int j = 0; j < FFA_kill.Length; j++)
                    {
                        szamlalo++;
                        StreamWriter FFA = new StreamWriter("FFA_150_kill.txt", append: true);
                        FFA.WriteLine(jatekos[j] + " " + FFA_kill[j] + " " + FFA_dead[j]);
                        FFA.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("FFA_150_kill");
                    Console.WriteLine("NÉV KILL DEAD");
                    StreamReader be2 = new StreamReader("FFA_150_kill.txt");
                    Console.WriteLine(be2.ReadToEnd());
                    be2.Close();
                    i = 10000000;
                }
            }
            valaszt1 = "0";
        }
        break;
    }
    if (int.Parse(valaszt) == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Team Deathmatch (TDM)");

    }
    if (int.Parse(valaszt) == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Capture the Flag (CTF)");

    }
    if (int.Parse(valaszt) == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Bomb & Defuse (BM)");

    }
}

Console.ReadLine();
