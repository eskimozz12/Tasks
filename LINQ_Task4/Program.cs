List<Entry> entries = new List<Entry>()
 {
        new Entry("Иван", "313131",false),
        new Entry("Данил", "8(925)795-6505",true),
        new Entry("Сергей", "8(924)794-6404",true),
        new Entry("Алексей", "313131",false),
        new Entry("Владимир", "313131",false),
        new Entry("александр", "8(923)793-6303",true),
        new Entry("Владислав", "313131",false),
        new Entry("Олег", "8(922)792-6202",true),
        new Entry("володя", "8(922)792-6202",true),
        new Entry("кирилл", "8(922)792-6202",true),
        new Entry("Артем", "8(922)792-6202",true),
        new Entry("виталик", "8(922)792-6202",true),
        new Entry("Павел", "313131",false)
 };


var selectedPeople = entries.Where(t => t.IsPortable).OrderBy(t => t.Name, new CaseInsensitiveComparer()).Select((n, i) => new {Pos =  i + 1, Value = n}).Select(x=>x.Pos +") "+x.Value.Name +" - " + x.Value.Phone);
foreach (var entry in selectedPeople)
{
    Console.WriteLine(entry);
}

class Entry
{

    public string Name { get; set; }
    public string Phone { get; set; }
    public bool IsPortable { get; set; }
    
    public Entry(string name, string phone, bool isPortable)
    {
        Name = name;
        Phone = phone;
        IsPortable = isPortable;
    }
 

}

class CaseInsensitiveComparer : IComparer<String>
{
    public int Compare(string? x, string? y)
    {
        return string.Compare(x, y, StringComparison.CurrentCultureIgnoreCase);
    }
}