StreamWriter ki = new StreamWriter("ki.txt");

ki.WriteLine("Alma");

ki.Close();

StreamReader be = new StreamReader("ki.txt");
Console.WriteLine(be.ReadToEnd());

be.Close();