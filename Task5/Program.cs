int[] vs = new int[100];
Random random = new Random();

for (int i = 0; i < vs.Length; i++)
{
    vs[i] = i;
    Console.WriteLine(vs[i]);
}
Console.WriteLine("----------------------");
for (int i = 0;i < vs.Length; i++)
{
    if (isPal(vs[i]))
    {
        Console.WriteLine(vs[i]);
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

