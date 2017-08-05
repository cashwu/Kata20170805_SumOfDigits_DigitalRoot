using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170805_SumOfDigits_DigitalRoot
{
    [TestClass]
    public class SumOfDigits_DigitalRootTests
    {
        [TestMethod]
        public void input_1_should_return_1()
        {
            AssertDigitalRootShouldBe(1, 1);
        }

        [TestMethod]
        public void input_11_should_return_1()
        {
            AssertDigitalRootShouldBe(2, 11);
        }

        private static void AssertDigitalRootShouldBe(int expected, int num)
        {
            var number = new Number();
            var actual = number.DigitalRoot(num);
            Assert.AreEqual(actual, expected);
        }
    }

    class Number
    {
        public int DigitalRoot(long n)
        {
            return n.ToString().ToCharArray().Select(a => int.Parse(a.ToString())).Sum();
        }
    }
}
