try
{
    int x = Convert.ToInt32(Console.ReadLine());
    int[] values = { 1, 2, 3, 4, 5, 6 };
    var rotates = values.Rotate(x);
    Console.WriteLine();
    foreach (var rotate in rotates)
    {
        Console.WriteLine(rotate);
    }
}
catch (FormatException)
{
    Console.WriteLine("Введите число");
}

public static class LinqExtension
{
    public static IEnumerable<int> Rotate(this IEnumerable<int> source, int n)
    {
        
        while (n > source.Count())
        {
            n -= source.Count();
        }
        var result = source.Take(n);
        var result1 = source.Except(result).Concat(result);
        return result1;
    }
}
