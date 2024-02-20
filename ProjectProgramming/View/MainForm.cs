using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChooseValueBox.Items.AddRange(Enum.GetValues(typeof(Colors)).Cast<object>().ToArray());
            //Выбор первого элемента списка (Colors) по умолчанию

            IntValueTextBox.ReadOnly = true;
            //Делаем IntValueBox только для чтения, без возможности вписывать данные
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
            IntValueTextBox.Text += ChooseValueBox.SelectedIndex + 1;
        }
    }
}
