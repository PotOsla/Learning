public static class VowelCountKata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string vowelsstr = "aeiou";
        char[] vowels = vowelsstr.ToCharArray();
        char[] chars = str.ToCharArray();
        foreach (char ch in chars)
        {
            foreach (char vl in vowels) {
                if (ch == vl)
                {
                    vowelCount++;

                }
            }
        }

        return vowelCount;
    }
}
    
    