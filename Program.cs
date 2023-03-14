string[] M;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');
var result = new string[M.Length];
var realSize = 0;
foreach (var value in M )
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

System.Console.WriteLine("\nВывод всех слов длиннее 3:");
foreach (var i in result)
    System.Console.Write(i+" ");
