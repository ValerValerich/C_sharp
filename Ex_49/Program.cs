// 49. Задайте двухмерный массив. Найдите элементы, у которых оба индекса четные и замените на их квадраты.

Console.Clear();

int[,] GetAr(int m, int n, int mi, int ma)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(mi, ma + 1);
            Console.Write($"{res[i, j]} \t");
        }
        Console.WriteLine();
    }
    return res;
}

int[,] Sqar(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i += 2)
    {
        for (int j = 0; j < ar.GetLength(1); j += 2)
        {

            ar[i, j] = ar[i, j] * ar[i, j];

        }
    }
    return ar;
}

int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

int[,] arr = GetAr(m, n, 0, 10);

void PrintAr(int[,] arrr)
{
    Console.WriteLine();
    for (int i = 0; i < arrr.GetLength(0); i++)
    {
        for (int j = 0; j < arrr.GetLength(1); j++)
        {
            Console.Write($"{arrr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

PrintAr(Sqar(arr));