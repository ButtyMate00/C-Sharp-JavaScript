using System.Diagnostics.CodeAnalysis;
using System.Text;
Console.WriteLine("BM-2024.01.03");
List<string> bevetelek = new List<string>();
string[] lines;
var list = new List<string>();
var fileStream = new FileStream(@"h:\bevetel.csv", FileMode.Open);
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
{
    string line;
    while ((line = streamReader.ReadLine()) != null)
    {
        bevetelek.Add(line);
    }
}
lines = list.ToArray();

//1. Feladat
int sum = 0;
for (int i = 0; i < bevetelek.Count(); i++) sum += int.Parse(bevetelek[i]);
Console.WriteLine($"Éves bevétel:{sum} \nNapi Átlag:{sum / bevetelek.Count}");

// 2. Feladat
int db = 0;
int db1 = 0;
int sum1 = 0;
for (int i = 0; i < bevetelek.Count(); i++)
{
    db++; 
    if (db / 7 == 0 || db / 6 == 0)
    {
        db1++;
        sum1 += int.Parse(bevetelek[i]);
    }

}
Console.WriteLine($"A hétvégi bevételek átlaga:{sum1/db1}");

//3. Feladat
int max = int.Parse(bevetelek.Max());
int db4 = 0;
int db3 = 0;
for (int i = 0; i < bevetelek.Count(); i++)
{
    db4++;
    if (int.Parse(bevetelek[i]) == max)
    {
        Console.WriteLine($"A {db4 / 30}. hónapra esett a legnagyobb bevétel ({max}Ft)");
    }

}
//4. Feladat
StreamWriter havi = new StreamWriter("havi.txt");
int db6 = 0;
int db5 = 0;
sum = 0;
int sum4 = 0;
for (int i = 0; i < bevetelek.Count(); i++)
{
    db6++;
    sum += int.Parse(bevetelek[i]);
    if (db6 / 30 != 0);
    {
        db5++;
        havi.WriteLine(db5 + "," + sum);
        sum = 0;
    }

}
havi.Close();
StreamReader be = new StreamReader("havi.txt");
Console.WriteLine(be.ReadToEnd());
be.Close();
Console.ReadLine();