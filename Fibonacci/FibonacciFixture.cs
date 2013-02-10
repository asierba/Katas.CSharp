using NUnit.Framework;
using System;


namespace FibonacciKata.Tests
{
    [TestFixture]
    public class FibonacciFixture
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        [TestCase(5, 5)]
        [TestCase(8, 6)]
        [TestCase(13, 7)]
        [TestCase(21, 8)]
        public void AssertFibonacciOf(int expected, int input)
        {
            // Act
            int result = Fibonacci.Of(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
