// 40. Принимает на вход три числа и проверяет, может ли существовать треугольник с такими сторонами

Console.Clear();

string CheckTri(int a, int b, int c)
{
    string res = "Нет такого треугольника";
    if (a > 0 || b > 0 || c > 0)
    {
        if (a < b + c && b < a + c && c < a + b)
        {
            res = "Есть такой треугольник";
        }
    }
    return res;
}

Console.WriteLine("Введите длины треугольника для проверки через пробел");
int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Console.WriteLine(CheckTri(arr[0], arr[1], arr[2]));
