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
        return cutstr;
    }
}