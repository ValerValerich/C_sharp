// 48. Задайте двумерный массив размера М на Н, каждый элемент в массиве находится по формуде Амн=М+Н. Вывести

Console.Clear();

int[,] GetArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = j + i;
        }
    }
    return arr;
}
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

void PrintArr(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j]} \t");
        }
        Console.WriteLine();
    }

}
PrintArr(GetArray(m, n));