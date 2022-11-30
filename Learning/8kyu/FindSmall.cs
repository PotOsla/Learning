public class FindSmallKata
{
    public static int FindSmallestInt(int[] args)
    {
        int min = args[0];
        for (int i = 0; i < args.Length; i++)
        {
            if (min > args[i])
            {
                min = args[i];
            }
        }
        return min;
    }
}