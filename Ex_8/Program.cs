// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int start = 2;
while (start <= a)
{
    Console.Write($"{start}, ");
    start+=2;
}