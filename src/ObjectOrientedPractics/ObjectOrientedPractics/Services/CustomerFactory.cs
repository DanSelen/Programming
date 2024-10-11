using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс <see cref="CustomerFactory"/> предоставляет методы для автоматического создания клиентов.
    /// </summary>
    internal class CustomerFactory
    {
        /// <summary>
        /// Генератор случайных чисел для создания случайных данных.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создает случайного клиента с предустановленными именами и адресами.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Customer"/> со случайным именем и адресом.</returns>
        public static Customer CreateRandomCustomer()
        {
            string[] SampleFullNames = { "Веденеев Василий Никандрович", "Пастух Тимофей Афанасьевич", "Бельтюкова Сюзанна Ивановна", "Цедлиц Федор Никифорович", "Козин Давид Себастьянович" };
            Address[] SampleAddresses = {
            new Address(420000, "Россия", "Казань", "Колхозный пер.", "10", "10"),
            new Address(450000, "Россия", "Уфа", "Чкалова ул.", "7", "74"),
            new Address(453000, "Россия", "Салават", "Дачная ул.", "13", "216")
        };

            string RandomFullName = SampleFullNames[_random.Next(SampleFullNames.Length)];
            Address RandomAddress = SampleAddresses[_random.Next(SampleAddresses.Length)];

            return new Customer(RandomFullName, RandomAddress);
        }
    }
}