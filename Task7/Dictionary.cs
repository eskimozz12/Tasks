using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task7
{
    internal class Dictionary
    {
            Dictionary<UInt32, string> openWith =
        new Dictionary<UInt32, string>();
        internal void Result()
        {
            openWith = Numbers();
            string result1 = Checker(Middle);
            Console.WriteLine($"Время поиска элемента Dictionary в середине: {result1}");
            string result2 = Checker(Last);
            Console.WriteLine($"Время поиска последнего элемента Dictionary: {result2}");
            string result3 = Delete();
            Console.WriteLine($"Время удаления последнего элемента Dictionary: {result3}");
        }
        internal Dictionary<UInt32, string> Numbers()
        {
            Dictionary<UInt32, string> numbers= new();
            for (uint i = 1; i <= 10000000; i++)
            {
                numbers.Add(i,"txt");
            }
            return numbers;
        }


        bool Middle(Dictionary<UInt32, string> list)
        {
            if (list.ContainsKey(5000000)) return true;
            else return false;
        }
        bool Last(Dictionary<UInt32, string> list)
        {
            if (list.ContainsKey(10000000)) return true;
            else return false;
        }
        string Checker(Check ch)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 3000; i++)
            {
                ch(openWith);
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
            for (uint i = 10000000; i < 9900000; i--)
            {
                openWith.Remove(i);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }

        delegate bool Check(Dictionary<UInt32, string> list);

    }
}
