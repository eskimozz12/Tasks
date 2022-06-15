Console.WriteLine("Числа палиндромы в последовательности от 0 до 100:");
for (int i = 0;i < 100; i++)
{
    if (isPal(i))
    {
        Console.WriteLine(i);
    }
} 


bool isPal(int x)
{
    int check = x;
    int digit = 0;
    int sum = 0;
    while (x > 0)
    {
        digit = x % 10;
        sum = (sum * 10) + digit;
        x /= 10;
    }
    if (check == sum) return true;
    else return false;
}

