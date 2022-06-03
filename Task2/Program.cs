Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите 2 числа");
string? input1 = Console.ReadLine();
string? input2 = Console.ReadLine();

try
{
    int x = Convert.ToInt32(input1);
    int y = Convert.ToInt32(input2);

    if (x != 0 && y != 0)
    {
        int nod = Nod(x, y);
        int nok = Math.Abs(x * y) / nod;
        Console.WriteLine($"НОД равен: {nod}, НОК равен: {nok}");
    }
    else
    {
        Console.WriteLine("Введенные числа должны быть отличны от 0");
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

int Nod(int x, int y)
{
    x = Math.Abs(x);
    y = Math.Abs(y);

    while (y != 0)
    {
        int temp = y;
        y = x % y;
        x = temp;
    }

    return x;
}
