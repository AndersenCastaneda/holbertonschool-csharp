using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Operations_Max_get_98()
        {
            List<int> myList = new List<int> { 98, 43, 77, 92 };
            Assert.AreEqual(98, Operations.Max(myList));
        }

        [Test]
        public void Operations_Max_get_65()
        {
            List<int> myList = new List<int> { 12, 43, 32, 17, 21, 39, 44, 65 };
            Assert.AreEqual(65, Operations.Max(myList));
        }

        [Test]
        public void Operations_Max_get_minus_4()
        {
            List<int> myList = new List<int> { -12, -43, -32, -17, -21, -39, -44, -65, -4 };
            Assert.AreEqual(-4, Operations.Max(myList));
        }
    }
}