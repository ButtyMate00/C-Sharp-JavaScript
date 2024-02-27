using System.IO;
// BM - 2023-11-08
// enaplo

Console.WriteLine("---enaplo---");

StreamReader be = new StreamReader("enaplo.txt");

string sor = be.ReadLine();
string[] reszek = sor.Split(" ");
int sorszamlalo = 0;
while (sor != null)
{
    sorszamlalo++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("enaplo.txt");
string[] nevek = new string[sorszamlalo];

for (int i = 0; i < sorszamlalo; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(" ");
    nevek[i] = reszek[0] + " " + reszek[1];
}
foreach (string nev in nevek)
{
    Console.WriteLine($"{nev}\t--> {nev.Length-1}");
}
Console.ReadKey();