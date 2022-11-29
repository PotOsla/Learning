namespace eightkyu;
[TestFixture]
public class RemoveCharTest
{
    [Test]
    public void Test1()
    {
        StringAssert.AreEqualIgnoringCase("loquen", RemoveCharKata.Remove_char("eloquent"));
        StringAssert.AreEqualIgnoringCase("ountr", RemoveCharKata.Remove_char("country"));
        StringAssert.AreEqualIgnoringCase("erso", RemoveCharKata.Remove_char("person"));
        StringAssert.AreEqualIgnoringCase("lac", RemoveCharKata.Remove_char("place"));
        StringAssert.AreEqualIgnoringCase("", RemoveCharKata.Remove_char("ok"));
    }
}