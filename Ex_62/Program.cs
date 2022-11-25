// 62. Напишите программу, которая заполнит спирально массив 4 на 4

Console.Clear();

string[,] CreateMatrix(int a, int b)
{
    string[,] res = new string[a, b];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = "0";
        }
    }
    return res;
}

void PrintArr(string[,] inAr)
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

string[,] GetSpiral(string[,] ar)
{

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int param = 0;
    int visits = ar.GetLength(1);

    for (int i = 1; i < ar.GetLength(0) * ar.GetLength(1); i++)
    {
        ar[row, col] = i.ToString("00");
        if (visits - 1 == 0)
        {
            visits = ar.GetLength(1) * (param % 2) + ar.GetLength(0) * ((param + 1) % 2) - (param / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            param++;
        }

        col += dx;
        row += dy;
    }
    return ar;
}


Console.WriteLine("Введите количество строк матрицы");
int row = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов матрицы");
int col = int.Parse(Console.ReadLine()!);

string[,] array = CreateMatrix(row, col);
PrintArr(array);
string[,] spiral = GetSpiral(array);
PrintArr(spiral);