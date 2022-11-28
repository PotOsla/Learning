using System;

namespace Solution
{
    public static class StringRepeatKata
    {
        public static string RepeatStr(int n, string s)
        {
              string m = "";
              for(int i=1; i<=n; i++)
              {
                  m = m + s;
              }
              return m;
             // return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}