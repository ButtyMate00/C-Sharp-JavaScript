Console.WriteLine("BM-2024.01.03");



int[] tömb = new int[] { 20, 30, 12 };
List<int> lista = new List<int>() { 18, 46, 91};
lista.AddRange(tömb);

/*
for (int i = 0; i < lista.Count(); i++)
    Console.WriteLine(lista[i]);
*/

// lista.InsertRange(2, tömb);

/*
for (int i = 0; i < lista.Count(); i++)
    Console.WriteLine(lista[i]);
*/

lista.Sort();
foreach (int item in lista)
{
    Console.WriteLine(item);
}

if (lista.Contains(18)) Console.WriteLine("Van 18-as");

Console.Write("Add meg a keresett számot: ");
int szam = int.Parse(Console.ReadLine());

int index = lista.IndexOf(szam);
if (index != -1) 
    Console.WriteLine($"A {szam} szám a(z) {index}. indexen van.");
else
    Console.WriteLine($"A {szam} szám nincs a listában.");
Console.ReadKey();