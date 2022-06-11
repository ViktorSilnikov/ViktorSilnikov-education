//Задача 1. 

Console.Write("Вставить первое число :");
string number1 = Console.ReadLine();

Console.Write("Вставить второе число :");
string number2 = Console.ReadLine();

int number1Int = int.Parse(number1);
int number2Int = int.Parse(number2);
int max=0, min=0;

if (number1Int>number2Int)
{
    max = number1Int; 
    min = number2Int;
    Console.WriteLine($"первое число больше и равно : {max}\nВторое число меньше и равно");
}
else
{
    max = number2Int;
    min = number1Int;
    Console.WriteLine ($"второе число больше и равно : {max}\nПервое число меньше и равно");
}

