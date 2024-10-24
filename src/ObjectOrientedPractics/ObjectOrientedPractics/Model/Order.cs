using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс <see cref="Order"/> предоставляет заказ
    /// </summary>
    public class Order
    {
        readonly int _id;
        readonly DateTime _creationData;
        private string _deliveryAddress;
        private List<Item> _items;
        private double _amount;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get 
            { 
                return _id;
            }
        }

        /// <summary>
        /// Возваращает дату создания заказа.
        /// </summary>
        public DateTime CreationData
        {
            get
            {
                return _creationData;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс заказа.
        /// </summary>
        public string DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                _deliveryAddress = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров в заказе.
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
        /// Возвращает и задает сумму заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/> с пустыми значениями.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _creationData = DateTime.Now;
            DeliveryAddress = string.Empty;
            Items = new List<Item>();
            Amount = 0.0;
        }
    }
}