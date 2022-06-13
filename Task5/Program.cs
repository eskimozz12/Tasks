try
{
    Console.WriteLine("Введите количество чисел");
    uint n = Convert.ToUInt32(Console.ReadLine());
    List<Int32> list = new List<Int32>();
    if (n <= 100)
    {
        int[] array = new int[n];
        Console.WriteLine("Введите числа");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        list = Palindrom(array);
        Console.WriteLine("Числа палиндромы:");
        foreach(Int32 i in list) { Console.WriteLine(i); }


    }
    else Console.WriteLine("Количество чисел не должно превышать 100");

}
catch (FormatException)
{
    Console.WriteLine("Введите число");
}
catch (OverflowException)
{
    Console.WriteLine("Размерность последовательности должна являться неотрицательным числом");
}


List<Int32> Palindrom(int[] arr)
{
    List<Int32> list = new List<Int32>();   
    int n2;
    int digit;
    int k;
    for (int i = 0;i < arr.Length; i++)
    {
        n2 = 0;
        k = arr[i];
        while (k > 0)
        {
            digit = k % 10;
            k /= 10;
            n2 = n2 * 10 + digit;
         
        }
        if (n2 == arr[i])
        {
            list.Add(arr[i]);
        }
    }
    return list;
} 

