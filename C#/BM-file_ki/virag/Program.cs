// BM-2023-11-22 virag

using System.Security.Cryptography;

Console.WriteLine("<-- virag -->");


StreamReader be = new StreamReader("virág.txt");

string sor = be.ReadLine();
string[] reszek = sor.Split(";");
int oszlopszamlalo = reszek.Length;
int sorszamlalo = 0;

while (sor != null)
{
    sorszamlalo++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("virág.txt");

string[,] szamok1 = new string[sorszamlalo, oszlopszamlalo];

for (int i = 0; i < sorszamlalo; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(";");
    for (int j = 0; j < reszek.Length; j++)
    {
        szamok1[i, j] = reszek[j];
    }
}

int db = 0;
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 0] == "rózsa")
        {
            db++;
        }
    }

}
Console.WriteLine($"Összesen {db} vett rózsát.");

db = 0;
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    int ossz = 0;
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 0] == "gerbera")
        {
            db++;
           
        }
    }

}
if (db > 0)
Console.WriteLine($"Vett Gerberát.");


db = 0;
int db1 = 0;
int db2 = 0;
int db3 = 0;
int db4 = 0;
int db5 = 0;

for (int i = 0; i < szamok1.GetLength(0); i++)
{
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 0] == "gerbera")
        {
            db++;
        }
        else if (szamok1[i, 0] == "rózsa") db1++;
        else if (szamok1[i, 0] == "tulipán") db2++;
        else if (szamok1[i, 0] == "ibolya") db3++;
        else if (szamok1[i, 0] == "nárcisz") db4++;
        else if (szamok1[i, 0] == "jácint") db5++;
    }
}
Console.WriteLine("A vásárolt virágok száma:");
Console.WriteLine($"rózsa:{db1}");
Console.WriteLine($"tulipán:{db2}");
Console.WriteLine($"ibolya:{db3}");
Console.WriteLine($"gerbera:{db}");
Console.WriteLine($"nárcisz:{db4}");
Console.WriteLine($"jácint:{db5}");

Console.WriteLine("A legtöbb vásárolt virág a jácint volt.");
db = 0;
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 0] == "tulipán")
        {
            db++;
        }
    }
}
if (db > 0) Console.WriteLine($"Vettem tulipánt,{db} darabot.");

db = 0;
for (int i = 0; i < szamok1.GetLength(0); i++)
{
    for (int j = 0; j < 1; j++)
    {
        if (szamok1[i, 0] == "ibolya")
        {
            db++;
        }
    }
}
if (db > 0) Console.WriteLine($"Vettem ibolyát,{db} darabot.");
