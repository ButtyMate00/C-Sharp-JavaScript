// BM 2023-09-20
//Átlag kszámítása

Console.WriteLine("Átlag kszámítása");
Console.WriteLine("----------------");

Console.Write("Add meg az 1. szám értékét:");
int szam1 = int.Parse(Console.ReadLine());
Console.Write("Add meg az 2. szám értékét:");
int szam2 = int.Parse(Console.ReadLine());

double atlag = (szam1 + szam2) / 2;
Console.WriteLine("A két szám (" + szam1 + "," + szam2 + ") átlaga: " + atlag);



Console.ReadKey();

