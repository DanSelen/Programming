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
    /// <summary>
    /// Представляет вкладку для управления списком клиентов.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        // Список клиентов
        List<Customer> _customers = new List<Customer>();
        // Текущий клиент
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получает или устанавливает список клиентов.
        /// При установке нового списка обновляет список клиентов в интерфейсе.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет элементы списка клиентов в интерфейсе.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add(customer);
            }
        }

        /// <summary>
        /// Обновляет текущий выбранный элемент в списке клиентов.
        /// </summary>
        private void UpdateListBoxItem()
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer;
            }
        }

        /// <summary>
        /// Очищает все поля ввода на вкладке.
        /// </summary>
        private void ClearInputField()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl1.Clear();//AddressTextBox.Clear();
            IdTextBox.BackColor = AppColors.DefaultColor;
            FullNameTextBox.BackColor = AppColors.DefaultColor;
            //AddressTextBox.BackColor = AppColors.DefaultColor;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить".
        /// Добавляет нового клиента в список, если все поля заполнены.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) || AddressControl1.AddressIsNullOrEmpty()  /*string.IsNullOrEmpty(AddressTextBox.Text*/ )
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            Customer NewCustomer = new Customer(FullNameTextBox.Text, AddressControl1.Address);
            _customers.Add(NewCustomer);
            CustomersListBox.Items.Add(NewCustomer);

        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке клиентов.
        /// Обновляет поля ввода текущим клиентом.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1 || CustomersListBox.SelectedItem !=null)
            {
                AddressControl1.IsUpdatingFieldFlag = true;
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];

                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl1.Address = _currentCustomer.Address;//AddressTextBox.Text = _currentCustomer.Address;
                //AddressControl1.UpdateAddressFields();
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Удалить".
        /// Удаляет выбранного клиента из списка.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                AddressControl1.IsUpdatingFieldFlag = false;
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                _customers.Remove(_currentCustomer);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
                //CustomersListBox.SelectedIndex = -1;
                ClearInputField();
            }
        }

        /// <summary>
        /// Обработчик события клика мыши по списку клиентов.
        /// Очищает выделение, если кликнули не по элементу списка.
        /// </summary>
        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                AddressControl1.IsUpdatingFieldFlag = false;
                CustomersListBox.ClearSelected();
                ClearInputField();
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле полного имени.
        /// Обновляет информацию о текущем клиенте.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(FullNameTextBox.Text) || !AddressControl1.AddressIsNullOrEmpty() )
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

        /// <summary>
        /// Обработчик события нажатия кнопки "Генерировать".
        /// Создает случайного клиента и добавляет его в список.
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Customer RandomCustomer = CustomerFactory.CreateRandomCustomer();
            _customers.Add(RandomCustomer);
            CustomersListBox.Items.Add(RandomCustomer);
        }
    }
}
