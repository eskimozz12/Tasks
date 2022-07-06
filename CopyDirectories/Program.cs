string? dirName = @"C:\Users\pasha\Desktop\from";
string? newPath = @"C:\Users\pasha\Desktop\to\";

CopyFiles(dirName, newPath);

void CopyFiles(string oldPath, string newPath)
{
    if (Directory.Exists(oldPath))
    {

        string[] files = Directory.GetFiles(oldPath);

        foreach (string s in files)
        {
            FileInfo fileInf = new FileInfo(s);
            string tmp = fileInf.Name;
            Console.WriteLine(tmp);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath + tmp);
            }
        }
    }
}