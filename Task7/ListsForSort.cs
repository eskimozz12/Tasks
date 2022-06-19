using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class ListsForSort
    {
        Random random = new Random();
        internal List<Int32> List500000()
        {
            List<Int32> vs = new List<Int32>(500000);
            for (Int32 i = 0; i < vs.Capacity; i++)
            {
                vs.Add(random.Next(1, 1000));
            }
            return vs;
        }

            internal List<Int32> List1000000()
            {
                List<Int32> vs = new List<Int32>(1000000);
                for (Int32 i = 0; i < vs.Capacity; i++)
                {
                    vs.Add(random.Next(1, 1000));
                }
                return vs;

            }
            internal List<Int32> List1500000()
            {
                List<Int32> vs = new List<Int32>(1500000);
                for (Int32 i = 0; i < vs.Capacity; i++)
                {
                    vs.Add(random.Next(1, 1000));
                }
                return vs;
            }
        
    }
}
