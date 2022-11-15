// 42. Десятичные числа в двоичные

Console.Clear();

int GetBin(int num)
{
    string res = "";
    if (num == 0) return 0;
    while (num > 0)
    {
        res = (num % 2).ToString() + res;
        num /= 2;
    }
    return int.Parse(res);
}

Console.WriteLine("Введите число в 10 системе");

Console.WriteLine($"Ваше число в двоичной системе: {GetBin(int.Parse(Console.ReadLine()!))}");