public class SplitAndJoin
{
    public static string ReplaceIncorrectSeparators(string text)
    {
        string[] temp = text.Split(new char[] { ' ', '!', ',', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
        string temptemp = string.Join("\t", temp);
        return temptemp;
    }
}