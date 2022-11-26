// 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

Console.Clear();

int SumNum(int num = 123)
{
    if (num == 0) return num;
    int big = num / 10;
    int fin = num % 10;
    return fin + SumNum(big);
}

Console.Write(SumNum());
