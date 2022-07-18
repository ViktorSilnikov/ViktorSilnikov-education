//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше или равна 3 символа.
    
    Console.WriteLine("Введите значение через запятую: ");
    
    var input = Console.ReadLine();
    string[] array = input.Split(",");  

var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
