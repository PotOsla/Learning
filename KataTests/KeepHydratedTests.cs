using NUnit.Framework;
using System;

[TestFixture]
public class KeepHydratedTests
{
    [Test]
    [TestCase(2,1)]
    [TestCase(1.4, 0)]
    [TestCase(12.3, 6)]
    [TestCase(0.82, 0)]
    [TestCase(1787, 893)]
    [TestCase(0, 0)]
    public static void Test1(double time, int Litres)
    {
        Assert.AreEqual(Litres, KeepHydrated.Litres(time));
    }
}