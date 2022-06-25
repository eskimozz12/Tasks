try
{
    int x = Convert.ToInt32(Console.ReadLine());
    int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
        var reuslt = source.Take(n);
        var result1 = source.Skip(n);
        var result3 = result1.Concat(reuslt);
        return result3;
    }
}
