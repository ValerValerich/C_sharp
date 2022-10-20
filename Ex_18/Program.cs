// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (х и у)

string getList(int x)
{
    if (x == 1)
    {
        return "х > 0, y > 0";
    }
    else if (x == 2)
    {
        return "х < 0, y > 0";
    }
    else if (x == 3)
    {
        return "х < 0, y < 0";
    }
    else if (x == 4)
    {
        return "х > 0, y < 0";
    }
    else{
        return "Нет такой четверти";
    }
}

Console.Clear();
Console.WriteLine("Введите номер четверти");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(getList(n));
