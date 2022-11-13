// 34. Задать массив рандомных положительных трехзначных чисел. Показать количество четных.

Console.Clear();

int[] GetArray(int size = 5, int minValue = 100, int maxValue = 999) // Указываю условия здесь, потому что надоело каждый раз вводить с консоли
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(',', res));
    return res;
}

int cntPositiv(int[] arr)
{
    int cnt = 0;
    foreach (int i in arr)
    {
        cnt += i % 2 == 0 ? 1 : 0;
    }
    return cnt;
}

Console.WriteLine(cntPositiv(GetArray()));