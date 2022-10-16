// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите первое число:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (a < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"Максимальное число: {max}");