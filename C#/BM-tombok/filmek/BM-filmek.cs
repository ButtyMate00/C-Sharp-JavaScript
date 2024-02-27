// BM - 2023-10-18
// Filmek

using System;

Console.WriteLine("------");
Console.WriteLine("Filmek");
Console.WriteLine("------");
Random rnd = new Random();
string[] filmek = new string[] { "Toy", "Jumanji", "Grumpier", "Waiting", "Father", "Heat", "Sabrina", "Tom" };
string[] honap = new string[] { "Január", "Február", "Március", "Április", "Május", "Junius", "Julius", "Augusztus", "Szeptember", "Október", "November", "December" };

filmek = filmek.OrderBy(x => rnd.Next()).ToArray();
honap = honap.OrderBy(x => rnd.Next()).ToArray();
int szam = rnd.Next(1, 33);
int szam1 = rnd.Next(1, 30);
int szam2 = rnd.Next(1, 32);
int a = 0;
string i = " ";
for (int e = 0; e < 8; e++)
{ 
    i = honap[e];
    if (i == "Január" || i == "Március" || i == "Május" || i == "Julius" || i == "Agusztus" || i == "Október" || i == "December")
    {
    szam = rnd.Next(0, 32);
    Console.WriteLine($"{i} {szam} {filmek[e]}");
    }
    else if (i == "Február")
    {
    szam1 = rnd.Next(0, 29);
    Console.WriteLine($"{i} {szam1} {filmek[e]}");
    }
    else
    {
    szam2 = rnd.Next(0, 31);
    Console.WriteLine($"{i} {szam2} {filmek[e]}");
    }
}


Console.ReadKey();

