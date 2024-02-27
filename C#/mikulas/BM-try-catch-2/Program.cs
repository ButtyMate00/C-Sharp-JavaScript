// BM-2023.12.06

using System.Threading.Channels;
int i = 0;
while (i != 1)
{
    try
    {
        int szam = 0; 
        int szam1 = 0; 
        Console.Write("Add meg az első számot: ");
        szam = int.Parse(Console.ReadLine());
        Console.Write("Add meg a második számot: ");
        szam1 = int.Parse(Console.ReadLine());
        int szam3 = szam / szam1;
        if (szam3 == 0)
        {
            Console.WriteLine("Nem szabályos osztás.");
        }
        else 
        {
            Console.WriteLine($"A számok hányadosa: {szam}");
            i++;
        }

    }
    catch (DivideByZeroException dbze)
    {
        Console.WriteLine($"Hibatüzenet: {dbze.Message}");
        Console.WriteLine("Nullával nem lehet osztani.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Nem számot adtál meg!");
    }
}


Console.ReadLine();