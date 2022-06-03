Console.WriteLine("Введите текст");
string sentence = Console.ReadLine();
Console.WriteLine("Введите слово для поиска");
string substr = Console.ReadLine();
int count = Search(substr);
Console.WriteLine($"Количество совпадений в предложенмм: {count} ");



int Search(string substr)
{
    int count = 0;
    string str = RemoveChars(sentence);
    string[] words = str.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        if(words[i].Equals(substr, StringComparison.OrdinalIgnoreCase))
{
            count++;
        }
    }
    
    return count;

}

String RemoveChars(string str)
{
    string result = str;
    for (int ctr = 0; ctr < result.Length; ctr++)
    {
        if (Char.IsPunctuation(result[ctr]))
            result = result.Replace(result[ctr], ' ');
    }
    string[] words = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    result = string.Join(" ", words);

    return result;
}
