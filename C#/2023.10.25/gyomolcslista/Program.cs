// 2023-10-25
// gyumolcslista - BM
Console.WriteLine("<--gyumolcslista->");

string[,] gyumolcsok = new string[3, 3]
{
    { "alma", "körte", "banán"},
    { "meggy", "cseresznye", "barack"},
    { "szőlő", "szilva", "áfonya"}
};

for (int i = 0; i < gyumolcsok.GetLength(0); i++)
{
    for (int j = 0; j < gyumolcsok.GetLength(1); j++)
    {
        Console.Write(gyumolcsok[i, j] + ", ");
    }
}


Console.ReadKey();