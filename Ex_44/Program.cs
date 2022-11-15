// 44. Не используя рекурсию выведите первые N чисел Фибоначчи. Первые два числа- 0 и 1

Console.Clear();

int[] Fibonacci(int a)
{
    int[] arr = new int[a];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < a; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

Console.WriteLine("Введите требуемое количество чисел Фибоначчи");

Console.WriteLine(String.Join(',', Fibonacci(int.Parse(Console.ReadLine()!))));