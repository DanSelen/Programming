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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        private Item _currentItem;
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ClearInputField()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            IdTextBox.BackColor = AppColors.DefaultColor;
            CostTextBox.BackColor = AppColors.DefaultColor;
            NameTextBox.BackColor = AppColors.DefaultColor;
            DescriptionTextBox.BackColor = AppColors.DefaultColor;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Если поля заполнены выводим сообщение
            if (string.IsNullOrEmpty(CostTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            //Создаем новый экземпляр класса Item 
            _currentItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, double.Parse(CostTextBox.Text));

            //Добавляем его в список
            _items.Add(_currentItem);

            //Добавляем его в ListBox
            ItemsListBox.Items.Add(_currentItem);

            //Очищаем поля ввода
            ClearInputField();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                // Получаем текущий выбранный элемент
                _currentItem = _items[ItemsListBox.SelectedIndex];

                //Обновляем текстовые поля значениями из списка
                IdTextBox.Text = _currentItem.Id.ToString();
                NameTextBox.Text = _currentItem.Name;
                CostTextBox.Text = _currentItem.Cost.ToString();
                DescriptionTextBox.Text = _currentItem.Info;
            }
            else
            {
                ClearInputField();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                //Получаем текущий элемент
                _currentItem = _items[ItemsListBox.SelectedIndex];

                //Удаляем текущий элемент из списка
                _items.Remove(_currentItem);

                //Удаляем текущий элемент из ListBox
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);

                //Очищаем поля ввода
                ClearInputField();
            }
        }


        //???????
        private void ItemsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemsListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                ItemsListBox.ClearSelected();
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(CostTextBox.Text))
                {
                    _currentItem.Cost = double.Parse(CostTextBox.Text);

                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text))
                {
                    _currentItem.Name = NameTextBox.Text;
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex !=-1 )
            {
                _currentItem.Info = DescriptionTextBox.Text;
            }
        }
    }
}