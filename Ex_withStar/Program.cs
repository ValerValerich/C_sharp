// Со звездочкой. Принимает число - высоту ёлочки и рисует ее в консоли звездочками

Console.Clear();

void PaintWood()
{
    int x = int.Parse(Console.ReadLine()!);
    char[] a = new char[x * 2 - 1];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = ' ';
    }
    for (int i = 0; a[0] != '*'; i++)
    {

        a[a.Length / 2 + i] = '*';
        a[a.Length / 2 - i] = '*';
        Console.WriteLine(String.Join("", a));
    }
}

Console.WriteLine("Введите число - высоту ёлочки");
PaintWood();




