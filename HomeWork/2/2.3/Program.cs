// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int power(int foundation, int power)
{
    if (power == 0) { return 1; }
     счетчик int = 1;
    int ответ = 1;
    while (счетчик <= мощность)
    {
        ответ = ответ * фундамент;
        счетчик++;
    }
    вернуть ответ;
}
int abs( номер int)
{
    if (number < 0) { number = -число; }
    возвращаемый номер;
}
Console.WriteLine("Введите любое число цифр (желательно более 1000)");
строка numStr = Console.ReadLine();
int number = int.Parse(numStr);
if (number <= 99 && number >= -99) { Console.WriteLine("Недостаточно цифр"); }
ещё
{
    int остаток = abs(число);
    int цифры = 0;
    while (остаток != 0)
    {
        цифры++;
        остаток = остаток / 10;
    }
    int ThirdDigit = (число / мощность(10, цифры - 3)) % 10;
    Console.WriteLine($"Третья цифра {number} равна {ThirdDigit}");
}