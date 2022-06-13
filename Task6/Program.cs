Console.WriteLine("Введите вес рюкзака");
double w = Convert.ToDouble(Console.ReadLine());
List<Item> items;
AddItems();
Console.WriteLine("\nДоступные вещи:");
ShowItems(items);
Solution(w);



void AddItems()
{
    items = new List<Item>
    {
        new Item("Мышка", 5, 1000),
        new Item("Клавиатура", 6, 2000),
        new Item("Коврик", 3, 500),
        new Item("Микрофон", 7, 1500),
        new Item("Вебка", 2, 4000)
    };
}

void ShowItems(List<Item> items)
{
    foreach (Item i in items)
    {
        Console.WriteLine($"Название: {i.name}\n Вес: {i.weight.ToString()}\n Цена: {i.cost.ToString()}");
    }
    Console.WriteLine();
}

void Solution(double w)
{
    Backpack bp = new Backpack(w);
    bp.Options(items);
    List<Item>? solve = bp.GetBestOption();
    if(solve == null)
    {
        Console.WriteLine("Решения нет");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Полученнное решение:");
        ShowItems(solve);
    }

}


class Item
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
class Backpack
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
        foreach(Item i in items)
        {
            costSum += i.cost;
        }
        return costSum;
    }
    private void Checker(List<Item> items)
    {
        if (bestItems == null)
        {
            if(CalcWeight(items) <= maxWeight)
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
        if(items.Count > 0)
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