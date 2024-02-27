// 2023-10-25
// 5x5 - BM
Console.WriteLine("<--5x5->");

int[,] mátrix = new int[5, 5];

Random r = new Random();

for (int i = 0; i < mátrix.GetLength(0); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++)
    {
        mátrix[i, j] = r.Next(1, 91);
    }
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

/*
Console.Write("Melyik sort szeretné kiíratni: ");
for (int i = 0; i < int.Parse(Console.ReadLine()); i++)
{
    for (int j = 0; j < mátrix.GetLength(1); j++)
    {
        Console.Write(mátrix[i, j] + "\t");
    }
}
*/


Console.Write("Melyik oszlopot szeretné kiíratni: ");
int sor = int.Parse(Console.ReadLine());
sor -= 1;
for (int i = 0; i < mátrix.GetLength(0); i++)
{
    Console.Write(mátrix[i, sor] + "\t");
    Console.WriteLine();
}


Console.WriteLine();
Console.Write("A táblázat főátlóját: ");
int sor1 = 0;
int oszlop = 0;
for (int i = 0; i < mátrix.GetLength(0); i++)
{
    Console.Write(mátrix[sor1, oszlop] + ", ");
    sor1++;
    oszlop++;
}
Console.ReadKey();
