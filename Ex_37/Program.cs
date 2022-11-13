// 37. Найти произведение пар чисел в одномерном массиве. Пара - первый и последний. Результат записать в новый массив.

Console.Clear();

int[] GetArray(int size = 6, int minValue = 1, int maxValue = 5)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(',', res));
    return res;
}

int[] newArr(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0)
    {
        size += 1;
    }
    int[] res = new int[size];

    for (int i = 0; i < arr.Length/2; i++)
    {
        res[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    
    if (arr.Length % 2 != 0)
    {
        res[size - 1] = arr[size-1];
    }
    return res;
}

Console.WriteLine(String.Join(' ', newArr(GetArray())));