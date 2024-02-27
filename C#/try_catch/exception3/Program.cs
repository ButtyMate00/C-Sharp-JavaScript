int a = 0;
try
{
    a = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Hiba - Nem sikerült átalakítani a bevitt karakterláncot!");
}
catch (OverflowException ofe)
{
    Console.WriteLine(ofe.Message);
}
catch (Exception e)
{
    Console.WriteLine("Ismeretlen hiba: " + e.Message);
}