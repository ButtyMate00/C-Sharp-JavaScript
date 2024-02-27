//BM-2024-01-17

using Microsoft.VisualBasic;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

string[] szoveg1 = File.ReadAllLines("szoveg1.txt");
HashSet<string> szoveg11 = new HashSet<string>(szoveg1);
foreach (string sor in szoveg11) Console.WriteLine(sor);
Console.WriteLine();
string[] szoveg2 = File.ReadAllLines("szoveg2.txt");
HashSet<string> szoveg22 = new HashSet<string>(szoveg2);
foreach (string sor in szoveg22) Console.WriteLine(sor);
Console.WriteLine();
//1. Feladat
Console.WriteLine($"1. Feladat: \n  1. {szoveg11.Count}\n  2. {szoveg22.Count} ");
Console.WriteLine();
//2. Feladat
string szoveg1_l = szoveg11.OrderByDescending(s => s.Length).First();
string szoveg2_l = szoveg22.OrderByDescending(s => s.Length).First();
Console.WriteLine($"2. Feladat: \n  1. {szoveg1_l}\n  2. {szoveg2_l} ");
//3. Feladat
szoveg11.UnionWith(szoveg22);
Console.WriteLine();
//4. Feladat
Console.WriteLine($"4. Feladat:");
List<string> szoveg11_list = szoveg11.ToList();
szoveg11_list.Sort();
foreach (var item in szoveg11_list) Console.WriteLine(item);
// 5.Feladat
var spaces = 0;
foreach (var item in szoveg11_list)
{
    Console.WriteLine(item);
    spaces += item.Count(c => !Char.IsWhiteSpace(c));
}
Console.WriteLine();
Console.WriteLine($"5. Feladat: {spaces}");
//6. Feladat
StreamWriter kozm = new StreamWriter("kozmondasok.txt", append: true);
foreach (string sor in szoveg11_list) kozm.WriteLine(sor);
kozm.Close();