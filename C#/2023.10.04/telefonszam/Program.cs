Console.WriteLine("----------------");
Console.WriteLine("BM - 2023.10.04");
Console.WriteLine("--- telefonszam ---");
Random rand = new Random();

int rand_egesz = rand.Next(1, 1000);
int rand_egesz1 = rand.Next(1, 10000);
int szam = 0;

Console.Write("Válassza ki, hogy [ 20 | 30 | 50 | 70 ]-es körzetszámot szeretne:");
szam = int.Parse(Console.ReadLine());
if (szam == 20)
{
    Console.WriteLine($"+36-{szam}-{rand_egesz1}-{rand_egesz}");
}
else if (szam == 30)
{
    Console.WriteLine($"+36-{szam}-{rand_egesz1}-{rand_egesz}");
}
else if (szam == 50)
{
    Console.WriteLine($"+36-{szam}-{rand_egesz1}-{rand_egesz}");
}
else if (szam == 70)
{
    Console.WriteLine($"+36-{szam}-{rand_egesz1}-{rand_egesz}");
}
else Console.WriteLine("Nincs ilyen körzetszám");

Console.ReadKey();
