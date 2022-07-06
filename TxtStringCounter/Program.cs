string? path = @"C:\Users\pasha\Desktop\test.txt";
int x = GetLinesCount(path);
switch (x)
{
    case 0: Console.WriteLine("Неверно введен путь или пустой файл"); break;
    default: Console.WriteLine($"Количество строк в тексте: {x}"); break;
}
int GetLinesCount(string fileName)
{
    if (File.Exists(fileName))
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string? line;
            int x = 0;
            while ((line = reader.ReadLine()) != null)
            {
                x++;
            }
            return x;
        }
    }
    else return 0;
}
    
