// BM-2023-12-06

using System.Collections.Generic;

StreamWriter egy = new StreamWriter("egy.txt", append: true);
egy.WriteLine("1" + "; " + "2");
egy.Close();

StreamReader be = new StreamReader("egy.txt");
Console.WriteLine(be.ReadToEnd());
int a = be.get(0);
Console.WriteLine(a);
be.Close();

Console.ReadLine();