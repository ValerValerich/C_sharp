// 38. Задать массив вещественных чисел. Найти разницу между минимальным и максимальным

Console.Clear();

double[] GetArray(int size = 7, double minValue = 1.0, double maxValue = 10.0) // Указываю условия здесь, потому что надоело каждый раз вводить с консоли
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble() * (maxValue), 3);
    }
    Console.WriteLine(String.Join(' ', res));
    return res;
}

double findMinMaxDiff(double[] arr)
{
    double minVal = arr[0];
    double maxVal = arr[0];
    foreach (double el in arr)
    {
        minVal = el < minVal ? el : minVal;
        maxVal = el > maxVal ? el : maxVal;
    }
    return Math.Round(maxVal - minVal, 3);
}

Console.WriteLine(findMinMaxDiff(GetArray()));