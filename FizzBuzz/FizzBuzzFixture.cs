using NUnit.Framework;

namespace FizzBuzz
{
    namespace FizzBuzz.Tests
    {
        [TestFixture]
        public class FizzBuzzKataFixture
        {
            [Test]
            public void TestExample()
            {
                // Arrange
                var fizzBuzzKata = new FizzBuzzKata();

                // Act + Assert
                Assert.AreEqual("1", fizzBuzzKata.Answer(1));
                Assert.AreEqual("2", fizzBuzzKata.Answer(2));
                Assert.AreEqual("fizz", fizzBuzzKata.Answer(3));
                Assert.AreEqual("4", fizzBuzzKata.Answer(4));
                Assert.AreEqual("buzz", fizzBuzzKata.Answer(5));
                Assert.AreEqual("fizz", fizzBuzzKata.Answer(6));
                Assert.AreEqual("7", fizzBuzzKata.Answer(7));
                Assert.AreEqual("8", fizzBuzzKata.Answer(8));
                Assert.AreEqual("fizz", fizzBuzzKata.Answer(9));
                Assert.AreEqual("buzz", fizzBuzzKata.Answer(10));
                Assert.AreEqual("11", fizzBuzzKata.Answer(11));
                Assert.AreEqual("fizz", fizzBuzzKata.Answer(12));
                Assert.AreEqual("13", fizzBuzzKata.Answer(13));
                Assert.AreEqual("14", fizzBuzzKata.Answer(14));
                Assert.AreEqual("fizzbuzz", fizzBuzzKata.Answer(15));
            }
        }
    }

}
