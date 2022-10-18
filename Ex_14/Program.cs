// Напишите программу, которая принимает на вход число и проверят, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.WriteLine("Введите число для проверки");
int num = int.Parse(Console.ReadLine()!);

if (num%7==0 && num%23==0){
    Console.Write("ДА");
}
else{
    Console.Write("НЕТ");
}