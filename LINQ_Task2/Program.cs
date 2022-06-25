try
{
    int x = Convert.ToInt32(Console.ReadLine());
    int[] values = { 1, 3, 4, 4, 5, 6 };
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
        n = n % source.Count();
        if (n == 0) return source;
        else return source.Skip(n).Concat(source.Take(n));
    }
}
