// Принимает на вход число N и выдает произведение чисел от 1 до N

Console.Clear();

int GetMult(int x)
{

    if (x > 0)
    {
        int mult = 1;
        for (int i = 1; i <= x; i++)
        {
            mult *= i;
        }
        return mult;
    }
    else 
    {
        return 0;
    }
}

Console.WriteLine("Введите число");
Console.WriteLine(GetMult(int.Parse(Console.ReadLine()!)));