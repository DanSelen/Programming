using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangles;
        private string[] _listboxRectangle = new string[5];
        Random random = new Random();
        private string[] _collorsArray = { "Red", "Blue", "Green", "Yellow", "Black", "White", "Purple" } ;


        public MainForm()
        {
            


            InitializeComponent();
            ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(Colors)).Cast<object>().ToArray());
            //Выбор первого элемента списка (Colors) по умолчанию

            IntValueTextBox.ReadOnly = true;
            //Делаем IntValueBox только для чтения, без возможности вписывать данные

            object[] SeasonValuesArray = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValuesArray);

            Random random = new Random();
            for (int i = 0; i < _listboxRectangle.Length; i++)
            {
                // Генерация случайной длины и ширины прямоугольника
                double length = random.Next(1, 20);
                double width = random.Next(1, 20);
                int colorRandomIndex = random.Next(0, _collorsArray.Length - 1);
                _rectangles[i] = new Rectangle(length, width, _collorsArray[colorRandomIndex]);
                _listboxRectangle[i] = ($"Rectangle {i + 1}");
            }
            RectanglesListBox.Items.AddRange(_listboxRectangle);
        }

        private void ChooseEnumerationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseValueBox.Items.Clear();
            switch (ChooseEnumerationBox.SelectedIndex)
            {
                case 0: 
                    ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(Colors)).Cast<object>().ToArray());
                    break;
                case 1:
                    ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
                    break;
                case 2:
                    ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:
                    ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 4:
                    ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(SmartphoneManufacturers)).Cast<object>().ToArray());
                    break;
                case 5:
                    ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;


            }
        }

        private void ChooseValueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            IntValueTextBox.Text += ChooseValueBox.SelectedIndex;
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string ParseTextBoxItem = ParseTextBox.Text;
            if (int.TryParse(ParseTextBoxItem, out _))
            {
                MessageBox.Show("Ошибка! Введенные данные не являются текстом");
            }
            else if (TryGetEnumValue<Weekday>(ParseTextBoxItem, out Weekday value))
            {
                WeekdayParsingLabel.Text = $"Это день недели ({value} = {(int)value})";
            }
            else
            {
                WeekdayParsingLabel.Text = $"Это не день недели";
            }
        }
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }

        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                SeasonComboBox.BackColor = System.Drawing.Color.LightPink; return;
            }
            SeasonComboBox.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура, солнце");
                    break;
                case Season.Autumn:
                    SetBackColor(SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#e29c45")); break;
                case Season.Winter:
                    MessageBox.Show("БРР, Холодно");
                    break;
                case Season.Spring:
                    SetBackColor(SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#559c45")); break;
            }
        }
        private void SetBackColor(System.Drawing.Color color)
        {
            EnumerationGroupBox.BackColor = color;
            WeekdayParsingGroupBox.BackColor = color;
            SeasonComboBox.BackColor = color;
            this.BackColor = color;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangles = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangles.Length.ToString();
            WidthTextBox.Text = _currentRectangles.Width.ToString();
            ColorTextBox.Text = _currentRectangles.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
