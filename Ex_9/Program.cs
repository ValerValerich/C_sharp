// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

int num = new Random().Next(10, 100);


int first = num / 10;
int second = num % 10;

if (first>second){
    Console.WriteLine($"Максимальная цифра в числе {num} -> {first}");
}
else{
    Console.WriteLine($"Максимальная цифра в числе {num} -> {second}");
}