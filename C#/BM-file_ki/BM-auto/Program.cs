// BM-2023-11-22 autó

Console.WriteLine("<-- autók -->");


StreamReader be = new StreamReader("auto.txt");

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
be = new StreamReader("auto.txt");

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




int db = 0;
string suzuki = szamok1[0, 1];
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 1] == suzuki)
        {
        db++;
        }
    }

}
Console.WriteLine($"2. Feladat. Suzuki: {db}.");
Console.WriteLine();

Console.WriteLine($"3. Feladat. A fekete autók listája:");
string fekete = szamok1[2, 2];
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 2] == fekete)
        {
            Console.Write($"{szamok1[i, 0]}");
            Console.Write($"{szamok1[i, 1]}");
            Console.Write($"{szamok1[i, 2]}");
            Console.Write($"{szamok1[i, 3]}");
            Console.Write($"{szamok1[i, 4]}");
            Console.Write($"{szamok1[i, 5]}");
            Console.WriteLine();
        }
    }

}
Console.WriteLine();
Console.WriteLine($"4. Feladat. 1990-1950 közti autók:");
Console.WriteLine();
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 3] == "1990" || szamok1[i, 3] == "1991" || szamok1[i, 3] == "1992" || szamok1[i, 3] == "1994" || szamok1[i, 3] == "1995")
        {
            Console.Write($"{szamok1[i, 0]}");
            Console.Write($"{szamok1[i, 1]}");
            Console.Write($"{szamok1[i, 2]}");
            Console.Write($"{szamok1[i, 3]}");
            Console.Write($"{szamok1[i, 4]}");
            Console.Write($"{szamok1[i, 5]}");
            Console.WriteLine();
        }
    }

}

db = 0;
string fer = szamok1[40, 1];
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 1] == fer)
        {
            db += int.Parse(szamok1[i, 5]);
        }
    }
}
Console.WriteLine();
Console.WriteLine($"5. {db} kell fizetnie.");


Console.ReadLine();