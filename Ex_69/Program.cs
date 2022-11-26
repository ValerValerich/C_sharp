// 69. На вход A и B. Рекурсией A в степень B

Console.Clear();

int ToPow(int a = 2, int b = 3)
{
    if (b == 0) return 1;
    return ToPow(a, b - 1) * a;
}

Console.Write(ToPow());