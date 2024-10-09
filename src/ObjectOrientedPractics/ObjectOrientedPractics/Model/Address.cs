using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        private int _index;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

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
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("В строке не должно быть больше 50 символов");
                }
                _country = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("В строке не должно быть больше 50 символов");
                }
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("В строке не должно быть больше 100 символов");
                }
                _street = value;
            }
        }
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                if (value.Length > 10)
                {
                    throw new ArgumentException("В строке не должно быть больше 10 символов");
                }
                _building = value;
            }
        }
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if (value.Length > 10)
                {
                    throw new ArgumentException("В строке не должно быть больше 10 символов");
                }
                _apartment = value;
            }
        }


        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index= index;
            Country= country;
            City= city;
            Street= street;
            Building= building;
            Apartment= apartment;
        }
        public override string ToString()
        {
            return $"{Country}";
        }
    }
}
