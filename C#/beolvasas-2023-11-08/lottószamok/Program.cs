using System;
using System.IO;
// BM - 2023-11-08
// lottószamok
Console.WriteLine("---lottoszamok---");

StreamReader be = new StreamReader("lottosz.txt");

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
be = new StreamReader("lottosz.txt");
int[,] szamok = new int[sorszamlalo, oszlopszamlalo];

for (int i = 0; i < oszlopszamlalo; i++)
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

    for (int j = 1; j < szamok.GetLength(1); j++)
    {
        Console.Write(szamok[i, j]);
    }
    Console.WriteLine();
}
Console.ReadKey();