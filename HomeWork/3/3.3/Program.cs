﻿// Задача 3: Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int prompt(string message)
{
 Console.WriteLine("message");   
 string number = Console.ReadLine();
 int numInt = int.Parse(number);
 return numInt;
}

int x = prompt("Введите число");

for (int i = 1; i <= x; i++)
{
    Console.Write($"{i * i * i} ");
}
