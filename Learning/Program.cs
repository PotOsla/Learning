internal class Program
{
    private static void Main(string[] args)
    {
        int a = 33;
        int b = 600;
        byte c = checked((byte)(a + b));
        CustomMath math = new CustomMath();
        int result = CustomMath.multiply(2, 6);
        Console.WriteLine(result);

    }
}