using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class CustomerFactory
    {
        private static Random _random = new Random();

        public static Customer CreateRandomCustomer()
        {
            string[] SampleFullNames = { "Веденеев Василий Никандрович", "Пастух Тимофей Афанасьевич", "Бельтюкова Сюзанна Ивановна", "Цедлиц Федор Никифорович", "Козин Давид Себастьянович" };
            string[] SampleAddresses = { "Россия, г. Казань, Колхозный пер., д. 10 кв.10", "Россия, г. Уфа, Чкалова ул., д. 7 кв.74", "Россия, г. Салават, Дачная ул., д. 13 кв.216" };

            string RandomFullName = SampleFullNames[_random.Next(SampleFullNames.Length)];
            string RandomAddress = SampleAddresses[_random.Next(SampleAddresses.Length)];

            return new Customer(RandomFullName, RandomAddress);
        }
    }
}