// BM - 2023.12.13
Console.WriteLine("Hello world!");

/*
List<int> lista = new List<int>();
lista.Add(12);
lista.Add(43);

Random rnd = new Random();

for (int i = 0; i < 10; i++)
    lista.Add((int)rnd.Next(1, 100));

foreach (int item in lista)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
Console.WriteLine("Kapacítása: " + lista.Capacity);
Console.WriteLine("Mérete: " + lista.Count);
*/

List<string> jatekok = new List<string>() { "GTA VI", "Shadow of Mordor", "Quake III", "LoL" };



bool fut = true;
while (fut)
{
    Console.WriteLine("---------------");
    Console.WriteLine("Játékok listája");
    Console.WriteLine("---------------");
    for (int i = 0; i < jatekok.Count; i++)
        Console.WriteLine($"{i + 1}. {jatekok[i]}");

    Console.WriteLine("Válasszon menüpontot!");
    Console.WriteLine("1 - játék hozzáadása");
    Console.WriteLine("2 - játék törlése");
    Console.WriteLine("0 - kilépés");

    Console.Write("Menüpont száma: ");
    char menupont = Convert.ToChar(Console.ReadLine());

    switch (menupont)
    {
        case '1':
            Console.Write("Add meg a játék nevét: ");
            jatekok.Add(Console.ReadLine());
            break;
        case '2':
            Console.WriteLine("Melyik játékot töröljük?");
            for (int i = 0; i < jatekok.Count; i++)
                Console.WriteLine($"{i + 1}. {jatekok[i]}");
            Console.Write("Játék sorszáma: ");
            jatekok.RemoveAt(int.Parse(Console.ReadLine()) - 1);
            break;
        case '0':
            fut = false;
            break;

        default:
            break;
    }

}










/*
foreach (string jateknev in jatekok)
{
    Console.Write(jateknev + ", ");
}

jatekok.Insert(2, "WoW");
jatekok.Remove("God of War");
jatekok.RemoveAt(0);*/


Console.ReadKey();
