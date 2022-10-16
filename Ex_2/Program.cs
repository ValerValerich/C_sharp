// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите первое число:");
int b = int.Parse(Console.ReadLine()!);

if (a < b)
{
    Console.WriteLine($"Число {a} меньше, чем {b}");
}
else if (a>b)
{
    Console.WriteLine($"Число {b} меньше, чем {a}");
}
else
{
    Console.WriteLine("Числа равны");
}