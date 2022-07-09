//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30


int Prompt(string message) 
{
Console.WriteLine(message);
string a_String = Console.ReadLine();
return int.Parse(a_String);
}

int PrintSumNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return 0;
    return PrintSumNumbers(numberM, numberN-1)+numberN;

}
int numberM = Prompt("Введите число 1: ");
int numberN = Prompt("Введите число 2: ");

System.Console.WriteLine();

int a = PrintSumNumbers(numberM, numberN);
System.Console.WriteLine($"Произведение натуральных чисел от {numberM} до {numberN} =>");