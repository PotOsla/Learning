internal class Program
{
    private static void Main(string[] args)
    {
        CustomMath math = new CustomMath();
        int result = CustomMath.multiply(2, 6);
        Console.WriteLine(result);
    }
}