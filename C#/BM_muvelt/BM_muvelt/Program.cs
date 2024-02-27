//BM-2024-01-17


string[] muvelt_sorok = File.ReadAllLines(@"H:muvelt.txt");
HashSet<string> muvelt = new HashSet<string>(muvelt_sorok);
muvelt.Remove("11");
Console.WriteLine("Muveltek:");
foreach (string sor in muvelt)
{
    Console.WriteLine(sor);
}
Console.WriteLine();
Console.WriteLine("Szepek:");
string[] szep_sorok = File.ReadAllLines(@"H:szep.txt");
HashSet<string> szep = new HashSet<string>(szep_sorok);
szep.Remove("13");
foreach (string sor in szep)
{
    Console.WriteLine(sor);
}
Console.WriteLine();
muvelt.IntersectWith(szep);
Console.WriteLine();
Console.WriteLine("Batrak:");
foreach (string sor in muvelt)
{
    Console.WriteLine(sor);
    StreamWriter egy = new StreamWriter("batrak.txt", append: true);
    egy.WriteLine(sor);
    egy.Close();
}
string[] muvelt_sorok1 = File.ReadAllLines(@"H:muvelt.txt");
HashSet<string> muvelt1 = new HashSet<string>(muvelt_sorok1);
muvelt1.Remove("11");
muvelt1.UnionWith(szep);
Console.WriteLine();
Console.WriteLine("Versenyzok:");
foreach (string sor in muvelt1)
{
    Console.WriteLine(sor);
    StreamWriter egy = new StreamWriter("versenyzok.txt", append: true);
    egy.WriteLine(sor);
    egy.Close();
}
Console.ReadLine();