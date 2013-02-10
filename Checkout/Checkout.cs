using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutKata
{
    public class Checkout
    {
        private Dictionary<char, int> _prices;
        private Dictionary<char, Offer> _offers;
        private Dictionary<char, int> _itemCounters;

        public Checkout()
        {
            _itemCounters = new Dictionary<char, int> { { 'A', 0 }, { 'B', 0 }, { 'C', 0 }, { 'D', 0 } };
            _prices = new Dictionary<char, int> { { 'A', 50 }, { 'B', 30 }, { 'C', 20 }, { 'D', 15 } };
            _offers = new Dictionary<char, Offer>
            { 
                {'A', new Offer { Discount = 20, NumberOfItems = 3}},
                {'B', new Offer { Discount = 15, NumberOfItems = 2}},
            };
        }
        public int Total { get; private set; }

        public void Scan(char item)
        {
            _itemCounters[item]++;
            Total += _prices[item];
            if (HasOffer(item) && RequiredNumber(item))
            {
                Total -= _offers[item].Discount;
            }
        }

        private bool HasOffer(char item)
        {
            return _offers.ContainsKey(item);
        }

        private bool RequiredNumber(char item)
        {
            return _itemCounters[item] == _offers[item].NumberOfItems;
        }
    }
}
