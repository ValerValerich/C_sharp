// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int num = new Random().Next(1, 100000000);
int result = num;
while (result > 1000)
{
    result /= 10;
}
if (result > 99)
{
    result = result % 10;
    Console.WriteLine($"В числе {num} третья цифра {result}");
}
else
{
    Console.WriteLine($"В числе {num} третьей цифры нет");
}