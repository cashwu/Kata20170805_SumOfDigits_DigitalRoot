using System;
using System.Linq;
using System.Security.Cryptography;
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

        [TestMethod]
        public void input_55_should_return_1()
        {
            AssertDigitalRootShouldBe(1, 55);
        }

        [TestMethod]
        public void input_7777_should_return_1()
        {
            AssertDigitalRootShouldBe(1, 7777);
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
        public long DigitalRoot(long n)
        {
            while (n > 9)
            {
                n = n.ToString().ToCharArray().Select(a => int.Parse(a.ToString())).Sum();
            }
            return n;
        }
    }
}
