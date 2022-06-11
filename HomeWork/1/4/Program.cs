// задача 4

Console.WriteLine(" введите число : ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
int i = 2;
while (i <= numberInt);
{
    Console.Write($"{i} ");
i+=2;
}