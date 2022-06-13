using System.Diagnostics;


List<Int32> numbers = new List<Int32>();
numbers = Numbers();
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Search(numbers);
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;

string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);



void Search(List<Int32> list)
{
    int target = 6;

    bool isExist = list.Contains(target);
    if (isExist)
    {
        Console.WriteLine("Element found in the list");
    }
    else
    {
        Console.WriteLine("Element not found in the given list");
    }
}
List<Int32> Numbers()
{
    int k = 1000000;
    Random random = new();
    List<Int32> numbers = new();
    for(int i = 0; i < k; i++)
    {
        numbers.Add(random.Next(1,10000));
    }
    return numbers;
}
