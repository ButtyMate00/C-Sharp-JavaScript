using System.Text;

Console.WriteLine("BM-2024-01-03");

List<string> budapest = new List<string>();
List<string> veszpremi = new List<string>();
List<string> kozos = new List<string>();
List<string> unio = new List<string>();

// 1. Feladat

string[] lines;
var list = new List<string>();
var fileStream = new FileStream(@"h:\budapesti_emlosok.csv", FileMode.Open);
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
{
    string line;
    while ((line = streamReader.ReadLine()) != null)
    {
        budapest.Add(line);
    }
}
lines = list.ToArray();



string[] lines1;
var list1 = new List<string>();
var fileStream1 = new FileStream(@"h:\veszpremi_emlosok.csv", FileMode.Open);
using (var streamReader = new StreamReader(fileStream1, Encoding.UTF8))
{
    string line1;
    while ((line1 = streamReader.ReadLine()) != null)
    {
        veszpremi.Add(line1);
    }
}
lines1 = list1.ToArray();

// 2. Feladat

int db = 0;
int db1 = 0;
Console.WriteLine("A Veszprémi állatker emlős állatai:");
for (int i = 0; i < veszpremi.Count(); i++)
{
    Console.WriteLine(veszpremi[i]);
    db++;
}
Console.WriteLine();
Console.WriteLine("A Budapesti állatker emlős állatai:");
for (int i = 0; i < budapest.Count(); i++)
{
    Console.WriteLine(budapest[i]);
    db1++;
}


//3. Feladat
Console.WriteLine();
Console.WriteLine($"Veszprémi állatker állatainak száma:{db}");
Console.WriteLine($"Budapesti állatker állatainak száma:{db1}");

for (int i = 0; i < veszpremi.Count(); i++)
{
    for (int j = 0; j < budapest.Count(); j++)
    {
        if (veszpremi[i] == budapest[j])
        {
            kozos.Add(veszpremi[i]);
        }
    }
}

//4. Feladat

var unio1 = veszpremi.Union(budapest); 

//5. Feladat
Console.WriteLine();
Console.WriteLine($"Az unió állatainak száma:{db1+db-kozos.Count()}");

// 6. Feladat
Console.WriteLine();
Console.WriteLine("Mindkét állatkertben van:");
for (int i = 0; i < kozos.Count(); i++)
{
    Console.WriteLine(kozos[i]);
}