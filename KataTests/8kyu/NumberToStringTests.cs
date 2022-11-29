namespace eightkyu;
    [TestFixture]
    public class NumberToStringTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(67).Returns("67");
                yield return new TestCaseData(79585).Returns("79585");
                yield return new TestCaseData(1 + 2).Returns("3");
                yield return new TestCaseData(1 - 2).Returns("-1");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int num) => NumberToStringKata.NumberToString(num);
    }