// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

double getL(double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}

Console.Clear();

Console.WriteLine("Введите х первого числа");
double X1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите у первого числа");
double Y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите х второго числа");
double X2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите у второго числа");
double Y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"{getL(X1, Y1, X2, Y2):f2}");