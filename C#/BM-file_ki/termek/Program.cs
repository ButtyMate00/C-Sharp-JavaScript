// BM-2023-11-22 termékek
using System.IO;

Console.WriteLine("<-- termékek -->");

StreamReader be = new StreamReader("termekek.txt");

string sor = be.ReadLine();
string[] reszek = sor.Split("\t");
int oszlopszamlalo = reszek.Length;
int sorszamlalo = 0;

while (sor != null)
{
    sorszamlalo++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("termekek.txt");

string[,] szamok1 = new string[sorszamlalo, oszlopszamlalo];

for (int i = 0; i < sorszamlalo; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split("\t");
    for (int j = 0; j < reszek.Length; j++)
    {
        szamok1[i, j] = reszek[j];
    }
}
int db = 0;
int db1 = 0;
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        Console.WriteLine($"{szamok1[i, 2]}");
        db++;
        db1 += int.Parse(szamok1[i, 2]);
    }
}
Console.WriteLine($"A termékek átlagos árá: {db1/db}");

db = int.Parse(szamok1[0, 2]);
db1 = int.Parse(szamok1[0, 2]);
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (db < int.Parse(szamok1[i, 2]))
        {
            db = int.Parse(szamok1[i, 2]);
        }
        if(db1 > int.Parse(szamok1[i, 2]))
        {
            db1 = int.Parse(szamok1[i, 2]);
        }
    }
}
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
    if (int.Parse(szamok1[i, 2]) == db)
        {
            Console.Write(szamok1[i, 0]  + " ");
            Console.Write(szamok1[i, 1] + " ");
            Console.WriteLine(db);
        }
    }
    if (int.Parse(szamok1[i, 2]) == db1)
    {
        Console.Write(szamok1[i, 0] + " ");
        Console.Write(szamok1[i, 1] + " ");
        Console.WriteLine(db1);
    }
}

