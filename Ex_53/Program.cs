// 53. Задать двумерный массив. Поменять местами первую и последнюю строчки массива

Console.Clear();

int[,] GetAr(int m, int n, int mi = -10, int ma = 10) // Создание и вывод матрицы для сверки. Диапазон задан по умолчанию
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

int[,] ReplaceString(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp[i] = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp[i];
    }
    return arr;
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

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);

int[,] firstArray = GetAr(row, col);
Console.WriteLine();
PrintArr(ReplaceString(firstArray));