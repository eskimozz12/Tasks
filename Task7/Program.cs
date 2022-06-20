using System.Diagnostics;
using Task7;

ListSearch list = new();
list.Result();
Console.WriteLine("----------------------");
LinkedListSearch linkedList = new();
linkedList.Result();
Console.WriteLine("----------------------");
Dictionary dictionary = new();
dictionary.Result();
Console.WriteLine("----------------------");
MyGCCollectClass mGCCol = new();
mGCCol.Garbage();

