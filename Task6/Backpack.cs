using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task6
{
    internal class Backpack
    {
        private List<Item>? bestItems = null;
        private double maxWeight;
        private double bestCost;
        public Backpack(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        private double CalcWeight(List<Item> items)
        {
            double weightSum = 0;
            foreach (Item i in items)
            {
                weightSum += i.weight;
            }
            return weightSum;
        }
        private static double CalcCost(List<Item> items)
        {
            double costSum = 0;
            foreach (Item i in items)
            {
                costSum += i.cost;
            }
            return costSum;
        }
        private void Checker(List<Item> items)
        {
            if (bestItems == null)
            {
                if (CalcWeight(items) <= maxWeight)
                {
                    bestItems = items;
                    bestCost = CalcCost(items);
                }
            }
            else
            {
                if (CalcWeight(items) <= maxWeight && CalcCost(items) > bestCost)
                {
                    bestItems = items;
                    bestCost = CalcCost(items);
                }
            }
        }
        public void Options(List<Item> items)
        {
            if (items.Count > 0)
            {
                Checker(items);
            }
            for (int i = 0; i < items.Count; i++)
            {
                List<Item>? newOption = new List<Item>(items);
                newOption.RemoveAt(i);
                Options(newOption);
            }
        }
        public List<Item>? GetBestOption()
        {
            return bestItems;
        }
    }
}
