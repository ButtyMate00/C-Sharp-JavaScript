Console.WriteLine("----------------");
Console.WriteLine("BM - 2023.10.04");
Console.WriteLine("--- do_while ---");

Console.Write("Hány szórólapot kell kiosztani? ");
int szorolap_db = int.Parse(Console.ReadLine());
int aktual_db = 0;
do
{
    Console.Write("Hány szorólapot tusz most odaadni:");
    aktual_db = int.Parse(Console.ReadLine());
    if (aktual_db > szorolap_db)
    {
        Console.WriteLine("Nincs elég szórólap!");
    }
    else
        szorolap_db -= aktual_db;
    Console.WriteLine($"{szorolap_db} maradt");

} while (szorolap_db != 0);


Console.ReadKey();