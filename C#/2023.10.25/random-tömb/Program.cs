// 2023-10-25
// random-tömb - BM
Console.WriteLine("<--random-tömb->");

double[,] mátrix = new double[5, 5];

Random r = new Random();

for (int i = 0; i < mátrix.GetLength(0); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++)
    {
        mátrix[i, j] = r.Next(100,1000);
    }
}

for (int i = 0; i < mátrix.GetLength(0); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++)
    {
        Console.Write(mátrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadKey();