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
    /// <summary>
    /// Класс, представляющий вкладку для управления товарами.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        // Список товаров
        List<Item> _items = new List<Item>();

        // Текущий товар, используется для редактирования
        private Item _currentItem = new Item();

        /// <summary>
        /// Конструктор для инициализации компонентов и комбобокса категорий.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeCombobox(CategoryComboBox, typeof(Category));
        }

        /// <summary>
        /// Свойство для получения и установки списка товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет список товаров в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Инициализация комбобокса значениями
        /// </summary>
        /// <param name="comboBox">ComboBox, который мы инициализируем</param>
        /// <param name="enumType">typeof перечисления</param>
        private void InitializeCombobox(ComboBox comboBox, Type enumType)
        {
            foreach (var value in Enum.GetValues(enumType))
            {
                comboBox.Items.Add(value);
            }
            comboBox.SelectedIndex = -1;
        }


        /// <summary>
        /// Очищает поля ввода на форме.
        /// </summary>
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

        /// <summary>
        /// Обновляет выбранный элемент в списке товаров.
        /// </summary>
        private void UpdateListBoxItem()
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = _currentItem;
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить".
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Если поля заполнены выводим сообщение
            if (string.IsNullOrEmpty(CostTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(DescriptionTextBox.Text) || string.IsNullOrEmpty(CategoryComboBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {

                //Создаем новый экземпляр класса Item 
                _currentItem = new Item(NameTextBox.Text, (Category)CategoryComboBox.SelectedIndex, DescriptionTextBox.Text, double.Parse(CostTextBox.Text));

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

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке товаров.
        /// </summary>
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
                CategoryComboBox.SelectedIndex = (int)_currentItem.Category;
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Удалить".
        /// </summary>
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

        /// <summary>
        /// Обработчик события клика мышью по списку товаров.
        /// </summary>
        private void ItemsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemsListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                ItemsListBox.ClearSelected();
                _currentItem = new Item();
                ClearInputField();
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле "Цена".
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                if (!string.IsNullOrWhiteSpace(CostTextBox.Text))
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
                else
                {
                    CostTextBox.BackColor= AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле "Название".
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(NameTextBox.Text))
                    {
                        _currentItem.Name = NameTextBox.Text;
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        NameTextBox.Focus();
                        NameTextBox.Select(NameTextBox.Text.Length, 0);
                        NameTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        NameTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
                catch (ArgumentException)
                {
                    NameTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле "Описание".
        /// </summary>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                    {
                        _currentItem.Info = DescriptionTextBox.Text;
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        DescriptionTextBox.Focus();
                        DescriptionTextBox.Select(DescriptionTextBox.Text.Length, 0);
                        DescriptionTextBox.BackColor = AppColors.DefaultColor;
                    }
                    else
                    {
                        DescriptionTextBox.BackColor = AppColors.ErrorColor;
                    }
                }
                catch (ArgumentException)
                {
                    DescriptionTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Сгенерировать".
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item RandomItem = ItemFactory.CreateRandomItem();
            _items.Add(RandomItem);
            ItemsListBox.Items.Add(RandomItem);
        }

        /// <summary>
        /// Обработчик события изменения выбранного значения в комбобоксе категорий.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && ItemsListBox.SelectedIndex != -1)
            {
                _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
                UpdateListBoxItem();
            }
        }
    }
}