// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine()!);

int result = num / 10 % 10;

Console.WriteLine($"В числе {num} вторая цифра - это {result}");