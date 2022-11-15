// 45. Создавать копию заданного масива поэлементным копированием

Console.Clear();

int[] resArr(int[] arr){
    int[]res=new int[arr.Length];
    for (int i=0; i<arr.Length; i++){
        res[i]=arr[i];
    }
    return res;
}

Console.WriteLine("Введите элементы массива через пробел");
Console.WriteLine(String.Join(',', resArr(Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray())));