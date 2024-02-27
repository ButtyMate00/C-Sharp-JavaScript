using System;

HashSet<string> alaphalmaz = new HashSet<string>() { "Cafe Frei", "Dolce Gusto", "Bravos" };

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Melyik kávát adnád hozzá?");
    var kave = Console.ReadLine();
    alaphalmaz.Add(kave);
}

string hal = ["keszeg", "ponty", "csuka", "harcsa", "süllő", "kárász", "angolna", "márna", "fogasponty", "sügér", "amur", "menyhal", "domolykó", "keszeg", "garda", "paduc", "compó", "bodorka", "nyúldomolykó"];
