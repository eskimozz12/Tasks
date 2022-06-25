static IEnumerable<int> Fact()
{
    for (int i = 1; i <=10; i++)
    {
        yield return Enumerable.Range(1, i).Aggregate(1, (acc, x) => acc * x);
    }
}

var numbers = Fact();
foreach(var number in numbers)
{
    Console.WriteLine(number);
}
