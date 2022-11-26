// 66. Задать M и N. Найти сумму чисел в промежутке

Console.Clear();

int SumNums(int start, int fin)
{
    if (start == fin) return start;
    return fin += SumNums(start, fin - 1);
}

Console.WriteLine("Введите начальное значение");
int firstNum = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите конечное значение");
int finishNum = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"{SumNums(firstNum, finishNum)}");