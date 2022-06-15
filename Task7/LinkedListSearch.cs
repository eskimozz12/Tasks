using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task7
{
    internal class LinkedListSearch
    {
        LinkedList<Int32> numbers = new();

        internal void Result()
        {
            numbers = Numbers();
            string result1 = Checker(Middle);
            Console.WriteLine($"Время поиска элемента LinkedList в середине: {result1}");
            string result2 = Checker(Last);
            Console.WriteLine($"Время поиска последнего элемента LinkedList: {result2}");
            string result3 = Add();
            Console.WriteLine($"Время добавления элемента LinkedList: {result3}");
        }
        LinkedList<Int32> Numbers()
        {
            LinkedList<Int32> numbers = new();
            for (int i = 1; i <= 10000000; i++)
            {
                numbers.AddLast(i);
            }
            return numbers;
        }


        bool Middle(LinkedList<Int32> list)
        {
            if (list.Contains(5000000)) return true;
            else return false;
        }
        bool Last(LinkedList<Int32> list)
        {
            if (list.Contains(10000000)) return true;
            else return false;
        }
        string Checker(Check ch)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 3000; i++)
            {
                ch(numbers);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;

        }
        string Add()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                numbers.AddLast(1);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }

        delegate bool Check(LinkedList<Int32> list);

    }
}
