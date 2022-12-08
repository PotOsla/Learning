using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        var filter = new List<int>();
        int temp;
        foreach (var i in listOfItems)
        {
            if (i is string) 
                 continue;
            temp = (int)i;
            filter.Add(temp);
        }
        return filter;
    }
}
