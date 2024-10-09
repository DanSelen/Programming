using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer = new Customer();

        public CustomersTab()
        {
            InitializeComponent();

        }



        private void UpdateListBoxItem()
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer;
            }
        }

        private void ClearInputField()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl1.Clear();//AddressTextBox.Clear();
            IdTextBox.BackColor = AppColors.DefaultColor;
            FullNameTextBox.BackColor = AppColors.DefaultColor;
            //AddressTextBox.BackColor = AppColors.DefaultColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) || AddressControl1.AddressIsNullOrEmpty()  /*string.IsNullOrEmpty(AddressTextBox.Text*/ )
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            _currentCustomer = new Customer(FullNameTextBox.Text, AddressControl1.Address);
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer);
            UpdateListBoxItem();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];

                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl1.Address = _currentCustomer.Address;//AddressTextBox.Text = _currentCustomer.Address;
            }
            else
            {

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                _customers.Remove(_currentCustomer);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
                ClearInputField();
            }
        }

        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                CustomersListBox.ClearSelected();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(FullNameTextBox.Text) && !AddressControl1.AddressIsNullOrEmpty() )
                    {
                        _currentCustomer.FullName = FullNameTextBox.Text;
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        FullNameTextBox.Focus();
                        FullNameTextBox.Select(FullNameTextBox.Text.Length, 0);
                    }
                }
                catch (ArgumentException)
                {
                    FullNameTextBox.BackColor = AppColors.DefaultColor;
                }
            }
        }
        /*
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(AddressTextBox.Text))
                    {
                        _currentCustomer.Address = AddressTextBox.Text;

                        //Решение проблемы съезжания курсора влево
                        AddressTextBox.Focus();
                        AddressTextBox.Select(AddressTextBox.Text.Length, 0);
                    }
                }
                catch (ArgumentException)
                {

                }
            }
        }
        */

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Customer RandomCustomer = CustomerFactory.CreateRandomCustomer();
            _customers.Add(RandomCustomer);
            CustomersListBox.Items.Add(RandomCustomer);
        }
    }
}
