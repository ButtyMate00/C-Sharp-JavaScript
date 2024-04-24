using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BM_egyéni_projekt
{
    internal class Program
    {
        class Felhasználó
        {
            public Felhasználó(string loginlist)
            {
                var acc_lista = loginlist.Split('|');
                string name = acc_lista[0];
                string pass = acc_lista[1];

            }

            public string pass; public string name; 
        }
    static void Main(string[] args)
        {
            int menu_0 = 0; int menu_1 = 0; string name; string pass;
            while (menu_0 == 0)
            {
                Console.WriteLine("Válasz egy opciót:\n - Bejelentkezés [1]\n - Regisztráció  [2]\t");
                menu_1 = int.Parse(Console.ReadLine());
                if (menu_1 == 2)
                {
                    Console.Write("Add meg a felhasználó neved:"); name = Console.ReadLine();
                    Console.Write("Add meg egy jelszó:"); pass = Console.ReadLine();
                    StreamWriter register = new StreamWriter("name_pass.txt", append: true);
                    register.WriteLine(name + "\t|\t" + pass);
                    register.Close();
                    menu_1 = 3;
                }
                else if (menu_1 == 1)
                {
                     Console.Write("Add meg a felhasználó neved:"); name = Console.ReadLine();
                     Console.Write("Add meg egy jelszó:"); pass = Console.ReadLine();
                     ArrayList Login = new ArrayList();
                     var BTC = File.ReadAllLines("name_pass.txt");
                     List<string> Loginlist = BTC.ToList();
                     foreach (string s in Loginlist) Login.Add(new Felhasználó(s));

                }
                else if (menu_1 == 3)
                {
                    Console.WriteLine("sad");
                }
                else Console.WriteLine("Hibás válasz!\n");
            }
        }
    }
}
