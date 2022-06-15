using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Item
    {
        public string name { get; set; }
        public double cost { get; set; }
        public double weight { get; set; }

        public Item(string name, double weight, double cost)
        {
            this.name = name;
            this.cost = cost;
            this.weight = weight;
        }
    }
}
