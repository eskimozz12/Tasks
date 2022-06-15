using Task6;

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
        Console.WriteLine($"Название: {i.Name}\n Вес: {i.Weight.ToString()}\n Цена: {i.Cost.ToString()}");
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
