// Задача 24. Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Summator(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Summator(n));