using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Operations_Add_Get_20_from_12_plus_8()
        {
            Assert.AreEqual(20, Operations.Add(12, 8));
        }

        [TestCase(12, 23, 35)]
        [TestCase(-980000, 980001, 1)]
        [TestCase(99999999, 1, 100000000)]
        [TestCase(0, 0, 0)]
        public void Test_Operations_Add(int a, int b, int res)
        {
            Assert.AreEqual(res, Operations.Add(a, b));
        }
    }
}
