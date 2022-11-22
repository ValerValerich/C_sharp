// 57. Составить частотный словарь элементов двумерного массива. 

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

void CountNums(int[,] ar)
{
    List<int> lst = new List<int>(); // Создаем отсортированный список уникальных символов
    foreach (int el in ar)
    {
        if (lst.Contains(el) == false)
        {
            lst.Add(el);
        }
    }
    lst.Sort();

    foreach (int item in lst) // Берем элемент из отсортированного списка и проверяем наш массив на совпадения. Записываем количество совпадений в счетчик
    {
        int cnt = 0;
        foreach (int el in ar)
        {
            if (item == el)
            {
                cnt++;
            }
        }
        Console.WriteLine($"Элемент {item} встречается {cnt} раз");
    }
}



Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);

int[,] Array = GetAr(row, col);
PrintArr(Array);
CountNums(Array);