// 35. Задать одномерный массив из 123 чисел. Найти количество элементов, значения которых [10, 99]

Console.Clear();

int[] GetArray(int size = 123, int minValue=-1000, int maxValue=1000)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(',', res));
    return res;
}

void findNum(int[] arr)
{
    int cnt = 0;
    foreach(int i in arr){
        if (i>=10 && i<=99)
        {
            cnt+=1;
        }
    }
    Console.WriteLine(cnt);
}

Console.WriteLine("Сейчас будет создан массив из 123 символов");
findNum(GetArray());