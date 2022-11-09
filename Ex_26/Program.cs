// На выход число и выдает количество цифр в нём

Console.Clear();

int HowManyFigure(int x)
{
    int result = 0;
    if (x != 0)
    {
        while (x != 0)
        {
            x /= 10;
            result += 1;
        }
    }
    else { result = 1; }
    return result;
}

Console.WriteLine("Введите число для определения количества цифр в нем");
Console.WriteLine(HowManyFigure(int.Parse(Console.ReadLine()!)));