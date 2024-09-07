using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AppForStudent
{
    public partial class MainForm : Form
    {
        List<Student> Students = new List<Student>();
        Student _currentStudent;
        private string filePath = "students.xml"; // Путь к файлу для сохранения данных

        public MainForm()
        {
            InitializeComponent();
            LoadDataFromFile();
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
            }

            Array ComboBoxStudyOfFor = Enum.GetValues(typeof(StudentFormOfStudy));
            foreach(StudentFormOfStudy run in ComboBoxStudyOfFor)
            {
                comboBoxFormStudyStudent.Items.Add(run);
            }

            Array ComboBoxFakultet = Enum.GetValues(typeof(Facultet));
            foreach(Facultet f in ComboBoxFakultet)
            {
                comboBoxEducation.Items.Add(f);
            }
            // Подключение метода MainForm_FormClosing к событию FormClosing
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToFile();
        }
        // Метод для сохранения данных в файл
        private void SaveDataToFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, Students);
            }
        }

        // Метод для загрузки данных из файла
        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    using (Stream reader = new FileStream(filePath, FileMode.Open))
                    {
                        Students = (List<Student>)serializer.Deserialize(reader);
                    }
                    UpdateStudentList(); // После загрузки данных обновляем отображение в ListBox
                }
                catch (InvalidOperationException ex)
                {
                    // Обработка ошибки десериализации XML
                    MessageBox.Show($"Ошибка десериализации XML: {ex.Message}");
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
             
        }

        

        private void TextBoxRecordNumber_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxRecordNumber.Text, out int NewRecordNumber))
            {
                if (NewRecordNumber < 0)
                {
                    TextBoxRecordNumber.BackColor = Color.LightPink;
                }
                else if (NewRecordNumber > 0)
                {
                    TextBoxRecordNumber.BackColor = Color.White;
                   
                }
            }

            else if (TextBoxRecordNumber.Text == "")
            {
                TextBoxRecordNumber.BackColor = Color.White;
            }

            else
            {
                TextBoxRecordNumber.BackColor = Color.LightPink;
            }

            if (TextBoxRecordNumber.Text.Length > 6)
            {
                MessageBox.Show("Номер зачетки должен содержать ровно шесть символов");
            }
        }

        private void AddButonStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxFullName.Text) || string.IsNullOrEmpty(TextBoxRecordNumber.Text) || string.IsNullOrEmpty(TextBoxGroupNumber.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student Student = new Student(TextBoxFullName.Text,  TextBoxGroupNumber.Text, (Facultet)comboBoxEducation.SelectedItem, (StudentFormOfStudy)comboBoxFormStudyStudent.SelectedItem, int.Parse(TextBoxRecordNumber.Text));
            Students.Add(Student);
            UpdateStudentList();
            ClearInfoListBox();
        }
        private void UpdateStudentList()
        {
            listBoxStudent.Items.Clear();
            listBoxStudent.Items.AddRange(Students.ToArray());
            if (_currentStudent == null) return;
            object[] booksObj = new object[Students.Count];
            listBoxStudent.Items.CopyTo(booksObj, 0);
            List<Student> books = booksObj.Cast<Student>().ToList();
            books.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            listBoxStudent.Items.Clear();
            listBoxStudent.Items.AddRange(books.Cast<object>().ToArray());
            Students.Clear();
            Students.AddRange(books);
            listBoxStudent.SelectedItem = _currentStudent;
        }

        private void ClearInfoListBox()
        {
            TextBoxFullName.Clear();
            TextBoxGroupNumber.Clear();
            TextBoxRecordNumber.Clear();
            comboBoxEducation.SelectedIndex  = 0;
            comboBoxFormStudyStudent.SelectedIndex = 0;
        }

        private void TextBoxFullName_TextChanged(object sender, EventArgs e)
        {
            string OrigText = TextBoxFullName.Text;
            string CurrentText = "";
            foreach (char s in OrigText)
            {
                if (char.IsLetter(s) || s == ' ')
                {
                    CurrentText += s;
                }
            }

            TextBoxFullName.Text = CurrentText;
            TextBoxFullName.Select(TextBoxFullName.Text.Length, 0);
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStudent.SelectedIndex != -1)
            {
                _currentStudent = Students[listBoxStudent.SelectedIndex];
                TextBoxFullName.Text = _currentStudent._fullName;
                TextBoxGroupNumber.Text = _currentStudent._numberGroup;
                TextBoxRecordNumber.Text = _currentStudent.StudentId.ToString();
                comboBoxEducation.SelectedItem = _currentStudent.Facultet;
                comboBoxFormStudyStudent.SelectedItem = _currentStudent.StudentFormOfStudy;

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listBoxStudent.SelectedIndex != -1)
            {
                _currentStudent = Students[listBoxStudent.SelectedIndex];
                _currentStudent._fullName = TextBoxFullName.Text;
                _currentStudent._numberGroup = TextBoxGroupNumber.Text;
                TextBoxRecordNumber.Text = _currentStudent.StudentId.ToString();
                _currentStudent.Facultet = (Facultet)comboBoxEducation.SelectedItem;
                _currentStudent.StudentFormOfStudy = (StudentFormOfStudy)comboBoxFormStudyStudent.SelectedItem;
                UpdateStudentList();
                ClearInfoListBox();
            }
        }

        private void RemoveButonStudent_Click(object sender, EventArgs e)
        {
            if (listBoxStudent.SelectedIndex != -1)
            {
                
                _currentStudent = Students[listBoxStudent.SelectedIndex];
                Students.RemoveAt(listBoxStudent.SelectedIndex);
                listBoxStudent.Items.RemoveAt(listBoxStudent.SelectedIndex);
                ClearInfoListBox();
                UpdateStudentList();
            }
        }
    }
}
