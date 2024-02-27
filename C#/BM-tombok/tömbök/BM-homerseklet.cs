// BM - 2023-10-18
// Hőmérséklet

using System;

Console.WriteLine("-----------");
Console.WriteLine("Hőmérséklet");
Console.WriteLine("-----------");

Random rnd = new Random();
double[] karakterek = new double[24];

double karakterek1 = rnd.Next(-2, 19);
Console.WriteLine(karakterek1);
int ora = 0;    

for (int i = 0; i < 24; i++)
{
    if (i <= 0 || i <= 15)
    {
        int random = rnd.Next(0,4);
        karakterek[i] += karakterek1 + random;
        karakterek1 = karakterek[i];
        ora++;
        Console.WriteLine($"{ora}-óra {karakterek[i]}C volt");
    }
    else
    {
        int random = rnd.Next(-4, -1);
        karakterek[i] += karakterek1 + random;
        karakterek1 = karakterek[i];
        ora++;
        Console.WriteLine($"{ora}-óra {karakterek[i]}C volt");
    }
}
Console.WriteLine($" ");
Console.WriteLine($"A legmagasabb hőmérséklet:\t{karakterek.Max()}C");
Console.WriteLine($"A legalacsonyabb hőmérséklet:\t{karakterek.Min()}C");
Console.WriteLine($"Átlaghőmérséklet:\t\t{(Math.Round(karakterek.Average()))}C");


Console.ReadKey();
