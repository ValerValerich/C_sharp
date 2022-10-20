// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double getL(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

Console.Clear();

Console.WriteLine("Введите х, y и z первого числа через пробел");
int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("Введите х, y и z второго числа через пробел");
int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();


Console.WriteLine($"{getL(a[0], a[1], a[2], b[0], b[1], b[2]):f2}");