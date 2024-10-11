using ObjectOrientedPractics.Services;
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
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
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
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
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
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
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
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
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
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }


        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
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
