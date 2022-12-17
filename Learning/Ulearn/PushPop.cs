using System.Numerics;
using System.Text;

public class PushPop
{
    public static string ApplyCommands(string[] commands)
    {
        var builder = new StringBuilder();
        foreach (string line in commands)
        {
            if (line.StartsWith("push"))
            {
                var IndexOfChar = line.IndexOf(' ');
                builder.Append(line.Substring(IndexOfChar+1));
            }
            else if (line.StartsWith("pop"))
            {
                int count = int.Parse(line.Remove(0, 4));
                builder.Remove(builder.Length-count, count);
            }
        }
        return builder.ToString().Trim();
    }
}