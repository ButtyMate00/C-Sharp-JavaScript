// BM - 2023-10-18
// Euro

Console.WriteLine("----");
Console.WriteLine("Euro");
Console.WriteLine("----");

Random rand = new Random();
double rand_valos = rand.NextDouble();
double kezd = rand.Next(384, 391);
double szam = rand.Next(1, 2);
Console.WriteLine($"A randomált valós szám {rand_valos * 100:N2}%");

for (int i = 1; i < 19; i++)
{
    rand_valos = rand.NextDouble();
    szam = rand.Next(1, 3);
    if (szam == 1)
    {
        if (kezd > 391)
        {
            kezd -= rand_valos + 1;
        }
        Console.WriteLine($"10.{i}: {kezd + rand_valos + 1}");
    }
    else if (szam == 2)
    {
        if (kezd < 384)
        {
            kezd += rand_valos +  1;
        }
        Console.WriteLine($"10.{i}: {kezd - rand_valos + 1}");
    }

}

Console.ReadKey();