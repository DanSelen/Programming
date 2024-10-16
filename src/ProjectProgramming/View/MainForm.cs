﻿using ProjectProgramming.Model;
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
        //Модуль Rectangles
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangles;
        private string[] _listboxRectangle = new string[5];
        Random random = new Random();
        private string[] _collorsArray = { "Red", "Blue", "Green", "Yellow", "Black", "White", "Purple" };

        //Модуль Movies
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        private string[] _listboxMovies = new string[5];

        //tabPage Rectangles
        private List<Rectangle> _canvaRectangles = new List<Rectangle>();
        private Rectangle _canvaCurrentRectangle;

        //
        private List<Panel> _rectanglePanels = new List<Panel>();


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
            //Модуль Movie
            for (int i = 0; i < _listboxMovies.Length; i++)
            {
                // Генерируем случайные значения для каждого параметра фильма
                _listboxMovies[i] = ($"Movie {i + 1}");
                string name = _listboxMovies[i];
                int duration = random.Next(60, 180); // Продолжительность в минутах (от 60 до 180)
                int year = random.Next(1990, 2023); // Год выпуска (от 1990 до 2022)
                int rating = random.Next(1, 11); // Рейтинг (от 1 до 10)
                string[] genres = { "Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Thriller" };
                string genre = genres[random.Next(genres.Length)]; // Случайный жанр из списка
                _movies[i] = new Movie(name, duration, year, rating, genre);

            }
            MoviesListBox.Items.AddRange(_listboxMovies);

            //Модуль Rectangles
            for (int i = 0; i < _listboxRectangle.Length; i++)
            {
                // Генерация случайной длины и ширины прямоугольника
                double length = random.Next(1, 20);
                double width = random.Next(1, 20);
                int colorRandomIndex = random.Next(0, _collorsArray.Length - 1);
                double x = random.Next(1, 10);
                double y = random.Next(1, 10);
                Point2D coordinatesOfRectangle = new Point2D(x, y);

                _rectangles[i] = new Rectangle(length, width, coordinatesOfRectangle, _collorsArray[colorRandomIndex]);
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
            if (RectanglesListBox.SelectedIndex >= 0)
                _currentRectangles = _rectangles[RectanglesListBox.SelectedIndex];
            if (_currentRectangles != null)
            {
                LengthTextBox.Text = _currentRectangles.Length.ToString();
                WidthTextBox.Text = _currentRectangles.Width.ToString();
                ColorTextBox.Text = _currentRectangles.Color.ToString();
                CenterXTextBox.Text = _currentRectangles.Center.X.ToString();
                CenterYTextbox.Text = _currentRectangles.Center.Y.ToString();
                IdTextBox.Text = _currentRectangles.Id.ToString();
            }
            else
            {
                // Обработка ситуации, когда _currentRectangles равен null
                // Можно очистить текстовые поля или установить сообщение об ошибке
            }
            /*LengthTextBox.Text = _currentRectangles.Length.ToString();
            WidthTextBox.Text = _currentRectangles.Width.ToString();
            ColorTextBox.Text = _currentRectangles.Color.ToString();
            */
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumbInput(LengthTextBox);
            if (_currentRectangles != null)
            {
                try
                {
                    _currentRectangles.Length = Convert.ToDouble(LengthTextBox.Text);
                }
                catch
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumbInput(WidthTextBox);
            if (_currentRectangles != null)
            {
                try
                {
                    _currentRectangles.Width = Convert.ToDouble(WidthTextBox.Text);
                }
                catch
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(ColorTextBox);
            if (_currentRectangles != null)
            {
                try
                {
                    _currentRectangles.Color = Convert.ToString(ColorTextBox.Text);
                }
                catch
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }
        private void ValidateNumbInput(TextBox textBox)
        {
            try
            {
                // Пробуем конвертировать текст в число
                double value = double.Parse(textBox.Text);

                // Проверяем, что число входит в допустимый диапазон
                if (value < 0)
                {
                    throw new ArgumentException("Число меньше 0");
                }

                // Если ошибок нет, устанавливаем белый цвет фона
                textBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                // Если введенное значение не может быть преобразовано в число,
                // подсвечиваем фон текстового поля красным цветом
                textBox.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                // Если число выходит за допустимый диапазон,
                // подсвечиваем фон текстового поля красным цветом
                textBox.BackColor = Color.LightPink;

                // Выводим сообщение об ошибке
                //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidateInput(TextBox textBox)
        {
            try
            {
                // Пробуем конвертировать текст в число
                string value = Convert.ToString(textBox.Text);

                // Проверяем, что число входит в допустимый диапазон
                if (value.Length == 0)
                {
                    throw new ArgumentException("Поле являетсся пустым");
                }

                // Если ошибок нет, устанавливаем белый цвет фона
                textBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                // Если число выходит за допустимый диапазон,
                // подсвечиваем фон текстового поля красным цветом
                textBox.BackColor = Color.LightPink;

                // Выводим сообщение об ошибке
                //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
                throw new ArgumentException("Массив прямоугольников не может быть пустым.");

            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void RectanglesFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedItem = FindRectangleWithMaxWidth(_rectangles);
            //MessageBox.Show(""+ FindRectangleWithMaxWidth(_rectangles));
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);

        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
            if (_currentMovie != null)
            {
                movieNameTextBox.Text = _currentMovie.Name.ToString();
                movieRatingTextBox.Text = _currentMovie.Rating.ToString();
                movieDurationTextBox.Text = _currentMovie.Duration.ToString();
                movieGenreTextBox.Text = _currentMovie.Genre.ToString();
                movieYearTextBox.Text = _currentMovie.Year.ToString();

            }
        }

        private void movieFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedItem = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            if (movies == null || movies.Length == 0)
                throw new ArgumentException("Массив фильмов не может быть пустым.");

            int maxIndex = 0;
            int maxRating = movies[0].Rating;

            for (int i = 1; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void movieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumbInput(movieYearTextBox);
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Year = Convert.ToInt32(movieYearTextBox.Text);
                }
                catch (ArgumentException)
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
                catch
                {

                }
            }
        }

        private void movieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumbInput(movieDurationTextBox);
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Duration = Convert.ToInt32(movieDurationTextBox.Text);
                }
                catch (FormatException)
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }

        private void movieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumbInput(movieRatingTextBox);
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Rating = Convert.ToInt32(movieRatingTextBox.Text);
                }
                catch (ArgumentOutOfRangeException)
                {
                    movieRatingTextBox.BackColor = Color.LightPink;
                }
                catch (FormatException)
                {

                }
                catch (ArgumentException)
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }

        private void movieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(movieNameTextBox);
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Name = Convert.ToString(movieNameTextBox.Text);
                }
                catch
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }

        private void movieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(movieGenreTextBox);
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Genre = Convert.ToString(movieGenreTextBox.Text);
                }
                catch
                {
                    // обработаем это исключение здесь или оставим без обработки
                    // обработка уже произведена в методе ValidateInput
                }
            }
        }

        private void CenterYTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Отменяем нажатия клавиш
        }

        private void CenterXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Отменяем нажатия клавиш
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Обработчик события кнопки "Добавить прямоугольник"
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {

            // Генерируем случайные значения для координат и размеров прямоугольника
            Random random = new Random();
            int x = random.Next(1, 100); 
            int y = random.Next(1, 100); 
            int width = random.Next(1, 300); 
            int length = random.Next(1, 300); 

            // Создаем новый прямоугольник и добавляем его в список прямоугольников
            Rectangle newRectangle = new Rectangle(length, width, new Point2D(x, y), "");
            _canvaRectangles.Add(newRectangle);

            // Добавляем созданный прямоугольник в ListBox
            ClassRectanglesListBox.Items.Add(newRectangle);

            // Создаем новую панель для отображения прямоугольника
            Panel rectanglePanel = new Panel();

            // Устанавливаем размеры и положение панели в соответствии с прямоугольником
            rectanglePanel.Location = new Point(x, y);
            rectanglePanel.Size = new Size(width, length);

            // Устанавливаем цвет фона панели
            rectanglePanel.BackColor = Color.FromArgb(127, 127, 255, 127);

            // Добавляем созданную панель на канву
            RectanglePanel.Controls.Add(rectanglePanel);

            // Добавляем созданную панель в список _rectanglePanels
            _rectanglePanels.Add(rectanglePanel);


        }



        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (ClassRectanglesListBox.SelectedItem != null)
            {
                
                _canvaCurrentRectangle = (Rectangle)ClassRectanglesListBox.SelectedItem;
                _canvaRectangles.Remove(_canvaCurrentRectangle);
                RectanglePanel.Controls.RemoveAt(ClassRectanglesListBox.SelectedIndex);
                ClassRectanglesListBox.Items.Remove(_canvaCurrentRectangle);
                IdPanelTextBox.Clear();
                IdPanelTextBox.BackColor = Color.White;
                XPanelTextBox.Clear();
                YPanelTextBox.Clear();
                WidthPanelTextBox.Clear();
                HeightPanelTextBox.Clear();
                IdPanelTextBox.BackColor = Color.White;
                XPanelTextBox.BackColor = Color.White;
                YPanelTextBox.BackColor = Color.White;
                WidthPanelTextBox.BackColor = Color.White;
                HeightPanelTextBox.BackColor = Color.White;
               

            }

        }

        private void ClassRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбран ли какой-либо элемент в ListBox
            if (ClassRectanglesListBox.SelectedItem != null)
            {
                // Получаем выбранный прямоугольник из ListBox
                _canvaCurrentRectangle = (Rectangle)ClassRectanglesListBox.SelectedItem;

                // Отображаем свойства выбранного прямоугольника в соответствующих элементах управления
                IdPanelTextBox.Text = _canvaCurrentRectangle.Id.ToString();
                XPanelTextBox.Text = _canvaCurrentRectangle.Coordinates.X.ToString();
                YPanelTextBox.Text = _canvaCurrentRectangle.Coordinates.Y.ToString();
                WidthPanelTextBox.Text = _canvaCurrentRectangle.Width.ToString();
                HeightPanelTextBox.Text = _canvaCurrentRectangle.Length.ToString();
            }
        }

        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(XPanelTextBox);
            if (_canvaCurrentRectangle != null)
            {
                Rectangle selectedRectangle = (Rectangle)ClassRectanglesListBox.SelectedItem;

                try
                { _canvaCurrentRectangle.Coordinates.X = Convert.ToDouble(XPanelTextBox.Text); }
                catch
                {
                    XPanelTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(YPanelTextBox);
            if (_canvaCurrentRectangle != null)
            {
                Rectangle selectedRectangle = (Rectangle)ClassRectanglesListBox.SelectedItem;

                try
                { _canvaCurrentRectangle.Coordinates.Y = Convert.ToDouble(YPanelTextBox.Text); }
                catch
                {
                    YPanelTextBox.BackColor = Color.LightPink;
                }

            }
        }
        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(WidthPanelTextBox);
            if (_canvaCurrentRectangle != null)
            {
                Rectangle selectedRectangle = (Rectangle)ClassRectanglesListBox.SelectedItem;

                try
                { _canvaCurrentRectangle.Width = Convert.ToDouble(WidthPanelTextBox.Text); }
                catch
                {
                    WidthPanelTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void HeigthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(HeightPanelTextBox);
            if (_canvaCurrentRectangle != null)
            {
                Rectangle selectedRectangle = (Rectangle)ClassRectanglesListBox.SelectedItem;

                try
                { _canvaCurrentRectangle.Length = Convert.ToDouble(HeightPanelTextBox.Text); }
                catch
                {
                    HeightPanelTextBox.BackColor = Color.LightPink;
                }
            }
        }
    }
}