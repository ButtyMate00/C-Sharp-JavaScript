// BM - 2023-10-18
// Karakter tömbbel

using System.Threading.Channels;

Console.WriteLine("----------------");
Console.WriteLine("Karakter tömbbel");
Console.WriteLine("----------------");

char[] karakterek = new char[20];

for (int i = 0; i < karakterek.Length; i++)
{
    Console.Write("Add meg a kereszneved következő betűjét [0-kilépés]: ");
    karakterek[i] = char.Parse(Console.ReadLine());
    if (karakterek[i] == '0')
    {
        break;
    }
}

//foreach (char c in karakterek) { Console.Write(c); } 

int j = 0;
while (j < karakterek.Length-1)
{
    Console.Write(karakterek[j]);
    j++;    
}

Console.ReadKey();
