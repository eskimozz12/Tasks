using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task7
{
    internal class MyGCCollectClass
    {
        ListSearch list = new();
        LinkedListSearch lList = new();
        Dictionary dictionary = new(); 
        List<Int32> tmp = new List<Int32>();
        LinkedList<Int32> tmp1 = new LinkedList<Int32>();
        Dictionary<UInt32,string> tmp2 = new Dictionary<UInt32,string>();
        long x;
        long y;
        long z;
        internal void Garbage()
        {
            x = GC.GetTotalMemory(true);
            Console.WriteLine("Размер памяти в байтах до вызова List {0}", x);
            tmp = list.Numbers();
            Console.WriteLine("Размер памяти в байтах который занимает List {0}", GC.GetTotalMemory(true) - x);

            y = GC.GetTotalMemory(true);
            Console.WriteLine("Размер памяти в байтах до вызова LinkedList {0}", y);
            tmp1 = lList.Numbers();
            Console.WriteLine("Размер памяти в байтах который занимает LinkedList {0}", GC.GetTotalMemory(true)-y);

            z = GC.GetTotalMemory(true);
            Console.WriteLine("Размер памяти в байтах до вызова метода Dictionary {0}", z);
            tmp2 = dictionary.Numbers();
            Console.WriteLine("Размер памяти в байтах который занимает Dictionary {0}", GC.GetTotalMemory(true) - z);

        }

    }
}
