// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = prompt("Введите число для дня недели ");
if (numberInt < 1 || numberInt > 7) 
{ 
    Console.WriteLine("В неделе всего 7 дней");
    Environment.Exit(0);
 }

    if (numberInt == 6 ||numberInt == 7) 
    
        Console.WriteLine("Это выходной"); 
        
    else Console.WriteLine("Нет, это не выходной");
