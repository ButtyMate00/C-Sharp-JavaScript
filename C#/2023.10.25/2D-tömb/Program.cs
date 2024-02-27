// 2023-10-25
// 2D - BM
Console.WriteLine("<--2D-tömb-->");

int[,] mátrix = new int[,] {
 { 421, 23,  42,  1 },
 { 45,  674, 341, 52 },
 { 56,  12,  343, 54 }
};
Console.WriteLine("Magassága: " + mátrix.GetLength(0)); //3 
Console.WriteLine("Szélessége: " + mátrix.GetLength(1)); //4

for (int i = 0; i < mátrix.GetLength(0); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++) 
    {
        Console.Write(mátrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadKey();