Console.WriteLine("----------");
Console.WriteLine("BM-halmaz");
Console.WriteLine("----------");

//HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43 };
//Console.WriteLine("Hozzáadás előtt: " + halmaz.Count);
//halmaz.Add(17);
//halmaz.Add(60);
//Console.WriteLine("Hozzáadás után: " + halmaz.Count);


//HashSet<string> nevek = new HashSet<string>() { "Buddy", "Coolent", "Paparize" };
//Console.Write("Add meg a nevedet: ");
//string uj_nev = Console.ReadLine();
//while (nevek.Contains(uj_nev))
//{
//    Console.WriteLine($"A {uj_nev} már létezik");
//    Console.Write("Add meg a nevedet: ");
//    uj_nev = Console.ReadLine();
//}
//nevek.Add(uj_nev);



//Random r = new Random();
//HashSet<int> lottószámok = new HashSet<int>();
//while (lottószámok.Count < 5)
//{
//    lottószámok.Add(r.Next(0, 91));
//}
//Console.WriteLine("A sorsolt lottószámok: ");
//foreach (int item in lottószámok)
//{
//    Console.Write(item + ", ");
//}


HashSet<int> halmaz1 = new HashSet<int>() { 10, 32, 4, 8 };
HashSet<int> halmaz2 = new HashSet<int>() { 20, 32, 12, 4 };



Console.WriteLine("halmaz1: ");
foreach (int h1 in halmaz1) Console.Write(h1 + "\t");
Console.WriteLine();
Console.WriteLine("halmaz2: ");
foreach (int h2 in halmaz2) Console.Write(h2 + "\t");

Console.WriteLine("Unió");
halmaz1.UnionWith(halmaz2);
foreach (int szam in halmaz1)
{
    Console.Write(szam + "\t");
}

HashSet<int> alaphalmaz = new HashSet<int>() { 10, 32, 4, 8 };
HashSet<int> halmaz3 = new HashSet<int>() { 20, 32, 12, 4 };
alaphalmaz.SymmetricExceptWith(halmaz3);
Console.WriteLine("Metszet komplementer");
foreach (int szam in alaphalmaz) Console.Write(szam + "\t");

HashSet<int> alaphalmaz1 = new HashSet<int>() { 10, 32, 4, 8 };
HashSet<int> halmaz4 = new HashSet<int>() { 20, 32, 12, 4 };
Console.WriteLine("Megmaradt érték");
alaphalmaz.ExceptWith(halmaz4);
foreach (int szam in alaphalmaz1) Console.Write(szam + "\t");

HashSet<int> alaphalmaz2 = new HashSet<int>() { 10, 32, 4, 8 };
HashSet<int> halmaz5 = new HashSet<int>() { 20, 32, 12, 4 };
alaphalmaz.IntersectWith(halmaz5);
Console.WriteLine("Metszet");
foreach (int szam in alaphalmaz2) Console.Write(szam + "\t");