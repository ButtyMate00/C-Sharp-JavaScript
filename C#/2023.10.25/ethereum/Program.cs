// 2023-10-25
// ethereum - BM
Console.WriteLine("<--ethereum-->");

Random r = new Random();

double ethereum = 646383.66;

double[,] honapok = new double[20, 6];


Console.WriteLine();
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 6; j++)
    {
        honapok[i, j] = ethereum;
        double szam = r.NextDouble();
        szam = szam * 100000;
        ethereum += szam;
    }
}

for (int i = 0; i < honapok.GetLength(0); i++)
{
    for (int j = 0; j < honapok.GetLength(1); j++)
    {
        Console.Write(Math.Round(honapok[i, j], 2) + "\t");
    }
    Console.WriteLine();

}

Console.ReadKey();
