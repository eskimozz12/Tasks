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
    string[] s = RemoveChars(sentence);
    int value = s.Length;
    return value;
    
}
String Sort()
{
    sort = string.Join(" ", RemoveChars(sentence).OrderBy(x=>x));
    return sort;
}
String FirstUpper()
{
    string[] s = RemoveChars(sentence);

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length > 1)
            s[i] = s[i].Substring(0,1).ToUpper() + s[i].Substring(1).ToLower();
        else s[i] = s[i].ToUpper();
    }
    return string.Join(" ", s);


}

String[] RemoveChars(string str)
{
 
    string[] words = str.Split(new char[] { '.', ',', '!', '?', ';', ':', '-',' '}, StringSplitOptions.RemoveEmptyEntries);
    return words;
}
