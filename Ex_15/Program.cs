// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверят, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите номер дня недели:");

int num = int.Parse(Console.ReadLine()!);
if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (0 < num && num < 6)
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}
