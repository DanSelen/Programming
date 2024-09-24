using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class ItemFactory
    {
        private static Random _random = new Random();

        public static Item CreateRandomItem()
        {
            string[] SampleNames = { "Laptop", "Smartphone", "Headphones", "Monitor", "Keyboard" };
            string[] SampleDescriptions = { "High performance", "Budget friendly", "Latest model", "Popular item", "Limited edition" };

            string RandomName = SampleNames[_random.Next(SampleNames.Length)];
            string RandomDescription = SampleDescriptions[_random.Next(SampleDescriptions.Length)];
            double RandomCost = Math.Round(_random.NextDouble() * 1000, 2); 

            return new Item(RandomName, RandomDescription, RandomCost);
        }
    }
}
