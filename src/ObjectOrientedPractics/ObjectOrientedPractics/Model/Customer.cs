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
    internal class Customer
    {
        /// <summary>
        /// Уникальный идентификатор клиента, генерируемый автоматически.
        /// </summary>
        readonly int _id;

        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес клиента.
        /// </summary>
        private string _address;

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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500,nameof(Address));
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
        public Customer(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        public override string ToString()
        {
            return $"{Id} - {FullName} - {Address}";
        }

    }
}
