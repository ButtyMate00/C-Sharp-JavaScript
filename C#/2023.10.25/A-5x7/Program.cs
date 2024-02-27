// 2023-10-25
// A-5x7 - BM
Console.WriteLine("<--A-5x7->");

int[,] mátrix = new int[5, 7];

for (int i = 0; i < mátrix.GetLength(0); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++)
    {
        mátrix[i, j] 
    }
    Console.WriteLine();

}

for (int i = 0; i < mátrix.GetLength(0); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++)
    {
        Console.Write(mátrix[i, j] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine();

Console.ReadKey();
