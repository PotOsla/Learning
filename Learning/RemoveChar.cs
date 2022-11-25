using System;

public class RemoveCharKata
{
    public static string Remove_char(string s)
    {
        string cutstr = "";
        char[] chars = s.ToCharArray();
        for (int i=1; i < chars.Length-1; i++)
        {
            cutstr += chars[i];
        }
       // foreach (var lit in chars)
       //     cutstr += lit.ToString();
        return cutstr;
    }
}