//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше или равна 3 символа.
    
    Console.WriteLine("Введите значения через запятую: "); //текстовое представление заданного значения
    
    var input = Console.ReadLine(); // Объявлена переменная Var
    string[] array = input.Split(",");  //ввод переменых через запятую

var result = new string[array.Length];
var realSize = 0; // указан размер
foreach (var value in array) // перебор массива
{
    if (value.Length <= 3) //введено при условии задачи 
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize)); // вывод результата
