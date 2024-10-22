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
    /// <summary>
    /// Представляет элемент управления для работы с адресом.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        // Хранит текущий адрес
        private Address _currentAddress;

        /// <summary>
        /// Флаг для корректного обновления полей адреса.
        /// </summary>
        public bool IsUpdatingFieldFlag = true;

        /// <summary>
        /// Получает или устанавливает текущий адрес.
        /// При установке нового адреса обновляет поля адреса.
        /// </summary>
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

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        /// <summary>
        /// Обновляет поля адреса текущими значениями адреса.
        /// </summary>
        public void UpdateAddressFields()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City.ToString();
            StreetTextBox.Text = Address.Street.ToString();
            BuildingTextBox.Text = Address.Building.ToString();
            ApartmentTextBox.Text = Address.Apartment.ToString();
        }

        /// <summary>
        /// Проверяет, является ли адрес пустым или отсутствующим.
        /// </summary>
        /// <returns>true, если хотя бы одно поле адреса пустое; иначе false.</returns>
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

        /// <summary>
        /// Очищает все поля адреса.
        /// </summary>
        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }


        /// <summary>
        /// Обработчик события изменения текста в поле индекса.
        /// </summary>
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

        /// <summary>
        /// Обработчик события изменения текста в поле страны.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if ( IsUpdatingFieldFlag == true)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(CountryTextBox.Text))
                    {
                        Address.Country = CountryTextBox.Text;
                        CountryTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        CountryTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
                catch (ArgumentException)
                {
                    CountryTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }


        /// <summary>
        /// Обработчик события изменения текста в поле улицы.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(StreetTextBox.Text))
                    {
                        Address.Street = StreetTextBox.Text;
                        StreetTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        StreetTextBox.BackColor= AppColors.ErrorColor;
                    }
                }

                catch (ArgumentException)
                {
                    StreetTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле города.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    if (!(string.IsNullOrWhiteSpace(CityTextBox.Text)))
                    {
                        Address.City = CityTextBox.Text;
                        CityTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        CityTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
                catch (ArgumentException)
                {
                    CityTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле здания.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(BuildingTextBox.Text))
                    {
                        Address.Building = BuildingTextBox.Text;
                        BuildingTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        BuildingTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
                catch (ArgumentException)
                {
                    BuildingTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле квартиры.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(ApartmentTextBox.Text))
                    {
                        Address.Apartment = ApartmentTextBox.Text;
                        ApartmentTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        ApartmentTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
                catch (ArgumentException)
                {
                    ApartmentTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

    }
}
