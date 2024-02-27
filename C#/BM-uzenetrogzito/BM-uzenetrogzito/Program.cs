// BM-uzenetrogzito



using System.IO;

Random rnd = new Random();
string valaszt = " ";
int db = 1;
while (valaszt != "3")
{
    DateTime aktual_ido = DateTime.Now;
    String[,] egyes = new String[1, 10];
    Console.WriteLine("Telefonáló(1)");
    Console.WriteLine("Üzenetrögzítő(2)");
    Console.WriteLine("Kilépés(3)");
    Console.Write("Add meg a választásod: ");
    valaszt = Console.ReadLine();
    if (int.Parse(valaszt) == 1)
    {
        string mellek_szam = " ";
        while (mellek_szam != "0")
        {
            Console.WriteLine("Mellékek (11-titkárság, 14–tanári, 15–kollégium, 16–könyvtár, 0-kilépés)");
            mellek_szam = Console.ReadLine();
            if (mellek_szam == "11")
            {
                int tel = rnd.Next(10000000, 99999999);
                Console.Write("Név:");
                string nev = Console.ReadLine();
                Console.Write("Üzenet:");
                string uzenet = Console.ReadLine();
                StreamWriter egy = new StreamWriter("egy.txt", append: true);
                egy.WriteLine(db + " " + nev + ";" + uzenet + "; " + "+36" + tel + "; " + aktual_ido);
                db++;
                egy.Close();

            }
            else if (mellek_szam == "14")
            {
                int tel = rnd.Next(10000000, 99999999);
                Console.Write("Név:");
                string nev = Console.ReadLine();
                Console.Write("Üzenet:");
                string uzenet = Console.ReadLine();
                StreamWriter egy = new StreamWriter("ketto.txt", append: true);
                egy.WriteLine(db + " " + nev + ";" + uzenet + "; " + "+36" + tel + "; " + aktual_ido);
                db++;
                egy.Close();
            }
            else if (mellek_szam == "15")
            {
                int tel = rnd.Next(10000000, 99999999);
                Console.Write("Név:");
                string nev = Console.ReadLine();
                Console.Write("Üzenet:");
                string uzenet = Console.ReadLine();
                StreamWriter egy = new StreamWriter("harom.txt", append: true);
                egy.WriteLine(db + " " + nev + ";" + uzenet + "; " + "+36" + tel + "; " + aktual_ido);
                db++;
                egy.Close();
            }
            else if (mellek_szam == "16")
            {
                int tel = rnd.Next(10000000, 99999999);
                Console.Write("Név:");
                string nev = Console.ReadLine();
                Console.Write("Üzenet:");
                string uzenet = Console.ReadLine();
                StreamWriter egy = new StreamWriter("negy.txt", append: true);
                egy.WriteLine(db + " " + nev + ";" + uzenet + "; " + "+36" + tel + "; " + aktual_ido);
                db++;
                egy.Close();
            }
            else if (mellek_szam == "0")
            {
                break;
            }
            else Console.WriteLine("Hiba");

        }

    }
    else if (int.Parse(valaszt) == 2)
    {
        string mellek_szam1 = " ";
        while (mellek_szam1 != "0")
        {
            Console.WriteLine("Mellékek (11-titkárság, 14–tanári, 15–kollégium, 16–könyvtár, 1-összes, 0-kiléps)");
            mellek_szam1 = Console.ReadLine();
            if (mellek_szam1 == "11")
            {
                StreamReader be = new StreamReader("egy.txt");
                Console.WriteLine(be.ReadToEnd());
                be.Close();
                File.Delete("egy.txt");
                StreamWriter egy = new StreamWriter("egy.txt", append: true);
                egy.Write("");
                egy.Close();
                //StreamWriter egy = new StreamWriter("egy.txt", append: true);
                //egy.WriteLine("");
                //db++;
                //egy.Close();
            }
            else if (mellek_szam1 == "14")
            {
                StreamReader be = new StreamReader("ketto.txt");
                Console.WriteLine(be.ReadToEnd());
                be.Close();
                File.Delete("ketto.txt");
                StreamWriter egy = new StreamWriter("ketto.txt", append: true);
                egy.Write("");
                egy.Close();
            }
            else if (mellek_szam1 == "15")
            {
                StreamReader be = new StreamReader("harom.txt");
                Console.WriteLine(be.ReadToEnd());
                be.Close();
                File.Delete("harom.txt");
                StreamWriter egy = new StreamWriter("harom.txt", append: true);
                egy.Write("");
                egy.Close();
            }
            else if (mellek_szam1 == "16")
            {
                StreamReader be = new StreamReader("negy.txt");
                Console.WriteLine(be.ReadToEnd());
                be.Close();
                File.Delete("negy.txt");
                StreamWriter egy = new StreamWriter("negy.txt", append: true);
                egy.Write("");
                egy.Close();
            }
            else if (mellek_szam1 == "1")
            {
                Console.WriteLine("----------------");
                Console.WriteLine("  11-titkárság  ");
                Console.WriteLine("----------------");
                StreamReader be = new StreamReader("egy.txt");
                Console.WriteLine(be.ReadToEnd());
                be.Close();

                Console.WriteLine("----------------");
                Console.WriteLine("    14-tanári   ");
                Console.WriteLine("----------------");
                StreamReader be1 = new StreamReader("ketto.txt");
                Console.WriteLine(be1.ReadToEnd());
                be.Close();

                Console.WriteLine("----------------");
                Console.WriteLine("  15-kollégium  ");
                Console.WriteLine("----------------");
                StreamReader be2 = new StreamReader("harom.txt");
                Console.WriteLine(be2.ReadToEnd());
                be.Close();


                Console.WriteLine("----------------");
                Console.WriteLine("  16-könyvtár   ");
                Console.WriteLine("----------------");
                StreamReader be3 = new StreamReader("negy.txt");
                Console.WriteLine(be3.ReadToEnd());
                be.Close();
            }
            else if (mellek_szam1 == "0")
            {
                break;
            }
            else Console.WriteLine("Hiba");
        }
    }
    else if (valaszt == "3")
    {
        break;
    }
    else Console.WriteLine("Hibás szám");
}


Console.ReadLine();

//DateTime aktual_ido = DateTime.Now;
//Console.WriteLine("Aktual idő:" + aktual_ido);

