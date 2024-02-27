using System.ComponentModel.Design;

Console.WriteLine("----------------");
Console.WriteLine("BM - 2023.10.04");
Console.WriteLine("--- szerencsekerek ---");

Random rand = new Random();

int rand_egesz = rand.Next(1, 501);
int rand_egesz1 = rand.Next(1, 501);
double j1 = rand_egesz * 1000;
double j11 = rand_egesz * 1000;
double j2 = rand_egesz1 * 1000;
double j22 = rand_egesz1 * 1000; 
int spin = 0;
int spin1 = 0;

Console.Write("Hány kört szeretne játszani ?");
spin1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Játékos 1 {j1}            |           Játékos 2 {j2}");
Console.WriteLine("-------------------------------------------------------");

while (spin != spin1)
{
spin += 1;
int szam = rand.Next(1, 9);
int szam1 = rand.Next(1, 9);
    switch (szam)
    {
        case 1:
            j1 = 0;
            Console.Write($"Játékos 1 {j1} (csőd)     |     ");
            break;
        case 2:
            Console.Write($"Játékos 1 {j1} (3x)       |     ");
            j1 = j1 * 3;
            break;
        case 3:
            Console.Write($"Játékos 1 {j1} (passz)    |    ");
            // semmi
            break;
        case 4:
            Console.Write($"Játékos 1 {j1} (2.5x)     |    ");
            j1 = j1 * 2.5;
            break;
        case 5:
            Console.Write($"Játékos 1 {j1} (2/)       |     ");
            j1 = j1 / 2;
            break;
        case 6:
            Console.Write($"Játékos 1 {j1} (2x)       |     ");
            j1 = j1 * 2;
            break;
        case 7:
            Console.Write($"Játékos 1 {j1} (1.5x)     |   ");
            j1 = j1 * 1.5;
            break;
        case 8:
            Console.Write($"Játékos 1 {j1} (+alaptét) | ");
            j1 += j11;
            break;
    }
    switch (szam1)
    {
        case 1:
            j2 = 0;
            Console.WriteLine($"Játékos 2 {j2} (csőd)");
            break;
        case 2:
            Console.WriteLine($"Játékos 2 {j2} (3x)");
            j2 = j2 * 3;
            break;
        case 3:
            Console.WriteLine($"Játékos 2 {j2} (passz)");
            // semmi
            break;
        case 4:
            Console.WriteLine($"Játékos 2 {j2} (2.5x)");
            j2 = j2 * (2.5);
            break;
        case 5:
            Console.WriteLine($"Játékos 2 {j2} (2/)");
            j2 = j2 / 2;
            break;
        case 6:
            Console.WriteLine($"Játékos 2 {j2} (2x)");
            j2 = j2 * 2;
            break;
        case 7:
            Console.WriteLine($"Játékos 2 {j2} (1.5x)");
            j2 = j2 * (1.5);
            break;
        case 8:
            Console.WriteLine($"Játékos 2 {j2} (+alaptét)");
            j2 += j22;
            break;
    }
    if (j1 > j2)
    {
        Console.WriteLine("Játékos 1 nyert!");
        Console.WriteLine("-------------------------------------------------------");

    }
    else if (j1 < j2)
    {
        Console.WriteLine("Játékos 2 nyert!");
        Console.WriteLine("-------------------------------------------------------");

    }
    else 
    {
        Console.WriteLine("Döntetlen!");
        Console.WriteLine("-------------------------------------------------------");
    }
}
if (j1 > j2)
{
    Console.WriteLine("Összesítettben az 1 játékos nyert!");
    Console.WriteLine("-------------------------------------------------------");

}
else if (j1 < j2)
{
    Console.WriteLine("Összesítettben az 1 játékos nyert!");

}
else
{
    Console.WriteLine("Összesítettben döntetlen!");
}