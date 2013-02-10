using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CheckoutKata
{
    [TestFixture]
    public class CheckoutFixture
    {
        [Test]
        public void ScanNoItems_TotalIsZero()
        {
            // Arrange
            var checkout = new Checkout();

            // Act + Assert
            Assert.AreEqual(0, checkout.Total);
        }

        [TestCase('A', 50)]
        [TestCase('B', 30)]
        [TestCase('C', 20)]
        [TestCase('D', 15)]
        public void ScanOneItem_TotalIsValueItem(char item, int total)
        {
            // Arrange
            var checkout = new Checkout();

            // Act
            checkout.Scan(item);

            // Assert
            Assert.AreEqual(total, checkout.Total);
        }

        private void ScanMultipleItems(string items, int total)
        {
            // Arrange
            var checkout = new Checkout();

            // Act
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i]);
            }

            // Assert
            Assert.AreEqual(total, checkout.Total);
        }

        [TestCase("AA", 100)]
        [TestCase("AB", 80)]
        [TestCase("ABC", 100)]
        [TestCase("ABCD", 115)]        
        public void ScanMultipleItems_TotalIsSum(string items, int total)
        {
            ScanMultipleItems(items, total);
        }

        [TestCase("AAA", 130)]
        [TestCase("BB", 45)]
        [TestCase("AAABB", 175)]
        public void ScanMultipleItemsWithOffer_TotalIsSumSubtractDiscount(string items, int total)
        {
            ScanMultipleItems(items, total);
        }
    } 
}
