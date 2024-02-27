// BM - 2023.11.15

Console.WriteLine("<-- SuperBowl -->");


string[,] super = new string[56, 8];

StreamReader be = new StreamReader("superbowl.txt");
string sor = be.ReadLine();



sor = be.ReadLine();
string[] reszek;
int sorszamlalo = 0;

while (sor != null)
{
    reszek = sor.Split(";");
    for (int oszlop = 0; oszlop < reszek.Length; oszlop++)
    {
        super[sorszamlalo, oszlop] = reszek[oszlop];
    }
    sorszamlalo++;
    sor = be.ReadLine();
}


/*
for (int i = 0; i < sorszamlalo; i++)
{
    for (int j = 0; j < super.GetLength(1); j++)
    {
        Console.Write(super[i, j] + " ");
    }
    Console.WriteLine();
}
*/

//4. feladat
Console.WriteLine($"4. feladat: Döntők száma: {sorszamlalo}");

//5. feladat

//6. feladat
int[] nezok = new int[sorszamlalo];
for (int i = 0; i < sorszamlalo; i++)
{
    nezok[i] = int.Parse(super[i, 7]);
}
int[] nezoksor = new int[sorszamlalo];
for (int i = 0; i < sorszamlalo; i++)
{
    if (super[i, 7] == "103985")
    {
        Console.WriteLine($"Sorszám (dátum): {super[i, 1]}");
        string str = super[i, 3];
        string res = str.Substring(0, 1);
        Console.WriteLine($"Győztes csapat: {super[i, 2]} szerzet pontok: {res}");
        Console.WriteLine($"Vesztes csapat: {super[i, 4]}");
        Console.WriteLine($"Helyszín: {super[i, 5]}");
        Console.WriteLine($"Város, állam: {super[i, 6]}");
        Console.WriteLine($"Nézőszám: {super[i, 7]}");
    }
    
}



Console.ReadLine();
