namespace eightkyu;
    [TestFixture]
  public class ReversedStringsTests
  {
    [Test]
    [TestCase("dlrow","world")]
    [TestCase("","")]
    public void World(string text, string expected)
    {
      Assert.That(ReversedStrings.Solution(text), Is.EqualTo(expected));
    }
  }