namespace sevenkyu;

    [TestFixture]
    public class RecursionFactorialTests
    {
        [Test]
        [TestCase(1u, 0u)]
        [TestCase(1u, 1u)]
        [TestCase(2u, 2u)]
        [TestCase(6u, 3u)]
        public void BasicTests(ulong expected, ulong input)
        {
            Assert.AreEqual(expected, RecursionFactorial.Factorial(input));
        }
    }
