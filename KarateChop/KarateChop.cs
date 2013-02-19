using NUnit.Framework;

namespace KarateChop
{
    [TestFixture]
    public class KarateChop
    {
        [Test]
        public void EmptyArrayReturnsMinusOne()
        {
            Assert.AreEqual(-1, Karate.Chop(3, new int[]{}));
        }

        [Test]
        public void ItemNotInArrayReturnsMinusOne()
        {
            Assert.AreEqual(-1, Karate.Chop(3, new[]{1}));
        }

        [Test]
        public void ItemInOneElementArrayReturnsZero()
        {
            Assert.AreEqual(0, Karate.Chop(1, new[]{1}));
        }

        [Test]
        public void FindFirstElementInArrayReturnsZero()
        {
            Assert.AreEqual(0, Karate.Chop(1, new[] {1,3,5}));
        }
        
        [Test]
        public void FindSecondElementInArrayReturnsOne()
        {
            Assert.AreEqual(1, Karate.Chop(3, new[] { 1, 3, 5 }));
        }

    }

    public static class Karate
    {
        public static int Chop(int item, int[] array)
        {
            if (array.Length > 0 && array[0] == item)
                return 0;

            return -1;
        }
    }
}
