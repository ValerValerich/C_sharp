// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

if (a*a==b || b*b==a){
    Console.WriteLine("Одно - квадрат другого");
}
else{
    Console.WriteLine("Ни одно число не является квадратом другого");
}