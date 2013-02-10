using CalculatorKata;
using NUnit.Framework;

namespace Calculatorkata.Tests
{
    [TestFixture]
    public class CalculatorFixture
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            // Act
            int result = Calculator.Add("");

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("-1", -1)]
        public void Add_OneNumber_ReturnsNumber(string input, int expected)
        {
            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("1,2", 3)]
        [TestCase("3,4", 7)]
        [TestCase("5,6,7", 18)]
        [TestCase("5,6,7,10", 28)]
        public void Add_TwoNumbers_ReturnsSum(string input, int expected)
        {
            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_TwoNumbersWithBreakLine_ReturnsSum()
        {
            // Act
            int result = Calculator.Add("1,\n2");

            // Assert
            Assert.AreEqual(3, result);
        }
    }
}
