namespace sevenkyu;
[TestFixture]
public class DescendingOrderTests
{
    [Test]
    [TestCase(0,0)]
    [TestCase(54421, 42145)]
    [TestCase(654321, 145263)]
    [TestCase(987654321, 123456789)]
    public void Test(int output, int input )
    {
        Assert.AreEqual(output, DescendingOrderKata.DescendingOrder(input));
    }
}