Console.WriteLine("----------------");
Console.WriteLine("BM - 2023.10.04");
Console.WriteLine("--- levelgyujtes ---");

int zsakok = 3;
int ossz_zsak = 0;
int utca_szam = 0;
int utca_kesz = 0;

Console.Write("Mennyi az utcák száma? ");
utca_szam = int.Parse(Console.ReadLine());

while (utca_szam != utca_kesz)
{   
    utca_kesz += 1;
    Console.WriteLine($"Eddig {utca_kesz} van kész.");
    Console.Write("van-e az utcában csázsár vagy platánfa? ");
    string valasz = Console.ReadLine();
    if (valasz == "Van" || valasz == "van")
    {
        zsakok += 2;
        ossz_zsak += 5;
        Console.WriteLine($"Az utca feltakarításához szükséges:{zsakok}");
        Console.WriteLine($"Eddig elhaszbált összes zsák:{ossz_zsak}");
    }
    else
    {
        Console.WriteLine($"Az utca feltakarításához szükséges:{zsakok}");
        ossz_zsak += 3;
        Console.WriteLine($"Eddig elhaszbált összes zsák:{ossz_zsak}");
    }           
    zsakok = 3;
}
