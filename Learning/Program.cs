/*int fib4 = Fibonachi(4);
int fib5 = Fibonachi(5);
int fib6 = Fibonachi(6);
Console.WriteLine($"4 число Фибоначчи = {fib4}");
Console.WriteLine($"5 число Фибоначчи = {fib5}");
Console.WriteLine($"6 число Фибоначчи = {fib6}");

    static int Fibonachi(int n)
    {
        if (n == 0 || n == 1) return n;

        int f1 = Fibonachi(n - 1);
        int f2 = Fibonachi(n - 2);
        return f1 + f2;
    }*/
class Program
{
    static void Main()
    {
        FindSmallKata.FindSmallestInt(new int[] { 78, 56, 232, 12, 11, 43 });
    }
}