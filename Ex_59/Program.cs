// 59. Задать двумерный массив. Удалить строку и столбец, на пересечении которых расположен наименьший элемент

Console.Clear();

int[,] GetAr(int m, int n, int mi = 1, int ma = 10) // Создание матрицы. Диапазон задан по умолчанию
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
    Console.WriteLine();
}

void ArrayWithoutMin(int[,] ar)
{
    int mi = ar[0, 0];
    int indI = 0;
    int indJ = 0;
    int[,] res = new int[ar.GetLength(0) - 1, ar.GetLength(1) - 1];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (ar[i, j] < mi) { mi = ar[i, j]; indI = i; indJ = j; }
        }
    }
    for (int i = 0; i < ar.GetLength(0); i++)
    {

        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i == indI || j == indJ)
            {
                continue;
            }
            else
            {
                Console.Write($"{ar[i, j]} \t");
            }
        }
        if (i == indI) { continue; }
        else { Console.WriteLine(); }

    }

}

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);

int[,] Array = GetAr(row, col);
PrintArr(Array);
Console.WriteLine();

ArrayWithoutMin(Array);
