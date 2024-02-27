// BM - 2023-10-18
// Tárgyak tömbbel

Console.WriteLine("---------------");
Console.WriteLine("Tárgyak tömbbel");
Console.WriteLine("---------------");

string[] szekreny = new string[] { "zokni", "nadrág", "póló", "pulcsi", "sapka" };
// int[] bull[] char[] 

//Console.WriteLine(szekreny[0]);

for (int i = 0; i < szekreny.Length; i++)
    Console.Write(szekreny[i] + " ");

Console.ReadKey();
