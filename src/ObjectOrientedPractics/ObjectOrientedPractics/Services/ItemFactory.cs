using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс <see cref="ItemFactory"/> предоставляет методы для автоматического создания случайных товаров.
    /// </summary>
    internal class ItemFactory
    {
        /// <summary>
        /// Генератор случайных чисел для создания случайных данных.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создает случайный товар с предустановленными именами, описаниями и случайной стоимостью.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Item"/> с случайными параметрами.</returns>
        public static Item CreateRandomItem()
        {
            string[] SampleNames = { "Laptop", "Smartphone", "Headphones", "Monitor", "Keyboard" };
            string[] SampleDescriptions = { "High performance", "Budget friendly", "Latest model", "Popular item", "Limited edition" };

            string RandomName = SampleNames[_random.Next(SampleNames.Length)];
            string RandomDescription = SampleDescriptions[_random.Next(SampleDescriptions.Length)];
            double RandomCost = Math.Round(_random.NextDouble() * 1000, 2); 

            return new Item(RandomName,Category.Electronics, RandomDescription, RandomCost);
        }
    }
}
