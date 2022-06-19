// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число => ");
string Pal = Console.ReadLine();
int len = Pal.Length;

bool q = true;

for (int i = 0; i <= len / 2; i++)
{
    if (Pal[i] != Pal[len - 1 - i])
    {
        Console.WriteLine($"{Pal} не палиндром");
        q = false;
        break;
    }
}

if (q == true)
{
    Console.WriteLine($"{Pal} это палиндром");
}