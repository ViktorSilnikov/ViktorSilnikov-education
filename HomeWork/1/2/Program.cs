//Задача 2. 

Console.Write("Вставить первое число :");
string number1 = Console.ReadLine();

Console.Write("Вставить второе число :");
string number2 = Console.ReadLine();

Console.Write("Вставить третье число :");
string number3 = Console.ReadLine();

int numberInt1 = int.Parse(number1);
int numberInt2 = int.Parse(number2);
int numberInt3 = int.Parse(number3);
int max=0, min=0;

if (max<numberInt1)
{
    max = numberInt1; 

}
if (max<numberInt2)
{
    max = numberInt2;
}
if (max<numberInt3)
{
    max = numberInt3;
}

Console.WriteLine ($"Самое большое число : {max}");