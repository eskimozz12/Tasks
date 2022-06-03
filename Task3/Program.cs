Console.WriteLine("Введите предложение");
string sentence = Console.ReadLine();

int value = Value();
string sort = Sort();
string capital = FirstUpper();

Console.WriteLine($"Количество слов в предложении: {value}");
Console.WriteLine();
Console.WriteLine($"Слова отсортированные по алфавиту \n{sort}");
Console.WriteLine();
Console.WriteLine($"Каждое слово с заглавной \n{capital}");



int Value()
{
    string str = RemoveChars(sentence);
    string[] s = str.Split(' ');
    int value = s.Length;
    return value;
    
}
String Sort()
{
    string sort = RemoveChars(sentence);
    sort = string.Join(" ", sort.Split().OrderBy(x=>x));

    return sort;
}
String FirstUpper()
{
    string str = RemoveChars(sentence);
    string[] s = str.Split(' ');

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length > 1)
            s[i] = s[i][..1].ToUpper() + s[i][1..].ToLower();
        else s[i] = s[i].ToUpper();
    }
    return string.Join(" ", s);


}

String RemoveChars(string str)
{
    for (int ctr = 0; ctr < str.Length; ctr++)
    {
        if (Char.IsPunctuation(str[ctr]))
            str = str.Replace(str[ctr], ' ');
    }
    string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    str = string.Join(" ", words);

    return str;
}
