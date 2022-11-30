using System;
using System.Linq;
public static class DescendingOrderKata
{
    public static int DescendingOrder(int num)
    {
        int[] order = num.ToString().Select(Parse).ToArray();
        int temp;
        for (int i = 0; i < order.Length-1; i++)
        {
            for(int j = i + 1; j < order.Length; j++ )
            {
                if (order[i] < order[j])
                {
                    temp = order[i];
                    order[i] = order[j];
                    order[j] = temp;
                }
            }
        }
        string strorder = string.Concat(order);
        int intorder = int.Parse(strorder);
        return intorder;

    }
    public static int Parse(char a)
    {
        return int.Parse(a.ToString());
    }
}
