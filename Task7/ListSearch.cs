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
        ListsForSort lists = new ListsForSort();

        
        internal void Result()
        {
            numbers = Numbers();
            string result1 = Checker(Middle);
            Console.WriteLine($"Время поиска элемента List в середине: {result1}");
            string result2 = Checker(Last);
            Console.WriteLine($"Время поиска последнего элемента List: {result2}");
            string result3 = Add();
            Console.WriteLine($"Время добавления элемента List: {result3}");
            string result4 = Delete();
            Console.WriteLine($"Время удаления элемента List: {result4}");

            string result5 = AddInsert();
            Console.WriteLine($"Время вставления элемента List вначало Insert'ом: {result5}");
            string result6 = Remove();
            Console.WriteLine($"Время удаления элемента List вначалe Remove'ом: {result6}");
            {
                string result7 = Sorting(lists.List500000);
                Console.WriteLine($"Время сортировки List 5000 значений методом Sort: {result7}");
                string result8 = Sorting(lists.List1000000);
                Console.WriteLine($"Время сортировки List 10000 значений методом Sort: {result8}");
                string result9 = Sorting(lists.List1500000);
                Console.WriteLine($"Время сортировки List 15000 значений методом Sort: {result9}");

            }
            string result10 = Checker(BinResearch);
            Console.WriteLine($"Время поиска элемента посередине BinSearch: {result10}");

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
            return list.Contains(5435435);
        }
        bool Last(List<Int32> list)
        {
            return list.Contains(10000000);
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
        internal string AddInsert()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                numbers.Insert(0,1);
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
        string Remove()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                numbers.RemoveAt(0);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }
        string Sorting(Sort ch)
        {
            var numbers = ch();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            numbers.Sort();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }
        bool BinResearch(List<Int32> list)
        {
            int x = list.BinarySearch(5435435);
            return (x == 5435435 - 1);
        }

        internal delegate bool Check(List<Int32> list);
        internal delegate List<Int32> Sort();
    }
}
