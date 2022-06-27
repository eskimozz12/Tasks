int i = 1;
List<Entry> entries = new List<Entry>()
 {
        new Entry("Иван", "313131",false),
        new Entry("Данил", "8(925)795-6505",true),
        new Entry("Сергей", "8(924)794-6404",true),
        new Entry("Алексей", "313131",false),
        new Entry("Владимир", "313131",false),
        new Entry("Александр", "8(923)793-6303",true),
        new Entry("Владислав", "313131",false),
        new Entry("Олег", "8(922)792-6202",true),
        new Entry("Павел", "313131",false)
 };

var selectedPeople = entries.Where(t => t.IsPortable == true).OrderBy(t => t.Name);
foreach (Entry entry in selectedPeople)
{
    Console.WriteLine($"{i}) {entry.Name} - {entry.Phone}");
    i++;
}

class Entry
{

    public string Name { get; set; }
    public string Phone { get; set; }
    public bool IsPortable { get; set; }
    
    public Entry(string name, string phone, bool IsPortable)
    {
        Name = name;
        Phone = phone;
        this.IsPortable = IsPortable;
    }
 

}

