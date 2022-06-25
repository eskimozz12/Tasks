
try
{
    Console.WriteLine("Введите число факториалов");
    Factorials check = new Factorials { Checker = Convert.ToInt32(Console.ReadLine()) };
    Console.WriteLine();
    int x = check.Checker;
    var numbers = check.Fact().Take(x);
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }


}
catch (NumberException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Введите число");
}

class Factorials
{
    public int checker { get; set; } = 0;
    public int Checker
    {
        get => checker;
        set
        {
            if (value >= 17 || value <= 0) throw new NumberException("Введенное число должно быть больше 0 и меньше 17");
            else checker = value;
        }

    }

    public IEnumerable<int> Fact()
    {
        int sum = 1;
        for (int i = 2; ; i++)
        {
            yield return sum;
            sum *= i;
        }
    }
}


class NumberException : Exception
{
    public NumberException(string message)
        : base(message) { }
}