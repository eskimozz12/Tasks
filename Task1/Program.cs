Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите число");
string? input = Console.ReadLine();

try
{
    int x = Convert.ToInt32(input);

    if (x % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }

    switch (IsPrime(x))
    {
        case NumberType.Prime:
            Console.WriteLine("Число простое");
            break;
        case NumberType.Composite:
            Console.WriteLine("Число составное");
            break;
        case NumberType.Other:
            Console.WriteLine("Введенное число не является простым или составным");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Введено неверное число");
}
catch (OverflowException)
{
    Console.WriteLine("Введено слишком большое число");
}

NumberType IsPrime(int x)
{
    if (x <= 1)
        return NumberType.Other;

    for (int i = 2; i < Math.Sqrt(x); i++)
    {
        if (x % i == 0)
            return NumberType.Composite;
    }

    return NumberType.Prime;
};

enum NumberType
{
    Prime,
    Composite,
    Other
}