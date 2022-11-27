namespace Examples
{
    public class Item
    {
        public int Factorial(int n)
        {
            if (n == 1) 
                return 1;

            var t = Factorial(n - 1);

            return n * t;
        }
    }
}

