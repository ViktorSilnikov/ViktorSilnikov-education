// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("введите трехзначное число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);
    
if (paramInt < 100 || paramInt > 999) Console.WriteLine("Это не 3-значное число");
else Console.Write("Вторая цифра - " + (paramInt % 100)/10);