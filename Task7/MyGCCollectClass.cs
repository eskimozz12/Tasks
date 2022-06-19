using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class MyGCCollectClass
    {
        ListSearch list = new ListSearch();
        internal void Garbage()
        {
            Console.WriteLine("Размер памяти в байтах до вызова метода Insert {0}", GC.GetTotalMemory(false));
            string result1 = list.AddInsert();
            Console.WriteLine("Размер памяти в байтах после вызова метода Insert {0}", GC.GetTotalMemory(false));
        }

    }
}
