namespace Test2Library
{
    public class StringChecker
    {
        public int Value(string sentence)
        {
            string[] s = RemoveChars(sentence);
            int value = s.Length;
            return value;

        }
        public String Sort(string sentence)
        {
            string sort = string.Join(" ", RemoveChars(sentence).OrderBy(x => x));
            return sort;
        }
        public String FirstUpper(string sentence)
        {
            string[] s = RemoveChars(sentence);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1).ToLower();
                else s[i] = s[i].ToUpper();
            }
            return string.Join(" ", s);
        }
        public String[] RemoveChars(string str)
        {

            string[] words = str.Split(new char[] { '.', ',', '!', '?', ';', ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
    }
}
