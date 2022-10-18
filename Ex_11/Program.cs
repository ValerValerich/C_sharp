// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);


int first = num / 100 * 10;
int second = num % 10;

Console.Write($"Число {num} превращаем в {first+second}");
