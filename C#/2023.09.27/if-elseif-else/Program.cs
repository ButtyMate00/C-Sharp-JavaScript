//BM-2023.09.27     
//if-else if-else


Console.WriteLine("Átlag kszámítása");
Console.WriteLine("----------------");


Console.Write("Adj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());

if (szam < 0)
    Console.WriteLine("A szám negatív");
else if (szam == 0)
    Console.WriteLine("A szám nulla");
else
    Console.WriteLine("A szám poztív");

if (szam % 2 == 0)
{
    Console.WriteLine("Szám páros");
}
else Console.WriteLine("A szám páratlan");


Console.ReadKey();