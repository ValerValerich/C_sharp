// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

string GetThirdLevel(int n)
{
    string answer ="";
    for (int i = 1; i <= n; i++)
    {
        answer =answer + ((Math.Pow(i, 3)).ToString() + ", ");
    }
    return answer;
}
Console.WriteLine("Введите число");
Console.WriteLine($"{GetThirdLevel(int.Parse(Console.ReadLine()!)).TrimEnd(' ').TrimEnd(',')}");