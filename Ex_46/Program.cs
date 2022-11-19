// 46. задайте двумерный массив размером mxn, заполненный случайными целыми числами

Console.Clear();

int[,] GetArray(int m, int n, int mi, int ma)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(mi, ma + 1);
        }
    }
    return result;
}

void PrintArrya(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимум");
int minim = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимум");
int maxim = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, col, minim, maxim);
PrintArrya(array);