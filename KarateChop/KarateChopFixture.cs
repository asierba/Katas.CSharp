using NUnit.Framework;

namespace KarateChop
{
    [TestFixture]
    public class KarateChopFixture
    {
        [Test]
        public void EmptyArrayReturnsMinusOne()
        {
            Assert.AreEqual(-1, KarateChop.Find(3, new int[]{}));
        }

        [Test]
        public void ItemNotInArrayReturnsMinusOne()
        {
            Assert.AreEqual(-1, KarateChop.Find(3, new[]{1}));
        }

        [Test]
        public void ItemInOneElementArrayReturnsZero()
        {
            Assert.AreEqual(0, KarateChop.Find(1, new[]{1}));
        }

        [Test]
        public void FindFirstElementInArrayReturnsZero()
        {
            Assert.AreEqual(0, KarateChop.Find(1, new[] {1,3,5}));
        }
        
        [Test]
        public void FindSecondElementInArrayReturnsOne()
        {
            Assert.AreEqual(1, KarateChop.Find(3, new[] { 1, 3, 5 }));
        }

        [Test]
        public void FindThirdElementInArrayReturnsTwo()
        {
            Assert.AreEqual(2, KarateChop.Find(5, new[] { 1, 3, 5 }));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        public void FindElementIsNotInArrayReturnsMinusOne(int item)
        {
            Assert.AreEqual(-1, KarateChop.Find(item, new[] { 1, 3, 5 }));
        }

        [TestCase(0, 1)]
        [TestCase(1, 3)]
        [TestCase(2, 5)]
        [TestCase(3, 7)]
        [TestCase(-1, 0)]
        [TestCase(-1, 2)]
        [TestCase(-1, 4)]
        [TestCase(-1, 6)]
        [TestCase(-1, 8)]
        public void FindElementInArray(int expectedPosition, int itemToFind)
        {
            Assert.AreEqual(expectedPosition, KarateChop.Find(itemToFind, new[] { 1, 3, 5, 7 }));
        }
    }
}
