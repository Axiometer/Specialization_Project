// задаем массив строк
string[] inputString;
Console.WriteLine("Введите массив строк через пробел");
// вводим его с клавиатуры, разбивая в массив по пробелам
inputString = Console.ReadLine().Split(' ');
// создаем новый массив такой же размерности как получившийся
var result = new string[inputString.Length];
// текущая размерность нового массива
var realSize = 0;

// пробегаем в цикле по изначальному массиву строк
foreach (var value in inputString)
{
    // если длина строки текущей итерации не превышает 3
    if (value.Length <= 3)
    {
        // добавляем это слово в новый массив и прибавляем счетчик размерности
        result[realSize] = value;
        realSize++;
    }
}

// выводим результат на экран
System.Console.WriteLine("\nВывод всех слов длиннее 3:");
foreach (var i in result)
    System.Console.Write(i+" ");
