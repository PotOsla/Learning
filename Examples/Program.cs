void Sum(int[] numbers, int initialValue)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum(nums, 10);