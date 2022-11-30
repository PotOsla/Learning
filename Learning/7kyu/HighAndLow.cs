using System.Linq;


public static class HighAndLowKata
{
    public static string HighAndLow(string numbers)
    {
        var ints = numbers.Split(' ').Select(int.Parse).ToArray();
        int max = ints[0];
        for (int i = 0; i < ints.Length; i++)
        {
            if (max < ints[i])
            {
                max = ints[i];
            }
        }
        string strmax = max.ToString();

        int min = ints[0];
        for (int i = 0; i < ints.Length; i++)
        {
            if (min > ints[i])
            {
                min = ints[i];
            }
        }
        string strmin = min.ToString();
        string str = strmax + " " +strmin;
        return str;
    }
}