public class Benford
{
    public static int[] GetBenfordStatistics(string text)
    {
        var statistics = new int[10];
        string[] temp;
        temp = text.Split(' ');
        foreach (var word in temp)
        {
            foreach (var letter in word)
            {
                bool check = char.IsNumber(letter);
                if (check)
                {
                    int numbersint = int.Parse(letter.ToString());
                    statistics[numbersint]++;
                    
                }
                break;
            }
        }
        return statistics;
    }
}