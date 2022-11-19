// 51. Задайте двумерных массив. Найдите сумму элиментов, находящихся на главно диагонали.

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

void sumGeneralDiag(int[,] ar)
{
    int summ = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i == j)
            {
                summ += ar[i, j];
            }
        }

    }
    Console.WriteLine(summ);
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

int[,] arr = GetAr(a, b, -10, 10);

sumGeneralDiag(arr);