// BM - 2023.10.11
// for focicsapat vizsgálat

Console.WriteLine("-------------------------");
Console.WriteLine("for focicsapat vizsgálat");
Console.WriteLine("-------------------------");

Random random = new Random();  
int ossszpulzus            = 0;
int ossz_vernyomas_szisz   = 0;
int ossz_vernyomas_dia     = 0;
int aktual_pulzus          = 0;
int aktual_vernyomas_szisz = 0;
int aktual_vernyomas_dia   = 0;
int min_pulzus             = 120;
int min_vernyomas_szisz    = 140; 
int min_vernyomas_dia      = 110;
int max_pulzus             = 50;
int max_vernyomas_szisz    = 90;
int max_vernyomas_dia      = 60;

for (int i = 1; i <= 11; i++)
{
    Console.WriteLine($"A(z) {i} játékos");
    aktual_pulzus = random.Next(50, 121);
    ossszpulzus += aktual_pulzus;
    if (aktual_pulzus < min_pulzus) 
        min_pulzus = aktual_pulzus;
    if (aktual_pulzus > max_pulzus)
        max_pulzus = aktual_pulzus;
    Console.WriteLine($"- pulzusa    {aktual_pulzus}/perc");

    aktual_vernyomas_szisz = random.Next(90, 141);
    ossz_vernyomas_szisz += aktual_vernyomas_szisz;

    if (aktual_vernyomas_szisz < min_vernyomas_szisz)
        min_vernyomas_szisz = aktual_vernyomas_szisz;

    if (aktual_vernyomas_szisz > max_vernyomas_szisz)
        max_vernyomas_szisz = aktual_vernyomas_szisz;

    aktual_vernyomas_dia = random.Next(60, 111);
    ossz_vernyomas_dia += aktual_vernyomas_dia;

    if (aktual_vernyomas_dia < min_vernyomas_dia)
        min_vernyomas_dia = aktual_vernyomas_dia;

    if (aktual_vernyomas_dia > max_vernyomas_dia)
        max_vernyomas_dia = aktual_vernyomas_dia;

    Console.WriteLine($"- vérnyomása {aktual_vernyomas_szisz}/{aktual_vernyomas_dia} Hgmm");
    Console.WriteLine("--------------------------");

}

Console.WriteLine("A játékos");
Console.WriteLine($"- átlagpulzusa:             {ossszpulzus/11}/perc");
Console.WriteLine($"- átlagvérnyomás:           {ossz_vernyomas_szisz/11}/{ossz_vernyomas_dia/11} Hgmm");
Console.WriteLine("");
Console.WriteLine($"- legalacsonyabb pulzus:    {min_pulzus}/perc");
Console.WriteLine($"- legalacsonyabb vérnyomás: {min_vernyomas_szisz}/{min_vernyomas_dia} Hgmm");
Console.WriteLine("");
Console.WriteLine($"- legmagasabb pulzus:       {max_pulzus}/perc");
Console.WriteLine($"- legmagasabb vérnyomás:    {max_vernyomas_szisz}/{max_vernyomas_dia} Hgmm");


Console.ReadKey();