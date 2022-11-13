// 32. Замена элементов массива. Положительные на отрицательные и наоборот.

Console.Clear();

int[] ReplaecNums(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*=-1;
    }
    return arr;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(',', res));
    return res;
}

Console.WriteLine("Введите размер массива");
int size=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите MIN");
int minim=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите MAX");
int maxim=int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(',', ReplaecNums(GetArray(size, minim, maxim))));
