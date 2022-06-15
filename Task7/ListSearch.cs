using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task7
{
    internal class ListSearch
    {
        List<Int32> numbers = new(10000000);
        
        internal void Result()
        {
            numbers = Numbers();
            string result1 = Checker(Middle);
            Console.WriteLine($"Время поиска элемента List в середине: {result1}");
            string result2 = Checker(Last);
            Console.WriteLine($"Время поиска последнего элемента List: {result2}");
            string result3 = Add();
            Console.WriteLine($"Время добавления элемента List: {result3}");
            string result4 = Add();
            Console.WriteLine($"Время удаления элемента List: {result4}");
        }  
        List<Int32> Numbers()
        {
            List<Int32> numbers = new(10000000);
            for (int i = 1; i <= numbers.Capacity; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }


        bool Middle(List<Int32> list)
        {
            if (list.Contains(5000000)) return true;
            else return false;
        }
        bool Last(List<Int32> list)
        {
            if (list.Contains(10000000)) return true;
            else return false;
        }
        string Checker(Check ch)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10000; i++)
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
                numbers.Add(1);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }
        string Delete()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 10000000; i < 9900000; i--)
            {
                numbers.Remove(i);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }

        internal delegate bool Check(List<Int32> list);
    }
}
