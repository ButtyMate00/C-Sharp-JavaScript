//BM-2023.09.27     
//fordulatszam

using System;
using System.ComponentModel.Design;

Console.WriteLine("Fordulatszám");
Console.WriteLine("--------");




Console.Write("A motor be van indítva[igen/nem]: ");
string motor_alapot = Console.ReadLine();
int fordulat_szam = 0;
int fokozat = 0;


if (motor_alapot == "nem" || motor_alapot == "Nem")
{
    Console.WriteLine("Autó motorja nem jár.");
}
else
{
    Console.WriteLine("Motor alapjárata: 900rmp");
    Console.WriteLine("Az autó fokozata " + fokozat);
    fordulat_szam = 900;
    Console.WriteLine("Az autó fordulatszáma " + fordulat_szam);

}
while (fordulat_szam > 0)
{
    Console.Write("Mennyi a jelenlegi fordulatszám? (0-8): ");
    double fordulat_szam1 = double.Parse(Console.ReadLine());
    fordulat_szam = (int)(fordulat_szam1 * 1000);

    if (fordulat_szam > 7000 && fordulat_szam <= 8000)
    {
        Console.WriteLine("Veszélyes fordulatszám");
        Console.WriteLine("Az autó fokozata " + fokozat);
        Console.WriteLine("Az autó fordulatszáma " + fordulat_szam);
    }
    else if (fordulat_szam > 8000)
    {
        Console.WriteLine("Nem értelmezhető érték");
    }
    else if (fordulat_szam <= 7000 && fordulat_szam >= 4000)
    {
        fokozat += 1;
        if (fokozat == 7)
        {
            Console.WriteLine("Az autót nem lehet magasabb fokozatra kapcsolni mint 6");
            Console.WriteLine("Az autó fokozata " + fokozat);
            Console.WriteLine("Az autó fordulatszáma " + fordulat_szam);
            fokozat = 6;
        }
        else
        {
            Console.WriteLine("Az autó fokozata " + fokozat);
            Console.WriteLine("Az autó fordulatszáma " + fordulat_szam);
        }
    }
    else if (fordulat_szam >= 1500 && fordulat_szam <= 3999)
    {
        Console.WriteLine("Az autó fokozata nem változot");
        Console.WriteLine("Az autó fokozata " + fokozat);
        Console.WriteLine("Az autó fordulatszáma " + fordulat_szam);
    }
    else if (fordulat_szam >= 1 && fordulat_szam <= 1499)
    {
        fokozat -= 1;
        if (fokozat < 0)
        {
            Console.WriteLine("Az autót nem lehet kisebb fokozatra kapcsolni mint 0");
            fokozat = 0;
            Console.WriteLine("Az autó fokozata " + fokozat);
        }
        else if (fokozat > 0)
        {
            Console.WriteLine("Az autó fokozata " + fokozat);
            Console.WriteLine("Az autó fordulatszáma " + fordulat_szam);
        }

        else if (fokozat == 0)
        {
            Console.WriteLine("Az autó motor pörgetése [Igen/Nem]");
            string valasz = Console.ReadLine();
            while (valasz == "igen")
            {
                if (valasz == "igen" || valasz == "Igen")
                {
                    Console.Write("Mennyi a jelenlegi fordulatszám? (0-8): ");
                    double fordulat_szam2 = double.Parse(Console.ReadLine());
                    fordulat_szam2 = (int)(fordulat_szam2 * 1000);
                    Console.WriteLine("Az autó fordulatszáma " + fordulat_szam2);
                    Console.Write("Szeretnéd folytatni? [Igen/Nem]");
                    string valasz1 = Console.ReadLine();
                    valasz = valasz1;
                }
                else
                {
                    valasz = "nem";
                }

            }

        }
        else if (fordulat_szam == 0)
        {
            motor_alapot = "Nem";
            Console.WriteLine("Autó motorja nem jár.");
        }
    }


}
Console.ReadKey();