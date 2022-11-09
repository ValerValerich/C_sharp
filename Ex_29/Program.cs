// 29. Задает массив из 8 элементов, заполняемых пользователем и выводит его на экран

Console.Clear();

/*string GetArr(string x)
{

    int[] a = x.Split(' ').Select(int.Parse).ToArray();
   if (a.Length==8){
    string b = String.Join(",", a);
    return b;
   }
   else{
    return "Вы ввели не 8 элементов";
   }
    
}

Console.WriteLine("Введите 8 элементов массива через пробел");
Console.Write(GetArr(Console.ReadLine()!));*/

// не совсем ясно, если мы принимаем данные как массив, в сложность вывести этот же массив

int[] GetArr2()
{
    int[] arr=new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите элемент №{i+1}");
        arr[i]=int.Parse(Console.ReadLine()!);
    }
    return arr;
}

Console.WriteLine("Введите 8 чисел чтобы заполнить массив");
Console.WriteLine(String.Join(",", GetArr2()));