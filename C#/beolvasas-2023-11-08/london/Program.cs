using System;
using System.IO;
// BM - 2023-11-08
// london
Console.WriteLine("---london---");

StreamReader be = new StreamReader("London2012.txt");

string sor = be.ReadLine();
string[] reszek = sor.Split(";");
int oszlopszamlalo = reszek.Length;
int sorszamlalo = 0;

while (sor != null)
{
    sorszamlalo++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("London2012.txt");

string[,] szamok1 = new string[sorszamlalo, oszlopszamlalo];

for (int i = 0; i < sorszamlalo; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(";");
    for (int j = 0; j < reszek.Length; j++)
    {
        szamok1[i, j] = reszek[j];
    }
}
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < szamok1.GetLength(1); j++)
    {
    }
    Console.Write(szamok1[i, 0]);

}
be.Close();
be = new StreamReader("London2012.txt");
int[,] szamok = new int[sorszamlalo, oszlopszamlalo];

for (int i = 0; i < sorszamlalo; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(";");
    for (int j = 1; j < reszek.Length; j++)
    {
        szamok[i, j] = int.Parse(reszek[j]);
    }
}
for (int i = 0; i < szamok.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 1; j < szamok.GetLength(1); j++)
    {
        ossz += szamok[i, j];
    }
    Console.WriteLine(ossz);
}

Console.ReadKey();