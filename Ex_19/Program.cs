// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

string itsTrue(int num)
{
    if (num > 9999 && num < 100000)
    {
        int figure1 = num / 10000;
        int figure2 = num / 1000 % 10;
        int figure4 = num / 10 % 10;
        int figure5 = num % 10;

        if (figure1 == figure5 && figure2 == figure4)
        {
            return num + " - это палиндром";
        }
        else
        {
            return num + " - не палиндром";
        }
    }
    else
    {
        return "Число не соответствует условию";
    }
}

Console.WriteLine("Ввдите пятизначное число");
Console.WriteLine(itsTrue(int.Parse(Console.ReadLine()!)));