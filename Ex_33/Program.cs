// 33. Задайте массив. Определите, есть ли заданное число в массиве.

Console.Clear();

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

void FindInt(int[] arr, int x)
{
    string answer = "NO";
    foreach (int el in arr)
    {
        if (el == x)
        {
            answer = "YES";
            break;
        }
    }
    Console.WriteLine(answer);
}

Console.WriteLine("Введите длинну массива");
int len=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите MIN");
int mi=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите MAX");
int ma=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число для поиска");
int findnum=int.Parse(Console.ReadLine()!);
FindInt(GetArray(len, mi, ma), findnum);