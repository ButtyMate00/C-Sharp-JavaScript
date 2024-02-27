try
{
    Console.Write("Mennyivel osszam el 10-et? ");
    int oszto = int.Parse(Console.ReadLine());
    Console.WriteLine($"Eredmény: {10 / oszto}");
}
catch (FormatException)
{
    Console.WriteLine("Hiba nem sikerült átalakítani");
}
catch (DivideByZeroException dbze)
{
    Console.WriteLine($"Hibatüzenet: {dbze.Message}");
    Console.WriteLine("Nullával nem lehet osztani.");
}
catch (Exception e)
{
    Console.WriteLine($"Ismeretlen hiba {e.Message}");
}
finally
{
    Console.WriteLine("vége");
}


//  try:
//    oszto = int(input('Mennyivel osszam el a 10-et? '))
//    print(f'Az eredmeny: {10 / oszto}')
//except ZeroDivisionError as e:
//    print('Hiba: ', e)
//    print('Nullával nem oszthatunk!')
//except ValueError as e:
//    print('Hiba: ', e)
//    print('Nem számot adtál meg!')
//print('A program vége')