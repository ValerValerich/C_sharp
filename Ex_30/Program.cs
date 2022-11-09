// 30. выводит массив из 8 элементов, заполненный нулями и единицами в рандоме

Console.Clear();

int[] GetArr(int x)
{
    int[] a = new int[x];
    for (int i = 0; i < x; i++)
    {
        a[i] = new Random().Next(0, 2);
    }
    return a;
}

Console.WriteLine("Введите длину массива");
foreach (int i in GetArr(int.Parse(Console.ReadLine()!)))
{
    Console.Write(i + " ");
}
