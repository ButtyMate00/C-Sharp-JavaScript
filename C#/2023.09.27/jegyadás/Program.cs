//BM-2023.09.27     
//jegyadás


Console.Write("Add meg a dolgozat maximális pontszámát: ");
int dogamaxp = int.Parse(Console.ReadLine());
Console.Write("Add meg a dolgozatban elért pontszámot: ");
int dogaelertp = int.Parse(Console.ReadLine());
double szazalek = (double)dogaelertp / dogamaxp * 100;
//Console.WriteLine("Az elért százalék " + Math.Round(szazalek, 2) + "%");
//Console.WriteLine("Az elért százalék " + String.Format("{0:0.00}", szazalek) + "%");
//Console.WriteLine("Az elért százalék {0:f2} %", szazalek);

if (szazalek > 84)
{
    Console.WriteLine("A dolgozat jegye: 5");
}
else
{
    if (szazalek > 74)
    {
        Console.WriteLine("A dolgozat jegye: 4");
    }
    else if (szazalek > 49)
    {
        Console.WriteLine("A dolgozat jegye: 3");
    }
    else if (szazalek > 34)
    {
        Console.WriteLine("A dolgozat jegye: 2");
    }
    else
    {
        Console.WriteLine("A dolgozat jegye: 1");
    }
}
Console.ReadKey();