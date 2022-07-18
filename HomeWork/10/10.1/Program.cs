﻿// 
using System.Text;
void RecursiveNRepeated(int N)
{
    if (N == 12)
    {
        return;
    }
    else
    {
        {
            string str = new StringBuilder($"{N} ".Length * N).Insert(0, $"{N} ", N).ToString();
            RecursiveNRepeated(N-1);
            System.Console.Write(str);            
        }
    }
}


int Prompt (string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    int N = Prompt("Введите число");
    RecursiveNRepeated(N);

}



Solve();