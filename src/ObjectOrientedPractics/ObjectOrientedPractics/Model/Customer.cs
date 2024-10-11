using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Класс <see cref="Customer"/> представляет клиента с уникальным идентификатором, полным именем и адресом.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор клиента, генерируемый автоматически.
        /// </summary>
        readonly int _id;

        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        private string _fullName = string.Empty;

        /// <summary>
        /// Адрес клиента.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Получает или задает полное имя клиента.
        /// Валидация происходит с помощью <see cref="ValueValidator.AssertStringOnLength"/>.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина имени превышает 200 символов.
        /// </exception>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200,nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Получает или задает адрес клиента.
        /// Валидация происходит с помощью <see cref="ValueValidator.AssertStringOnLength"/>.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина адреса превышает 500 символов.
        /// </exception>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                //Валидцаию сделать отдельно
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор клиента.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с указанными именем и адресом.
        /// </summary>
        /// <param name="fullName">Полное имя клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullName, Address address)
        {
            FullName = fullName;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с пустыми значениями.
        /// </summary>
        public Customer()
        {
            FullName = string.Empty; // Инициализируем пустой строкой
            Address = new Address(); // Инициализируем новый экземпляр Address
            _id = IdGenerator.GetNextId(); // Генерируем новый Id
        }

        /// <summary>
        /// Возвращает строковое представление клиента.
        /// </summary>
        /// <returns>Строка, содержащая идентификатор и полное имя клиента.</returns>
        public override string ToString()
        {
            return $"{Id} - {FullName}";
        }

    }
}
