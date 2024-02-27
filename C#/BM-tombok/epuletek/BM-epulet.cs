// BM - 2023-10-18
// Épületek tömbbel

Console.WriteLine("----------------");
Console.WriteLine("Épületek tömbbel");
Console.WriteLine("----------------");

Console.Write("Hány épület magaságát szeretné megadni? ");
int epulet_db = int.Parse(Console.ReadLine());

Random rnd = new Random();
int[] epuletek = new int[epulet_db];

for (int i = 0; i < epulet_db; i++)
{
    epuletek[i] = rnd.Next(1, 828+1);
}
foreach (int i in epuletek)
    Console.WriteLine(i + " m");

Console.WriteLine($"A legmagasabb épület:\t\t{epuletek.Max()} m");
Console.WriteLine($"A legalacsonyabb épület:\t{epuletek.Min()} m");
Console.WriteLine($"Az épületek átlagmagassága:\t{(Math.Round(epuletek.Average()))} m");

Console.ReadKey();