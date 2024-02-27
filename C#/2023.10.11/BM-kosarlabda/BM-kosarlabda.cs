// BM - 2023.10.11
// kosárlabda

using System.Security.Cryptography;

Console.WriteLine("----------");
Console.WriteLine("kosárlabda");
Console.WriteLine("----------");

Random random = new Random();
Random random1 = new Random();
int pont = 0;
int pont1 = 0;


int cs1 = 0;
int cs2 = 0;

for (int i = 0; i <= 40; i++)
{
    pont = random.Next(0, 5);
    pont1 = random1.Next(1, 3);
    if (pont1 == 1)
    {
        Console.WriteLine($"A Félegyházi Ördögök pontja: {pont}");
        cs1 += pont;
    }
    else if (pont1 == 2)
    {
        Console.WriteLine($"A Kecskeméti Angyalok pontja: {pont}");
        cs2 += pont;
    }
    Console.WriteLine($"{cs2}-{cs1}");
    Console.WriteLine("");
}
if (cs1 > cs2)
{
    Console.WriteLine("A meccs győztese a hazai Félegyházi Ördögök!");
    Console.WriteLine($"{cs1}-{cs2}");
}
else if (cs2 > cs1)
{
    Console.WriteLine("A meccs győztese a vendég Kecskeméti Angyalok!");
    Console.WriteLine($"{cs2}-{cs1}");
}
else
{
    Console.WriteLine("A meccs döntetlenre végződött!");
    Console.WriteLine($"{cs2}-{cs1}");
}
Console.ReadKey();