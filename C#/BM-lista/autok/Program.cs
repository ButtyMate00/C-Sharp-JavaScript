// BM-2023.12.13

using System.IO;
using System.Text;

List<string> autok = new List<string>();
List<string> valasztas = new List<string>() {"Opel Astra", "VW Golf", "Nissan Qashqai", "Tesla Model Y", "Volvo X90"};


string[] lines;
var list = new List<string>();
var fileStream = new FileStream(@"h:\autolista.txt", FileMode.Open);
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
{
    string line;
    while ((line = streamReader.ReadLine()) != null)
    {
        autok.Add(line);
    }
}
lines = list.ToArray();


bool kilep = true;
bool fut = true;
while (fut)
{
    Console.WriteLine("---------------");
    Console.WriteLine("Autók listája");
    Console.WriteLine("---------------");
    for (int i = 0; i < autok.Count; i++)
        Console.WriteLine($"{i + 1}. {autok[i]}");

    Console.WriteLine("Válasszon menüpontot!");
    Console.WriteLine("1 - autó hozzáadása");
    Console.WriteLine("2 - autó törlése");
    Console.WriteLine("0 - kilépés");

    Console.Write("Menüpont száma: ");
    char menupont = Convert.ToChar(Console.ReadLine());

    switch (menupont)
    {
        case '1':
            kilep = true;
            while (kilep)
            {
                Console.WriteLine("Válasszon menüpontot!");
                Console.WriteLine("1 - autó hozzáadása (lista)");
                Console.WriteLine("2 - autó hozzáadása (manual)");
                Console.WriteLine("0 - kilépés");
                Console.Write("Menüpont száma: ");
                char valasz = Convert.ToChar(Console.ReadLine());
                switch (valasz)
                {
                    case '1':
                        for (int i = 0; i < valasztas.Count; i++)
                            Console.WriteLine($"{i + 1}. {valasztas[i]}");
                        Console.Write("Add meg a választásodat: ");
                        int vlasz = int.Parse(Console.ReadLine());
                        if (vlasz == 4)
                        {
                            autok.Insert(0, "Tesla Model Y");
                        }
                        else autok.Add(valasztas[vlasz]);
                        break;
                    case '2':
                        Console.Write("Add meg a játék nevét: ");
                        autok.Add(Console.ReadLine()); ;
                        break;
                    case '0':
                        kilep = false;
                        break;

                }
            }        
            break;
        case '2':
            Console.WriteLine("Melyik autót töröljük?");
            for (int i = 0; i < autok.Count; i++)
                Console.WriteLine($"{i + 1}. {autok[i]}");
            Console.Write("Autó sorszáma: ");
            autok.RemoveAt(int.Parse(Console.ReadLine()) - 1);
            break;
        case '0':
            File.Delete(@"h:\autolista.txt");
            StreamWriter egy = new StreamWriter(@"h:\autolista.txt", append: true);
            for (int i = 0; i < autok.Count; i++)
                egy.WriteLine(autok[i]);
            egy.Close();
            fut = false;
            break;

        default:
            break;
    }

}

Console.ReadLine();