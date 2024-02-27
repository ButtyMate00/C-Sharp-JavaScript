// BM - 2023-11-15
// orvosinobeldijasok

using System.ComponentModel.Design;

Console.WriteLine("<-- orvosinobeldijasok -->");

string[,] nobel = new string[500, 4];

StreamReader be = new StreamReader("orvosi_nobeldijak.txt");
string sor = be.ReadLine();



sor = be.ReadLine();
string[] reszek;
int sorszamlalo = 0;	

while (sor != null)
{
    reszek = sor.Split(";");
	for (int oszlop = 0; oszlop < reszek.Length; oszlop++)
	{
		nobel[sorszamlalo, oszlop] = reszek[oszlop];
	}
	sorszamlalo++;
	sor = be.ReadLine();
}

/*
for (int i = 0; i < sorszamlalo; i++)
{
	for (int j = 0; j < nobel.GetLength(1); j++)
	{
		Console.Write(nobel[i, j] + " ");
    }
    Console.WriteLine();
}
*/

//3.feladat
Console.WriteLine($"3. feladat: Díjazottak száma: {sorszamlalo} fő ");

//4. feladat
int[] evek = new int[sorszamlalo];
for (int i = 0; i < sorszamlalo; i++)
{
	evek[i] = int.Parse(nobel[i, 0]);
}

Console.WriteLine($"4. feladat: Utlsó év: {evek.Max()}");

//5. feladat
Console.WriteLine($"5. feladat: Kérem adja meg az ország kódját:");

Console.Write("Kérem adja meg az ország kódját: ");
string orszagkod = Console.ReadLine();

int talalat = 0;
int egytalalat = 0;
for (int i = 0; i < sorszamlalo; i++)
{
	if (nobel[i, 3] == orszagkod)
	{
		talalat++;
		egytalalat = i;
	}
}

if (talalat == 0)
{
	Console.WriteLine("A megadott országból nem volt díjazott!");
}
else if (talalat == 1)
{
        talalat++;
        Console.WriteLine("\tA megadott ország díjazottja: ");
        Console.WriteLine($"\tNév: {nobel[egytalalat, 1]}");
        Console.WriteLine($"\tÉv: {nobel[egytalalat, 0]}");
        Console.WriteLine($"\tSZ/H: {nobel[egytalalat, 2]}");
}
else
Console.WriteLine($"A megadott országból {talalat} fő díjazott volt!");

be.Close();

//6. feladat
Console.WriteLine($"5. feladat: ");

Dictionary<string, int> stat = new Dictionary<string, int>();
for (int i = 0; i < sorszamlalo; i++)
{
	if (stat.ContainsKey(nobel[i, 3])) stat[nobel[i, 3]]++;
	else stat.Add(nobel[i, 3], 1);
}

foreach (var item in stat)
{
	if (item.Value > 5)
		Console.WriteLine($"\t{item.Key}\t-\t{item.Value} fő");
}



Console.ReadKey();