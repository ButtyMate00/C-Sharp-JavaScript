// 2023-10-25
// NumPad - BM
Console.WriteLine("<--NumPad-->");  

char[,] numpad = new char[2, 4];

for (int i = 0; i < numpad.GetLength(0); i++)
{
    for (int j = 0; j < numpad.GetLength(1); j++)
    {
        Console.Write($"Add meg a(z) {i+1}. sor {j+1}. oszlpának karakterét: ");
        numpad[i,j] = char.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

for (int i = 0; i < numpad.GetLongLength(0); i++)
{
    for (int j = 0; j < numpad.GetLength(1); j++)
    {
        Console.Write(numpad[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadKey();