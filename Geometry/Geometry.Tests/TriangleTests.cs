namespace Geometry.Tests;

using Geometry.Lib;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestOnce()
    {
        Triangle tri = new("Triangle", 30, 75, 75, 10, 19.31851653, 19.31851653);
        Assert.AreEqual(93.30127019, tri.Area());
    }
}