try
{
    Console.Write("Adj meg egy számot:");
    int szam = int.Parse(Console.ReadLine());

    Console.WriteLine($"A szám négyzete: {Math.Pow(szam, 2)}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Nem számot adtál meg!");
}
