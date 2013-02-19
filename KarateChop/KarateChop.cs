using NUnit.Framework;

namespace KarateChop
{
    [TestFixture]
    public class KarateChop
    {
        [Test]
        public void EmptyArrayReturnsMinusOne()
        {
            Assert.AreEqual(-1, Karate.Find(3, new int[]{}));
        }

        [Test]
        public void ItemNotInArrayReturnsMinusOne()
        {
            Assert.AreEqual(-1, Karate.Find(3, new[]{1}));
        }

        [Test]
        public void ItemInOneElementArrayReturnsZero()
        {
            Assert.AreEqual(0, Karate.Find(1, new[]{1}));
        }

        [Test]
        public void FindFirstElementInArrayReturnsZero()
        {
            Assert.AreEqual(0, Karate.Find(1, new[] {1,3,5}));
        }
        
        [Test]
        public void FindSecondElementInArrayReturnsOne()
        {
            Assert.AreEqual(1, Karate.Find(3, new[] { 1, 3, 5 }));
        }

        [Test]
        public void FindThirdElementInArrayReturnsTwo()
        {
            Assert.AreEqual(2, Karate.Find(5, new[] { 1, 3, 5 }));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        public void FindElementIsNotInArrayReturnsMinusOne(int item)
        {
            Assert.AreEqual(-1, Karate.Find(item, new[] { 1, 3, 5 }));
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
            Assert.AreEqual(expectedPosition, Karate.Find(itemToFind, new[] { 1, 3, 5, 7 }));
        }
    }

    public static class Karate
    {
        public static int Find(int itemToFind, int[] items)
        {
            const int notFound = -1;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToFind)
                    return i;
            }

            return notFound;
        }
    }
}
