// BM-2023.12.06

using System.Threading.Channels;
string numbers = new string("");
int i = 0;
while (i != 3)
{
    try
    {
        Console.Write("Add meg a számot: ");
        int szam = int.Parse(Console.ReadLine());
        i++;
        numbers += szam.ToString() + "; ";  
    }
    catch (Exception e)
    {
    Console.WriteLine(e.Message);
    Console.WriteLine("Nem számot adtál meg!");
    }
}
Console.WriteLine(numbers);

Console.ReadLine();