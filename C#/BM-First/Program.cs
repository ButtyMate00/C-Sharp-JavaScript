// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

//Console.Write("Szia, ");
////Console.ReadLine();
//Console.WriteLine("Butty Máté");

//Console.WriteLine("Szeptember"); //Az aktuális hónap 



//Console.WriteLine("13.-a");
/*
int a = 7; //változó létrehozása, értékadás
int b = 3; //változó létrehozása, értékadás
//az ab változóba lesz eltárolva a + b eredménye 
int ab = a + b;
int aszorb = a * b; //21
b = b + 3; //ugyan azt az eredményt kapjuk, csak rövidít
b += 3; //Például az alábbi képlet megegyezik: 
a -= 2;



Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(ab);
Console.WriteLine(aszorb);
Console.WriteLine(aszorb);


//stringek összeadása/összefűzése 
string str1 = "alma";
string str2 = "fa";
string ossz = str1 + str2; //az eredmény: almafa
Console.WriteLine(ossz);

char car = 'c';
Console.WriteLine(car);

bool megnyerte_e = true;
Console.WriteLine(megnyerte_e);


byte r = 125;
byte g = 76;
byte b = 204;

Console.Write("RGB(");
Console.Write(r + ",");
Console.Write(g + ",");
Console.WriteLine(b + ")");

double suly = 80.5462;
Console.WriteLine(suly + 4.15);

int szamlalo = 0;
szamlalo++;
Console.WriteLine(szamlalo);

int a = 2, b = 4, c; //több változó létrehozása egy sorban




Console.Write("Add meg a becenevedet:");
string becenev = Console.ReadLine();
Console.Write("Szia, " + becenev);
*/
Console.Write("Add meg a számot:");
string beker = Console.ReadLine();//szöveg bekérése és eltárolása a beker változóban 
int szam1 = int.Parse(beker); //változó = típus.Parse(string típus
int szam2 = Convert.ToInt32(beker); //változó = Convert.To+típus+(valamilyen típus)

Console.WriteLine(beker + " " + (szam1 + szam2));


Console.ReadKey();

