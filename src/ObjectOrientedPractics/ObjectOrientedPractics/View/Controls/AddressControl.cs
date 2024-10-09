using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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
                if (_address != null)
                {
                    // Обновляем текстбоксы, используя значения из Address
                    UpdateAddressFields();
                }
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
        public bool AddressIsNullOrEmpty()
        {
            if (string.IsNullOrEmpty(PostIndexTextBox.Text) ||
                string.IsNullOrEmpty(CountryTextBox.Text) ||
                string.IsNullOrEmpty(CityTextBox.Text) ||
                string.IsNullOrEmpty(StreetTextBox.Text) ||
                string.IsNullOrEmpty(BuildingTextBox.Text) ||
                string.IsNullOrEmpty(ApartmentTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            PostIndexTextBox.Clear();
            PostIndexTextBox.BackColor = AppColors.DefaultColor;
            CountryTextBox.Clear();
            CountryTextBox.BackColor = AppColors.DefaultColor;
            CityTextBox.Clear();
            CityTextBox.BackColor = AppColors.DefaultColor;
            StreetTextBox.Clear();
            StreetTextBox.BackColor = AppColors.DefaultColor;
            BuildingTextBox.Clear();
            BuildingTextBox.BackColor = AppColors.DefaultColor;
            ApartmentTextBox.Clear();
            ApartmentTextBox.BackColor = AppColors.DefaultColor;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null)
            {
                try
                {
                    Address.Index = int.Parse(PostIndexTextBox.Text);
                    PostIndexTextBox.BackColor = AppColors.DefaultColor;
                }
                catch (ArgumentException)
                {
                    PostIndexTextBox.BackColor = AppColors.ErrorColor;
                }
                catch(OverflowException)
                {
                    PostIndexTextBox.BackColor = AppColors.ErrorColor;
                }
                catch (FormatException)
                {
                    PostIndexTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null)
            {
                try
                {
                    Address.Country = CountryTextBox.Text;
                    CountryTextBox.BackColor = AppColors.DefaultColor;
                }
                catch (ArgumentException)
                {
                    CountryTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null)
            {
                try
                {
                    Address.Street = StreetTextBox.Text;
                    StreetTextBox.BackColor = AppColors.DefaultColor;
                }

                catch (ArgumentException)
                {
                    StreetTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null)
            {
                try
                {
                    Address.City = CityTextBox.Text;
                    CityTextBox.BackColor = AppColors.DefaultColor;
                }
                catch(ArgumentException)
                {
                    CityTextBox.BackColor= AppColors.ErrorColor;
                }
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null)
            {
                try
                {
                    Address.Building = BuildingTextBox.Text;
                    BuildingTextBox.BackColor = AppColors.DefaultColor;
                }
                catch (ArgumentException)
                {
                    BuildingTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null)
            {
                try
                {
                    Address.Apartment = ApartmentTextBox.Text;
                    ApartmentTextBox.BackColor = AppColors.DefaultColor;
                }
                catch(ArgumentException)
                {
                    ApartmentTextBox.BackColor= AppColors.ErrorColor;
                }
            }
        }
    }
}
