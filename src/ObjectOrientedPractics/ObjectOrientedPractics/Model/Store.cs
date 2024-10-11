using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Класс <see cref="Store"/> представляет магазин, который содержит списки товаров и клиентов.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список товаров в магазине.
        /// </summary>
        private List <Item> _items;

        /// <summary>
        /// Список клиентов магазина.
        /// </summary>
        private List <Customer> _customers;

        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Получает или задает список клиентов.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/> с пустыми списками товаров и клиентов.
        /// </summary>
        public Store ()
        {
            Items = new List<Item> ();
            Customers = new List<Customer> ();
        }
    }
}
