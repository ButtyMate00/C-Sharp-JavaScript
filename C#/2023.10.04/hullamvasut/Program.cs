Console.WriteLine("----------------");
Console.WriteLine("BM - 2023.10.04");
Console.WriteLine("--- hullamvasut ---");

int db = 0;
int db1 = 0;
do
{
    Console.Write("Hány ember szált fel a hullámvasútra? ");
    db1 = int.Parse(Console.ReadLine());
    if (db1 <= 30)
    {
        db += db1;
        if (db >= 0 && db < 28)
        {
            Console.WriteLine($"{db} ember van a kocsikban.");
        }
        else if (db == 28 || db == 29)
        {
            Console.WriteLine("Elszeretnéd indítani a kocsit? ");
            string valasz = Console.ReadLine();
            if (valasz == "igen" || valasz == "Igen")
            {
                db += 2;
            }
        }
        else if (db == 30)
        {
            Console.WriteLine("A kocsik megteltek");
        }
        else
        {
            Console.WriteLine($"Ennyi férőhely nincsa a kocsiban ");
        }
    }
    else Console.WriteLine($"Ennyi férőhely nincsa a kocsiban ");


} while (db != 30);




Console.ReadKey();