// 36. Задать одномерный массив с рандомными числами. Найти сумму элементов, стоящих на нечетных позициях.

Console.Clear();

int[] GetArray(int size = 7, int minValue = 1, int maxValue = 10) // Указываю условия здесь, потому что надоело каждый раз вводить с консоли
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(',', res));
    return res;
}

void sumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    Console.WriteLine(sum);
}

sumOdd(GetArray());