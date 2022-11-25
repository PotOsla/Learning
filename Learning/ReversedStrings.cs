using System;
using System.Collections.Generic;
using System.Collections.Immutable;

public static class ReversedStrings

{
    public static string Solution(string str)
    {
        string rts = "";
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        foreach (var lit in chars)
            rts += lit.ToString();
        return rts;
    }
}