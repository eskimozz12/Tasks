Console.WriteLine("Введите текст");
string sentence = Console.ReadLine();
Console.WriteLine("Введите слово для поиска");
string substr = Console.ReadLine();
int count = Search(substr);
Console.WriteLine($"Количество совпадений в предложенмм: {count} ");



int Search(string substr)
{
    int count = 0;
    string[] words = RemoveChars(sentence);
    for (int i = 0; i < words.Length; i++)
    {
        if(words[i].Equals(substr, StringComparison.OrdinalIgnoreCase))
{
            count++;
        }
    }
    
    return count;

}

String[] RemoveChars(string str)
{

    string[] words = str.Split(new char[] { '.', ',', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
    return words;
}