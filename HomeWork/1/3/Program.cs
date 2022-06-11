// задача 3
Console.Write ("Вставить число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt%2==0)
{
    Console.WriteLine ($"число{numberInt} является четным.");
}
else
{

    Console.WriteLine($"число{numberInt} не является четным.");
}