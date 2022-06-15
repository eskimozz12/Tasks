using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Item
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Weight { get; set; }

        public Item(string name, double weight, double cost)
        {
            this.Name = name;
            this.Cost = cost;
            this.Weight = weight;
        }
    }
}
