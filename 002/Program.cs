// Задача

string[] A;
System.Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
A = stroka.Split(' ');
var result = new string[A .Length];
var realSize = 0;
foreach (var value in A )
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
System.Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);