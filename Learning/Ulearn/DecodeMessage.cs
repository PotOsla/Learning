public class DecodeMessage 
{ 
    public static string Message(string[] lines)
    {
        List<string> words = new List<string>();
        string[] temp;
        foreach (string line in lines)
        {
            temp = line.Split(' ');
            foreach (string word in temp)
            {
                if (word.Length>=1 && char.IsUpper(word[0]))
                    {
                        words.Add(word);
                    }
            }
        }
        words.Reverse();
        string result = string.Join(" ", words);
        return result;
    }
}