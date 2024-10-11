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
        private Address _currentAddress;

        //Для обновления коректного обновления Address полей
        public bool IsUpdatingFieldFlag = true; 
        public Address Address
        {
            get
            {
                return _currentAddress;
            }
            set
            {
                _currentAddress = value;
                UpdateAddressFields();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        public void UpdateAddressFields()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City.ToString();
            StreetTextBox.Text = Address.Street.ToString();
            BuildingTextBox.Text = Address.Building.ToString();
            ApartmentTextBox.Text = Address.Apartment.ToString();
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
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentAddress != null )
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
            if ( IsUpdatingFieldFlag == true)
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
            if (IsUpdatingFieldFlag == true)
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
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    Address.City = CityTextBox.Text;
                    CityTextBox.BackColor = AppColors.DefaultColor;
                }
                catch (ArgumentException)
                {
                    CityTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
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
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    Address.Apartment = ApartmentTextBox.Text;
                    ApartmentTextBox.BackColor = AppColors.DefaultColor;
                }
                catch (ArgumentException)
                {
                    ApartmentTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

    }
}
