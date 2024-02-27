Console.WriteLine("----------------");
Console.WriteLine("BM - 2023.10.04");
Console.WriteLine("--- bevasarlas ---");

int termekek = 0;
int ossz_ar = 4560;
int db1 = 0;
int db = 0;

Console.WriteLine("Bevásárolandó termékek:");
Console.WriteLine("- 12 kifli (60 Ft/db)");
Console.WriteLine("- 30 dkg trappista sajt (1800 Ft/kg)");
Console.WriteLine("- 2 melegszendvicskrém (750 Ft)");
Console.WriteLine("- 8 db-os WC-papír (940 Ft)");
Console.WriteLine("- 1 db 2 literes - Coca Cola (830 Ft)");


while (ossz_ar != 5000)
{
    Console.WriteLine("Megszeretnéd vásárolni a termékeket?.");
    string valasz = Console.ReadLine();
    if (valasz == "igen" || valasz == "Igen")
    {
        Console.WriteLine($"A termékek ára:{ossz_ar}");
        Console.WriteLine("Szeretnél csokit vásárolni");
        string valasz1 = Console.ReadLine();
        if (valasz1 == "igen" || valasz1 == "Igen")
        {
            while (ossz_ar != 5000)
            {
                Console.WriteLine("Hány darabot szeretnél vásárolni?");
                db1 = int.Parse(Console.ReadLine());
                db = db1 * 220;
                ossz_ar = db + ossz_ar;
                Console.WriteLine($"Eddigi költséged {ossz_ar}");
                Console.WriteLine("Szeretnél még vásárolni?");
                string valasz2 = Console.ReadLine();
                if (valasz2 != "igen" || valasz2 != "Igen")
                {
                    ossz_ar = 5000;
                    Console.WriteLine($"Eddigi költséged {ossz_ar}");
                }
                    
                else Console.WriteLine(ossz_ar);
            }
        }
    }
    else Console.WriteLine("Teljesítened kell a feldatot");
}
Console.WriteLine("Elérted az 5000 ft-ot");

Console.ReadKey();