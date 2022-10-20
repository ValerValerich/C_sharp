// Принимает на вход координаты точки (X и Y) и выдает номер координатной четверти

Console.Clear();

int findQuater(int x, int y)
{
    if (x > 0)
    {
        if (y > 0)
        {
            return 1;
        }
        else
        {
            return 4;
        }
    }
    else
    {
        if (y > 0)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}

int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);

int quater = findQuater(X, Y);

Console.WriteLine($"{quater}");