using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public AddressControl()
        {
            InitializeComponent();
            UpdateAddressFields();
        }

        private void UpdateAddressFields()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country.ToString();
            CityTextBox.Text = _address.City.ToString();
            StreetTextBox.Text = _address.Street.ToString();
            BuildingTextBox.Text = _address.Building.ToString();
            ApartmentTextBox.Text = _address.Apartment.ToString();
        }
    }
}
