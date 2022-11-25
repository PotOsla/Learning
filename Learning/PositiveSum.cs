using System;
using System.Linq;

public class PositiveSumKata
{
    public static int PositiveSum(int[] arr)
    {
        int sum = 0;
        foreach (int number in arr)
        {
            if (number >= 0)
                sum += number;
        }
        return sum;
    }
}