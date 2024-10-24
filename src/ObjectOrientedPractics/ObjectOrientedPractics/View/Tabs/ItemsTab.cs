﻿using ObjectOrientedPractics.Model;
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

        private void UpdateListBoxItem()
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = _currentItem;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Если поля заполнены выводим сообщение
            if (string.IsNullOrEmpty(CostTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {

                //Создаем новый экземпляр класса Item 
                _currentItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, double.Parse(CostTextBox.Text));

                //Добавляем его в список
                _items.Add(_currentItem);

                //Добавляем его в ListBox
                ItemsListBox.Items.Add(_currentItem);

                //Очищаем поля ввода
                ClearInputField();
            }
            catch (FormatException)
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Цена не должна превышать 100000");
                CostTextBox.BackColor = AppColors.ErrorColor;
            }
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
                    try
                    {
                        _currentItem.Cost = double.Parse(CostTextBox.Text);
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        CostTextBox.Focus();
                        CostTextBox.Select(CostTextBox.Text.Length, 0);
                        CostTextBox.BackColor = AppColors.DefaultColor;
                    }

                    //Если введено значение выходящее за рамки диапазона
                    catch (ArgumentException)
                    {
                        CostTextBox.BackColor = AppColors.ErrorColor;
                    }

                    //Если введено не числовое значение
                    catch (FormatException)
                    {
                        CostTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(NameTextBox.Text))
                    {
                        _currentItem.Name = NameTextBox.Text;
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        NameTextBox.Focus();
                        NameTextBox.Select(NameTextBox.Text.Length, 0);
                        NameTextBox.BackColor = AppColors.DefaultColor;
                    }
                }
                catch (ArgumentException)
                {
                    NameTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(DescriptionTextBox.Text))
                    {
                        _currentItem.Info = DescriptionTextBox.Text;
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        DescriptionTextBox.Focus();
                        DescriptionTextBox.Select(DescriptionTextBox.Text.Length, 0);
                        DescriptionTextBox.BackColor = AppColors.DefaultColor;
                    }
                }
                catch (ArgumentException)
                {
                    DescriptionTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item RandomItem = ItemFactory.CreateRandomItem();
            _items.Add(RandomItem);
            ItemsListBox.Items.Add(RandomItem);
        }
    }
}