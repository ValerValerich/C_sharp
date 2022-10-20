// Принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.Clear();

string GetSQRT(int n)
{
    string answer ="";
    for (int i = 1; i <= n; i++)
    {
        answer =answer + ((i*i).ToString() + ", ");
    }
    return answer;
}
Console.WriteLine("Введите число");
Console.WriteLine($"{GetSQRT(int.Parse(Console.ReadLine()!)).TrimEnd(' ').TrimEnd(',')}");