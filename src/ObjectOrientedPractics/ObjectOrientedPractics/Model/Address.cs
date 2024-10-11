using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес, содержащий индекс, страну, город, улицу, здание и квартиру.
    /// </summary>
    public class Address
    {
        private int _index;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

        /// <summary>
        /// Получает или задает индекс. Индекс должен быть в диапазоне от 100000 до 999999.
        /// </summary>
        /// <exception cref="ArgumentException">Возникает, если индекс выходит за указанный диапазон.</exception>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException("Индекс должен находиться в диапазоне от 100000 до 999999(6-знач.)");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Получает или задает страну. Строка не должна превышать 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Получает или задает город. Строка не должна превышать 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _city = value;
            }
        }

        /// <summary>
        /// Получает или задает улицу. Строка не должна превышать 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Получает или задает здание. Строка не должна превышать 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Получает или задает квартиру. Строка не должна превышать 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с пустыми значениями и индексом по умолчанию.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с заданными значениями.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Здание.</param>
        /// <param name="apartment">Квартира.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index= index;
            Country= country;
            City= city;
            Street= street;
            Building= building;
            Apartment= apartment;
        }

        /// <summary>
        /// Возвращает строковое представление адреса.
        /// </summary>
        /// <returns>Строка, представляющая адрес.</returns>
        public override string ToString()
        {
            return $"{Country} ";
        }
    }
}
