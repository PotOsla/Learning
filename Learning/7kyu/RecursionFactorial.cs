public class RecursionFactorial
{
    public static ulong Factorial(ulong n)
    {
        checked
        {
            if (n == 1 || n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}