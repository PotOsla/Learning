namespace eightkyu;

    using NUnit.Framework;
    using System;

    [TestFixture]
    public class StringRepeatTest
    {
        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Assert.AreEqual("***", StringRepeatKata.RepeatStr(3, "*"));
            Assert.AreEqual("#####", StringRepeatKata.RepeatStr(5, "#"));
            Assert.AreEqual("ha ha ", StringRepeatKata.RepeatStr(2, "ha "));
        }
    }
