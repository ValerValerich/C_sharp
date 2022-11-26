// 63. Задать N. вывести все натуральные числа в промежутке от 1 до N

Console.Clear();

string PrintNums(int n = 5)
{
    if (n == 1) return n.ToString();
    return $"{PrintNums(n - 1)}, {n}";
}

Console.Write(PrintNums());