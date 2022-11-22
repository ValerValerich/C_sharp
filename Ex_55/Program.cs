// 55. Задать двумерный массив. Заменить строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение

Console.Clear();

int[,] GetAr(int m, int n, int mi = -10, int ma = 10) // Создание и вывод матрицы для сверки. Диапазон задан по умолчанию
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(mi, ma + 1);
        }
    }
    return res;
}

void PrintArr(int[,] inAr)
{
    for (int i = 0; i < inAr.GetLength(0); i++)
    {
        for (int j = 0; j < inAr.GetLength(1); j++)
        {
            Console.Write($"{inAr[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

int[,] TransMatrix(int[,] arr)
{
    int[,] res = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res[j, i] = arr[i, j];
        }

    }
    return res;
}

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);

int[,] Array = GetAr(row, col);
PrintArr(Array);
Console.WriteLine();
PrintArr(TransMatrix(Array));