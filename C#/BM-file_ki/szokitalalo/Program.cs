// BM-2023-11-22
using System.Threading.Channels;

Console.WriteLine("<-- Szókitaláló -->");
Console.WriteLine("");

StreamReader be = new StreamReader("szokitalalo_szavak.txt");
StreamWriter ki = new StreamWriter("ki.txt");
Random random = new Random();

string sor = be.ReadLine();
string[] reszek = sor.Split(", ");

foreach (var szo in reszek)
{
    ki.WriteLine(szo);
}

string gen_szo = reszek[random.Next(reszek.Length-1)];

Console.WriteLine(gen_szo);

Console.Write("Add meg a tippedet: ");
string tipp = Console.ReadLine();
string temp = "";


bool megy = true;

while (megy)
{
    if (tipp == gen_szo)
    {
        Console.WriteLine("Eltaláltad a szót!");
        megy = false;
    }
    else
    {
        Console.WriteLine("Nem találtad el a szót!");
        Console.Write("Add meg a tippedet: ");
        tipp = Console.ReadLine();

        for (int i = 0; i < gen_szo.Length; i++)
        {
            if (tipp[i] == gen_szo[i])
            {
                Console.Write(tipp[i]);
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.WriteLine();
    }
}





be.Close();
ki.Close();

Console.ReadLine();