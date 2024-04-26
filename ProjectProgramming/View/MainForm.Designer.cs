namespace ProjectProgramming
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.TypeValueForParsingLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumarationLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ChooseValueBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumerationBox = new System.Windows.Forms.ListBox();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoSeasonButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.movieGroupBox = new System.Windows.Forms.GroupBox();
            this.movieRatingTextBox = new System.Windows.Forms.TextBox();
            this.movieRatingLabel = new System.Windows.Forms.Label();
            this.movieDurationTextBox = new System.Windows.Forms.TextBox();
            this.movieDurationLabel = new System.Windows.Forms.Label();
            this.movieFindButton = new System.Windows.Forms.Button();
            this.movieGenreTextBox = new System.Windows.Forms.TextBox();
            this.movieYearTextBox = new System.Windows.Forms.TextBox();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.movieGenreLabel = new System.Windows.Forms.Label();
            this.movieYearLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.rectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CenterYTextbox = new System.Windows.Forms.TextBox();
            this.CenterXTextBox = new System.Windows.Forms.TextBox();
            this.CentrerLabel = new System.Windows.Forms.Label();
            this.RectanglesFindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.AddRectanglePanelButton = new System.Windows.Forms.Button();
            this.DeleteRectanglePanelButton = new System.Windows.Forms.Button();
            this.HeightPanelTextBox = new System.Windows.Forms.TextBox();
            this.XPanelTextBox = new System.Windows.Forms.TextBox();
            this.WidthPanelTextBox = new System.Windows.Forms.TextBox();
            this.YPanelTextBox = new System.Windows.Forms.TextBox();
            this.IdPanelTextBox = new System.Windows.Forms.TextBox();
            this.CoordinateYPanelLabel = new System.Windows.Forms.Label();
            this.CoordinateXPanelLabel = new System.Windows.Forms.Label();
            this.WidthPanelLabel = new System.Windows.Forms.Label();
            this.PanelRectangleIdLabel = new System.Windows.Forms.Label();
            this.HeightPanelLabel = new System.Windows.Forms.Label();
            this.PanelSelectedRectagleLabel = new System.Windows.Forms.Label();
            this.ClassRectanglesLabel = new System.Windows.Forms.Label();
            this.ClassRectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.movieGroupBox.SuspendLayout();
            this.rectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.EnumsTabPage);
            this.tabControl.Controls.Add(this.ClassesTabPage);
            this.tabControl.Controls.Add(this.RectanglesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 366);
            this.tabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationGroupBox);
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Size = new System.Drawing.Size(592, 340);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Tag = "";
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueForParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(2, 198);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(282, 140);
            this.WeekdayParsingGroupBox.TabIndex = 3;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(21, 73);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(96, 13);
            this.WeekdayParsingLabel.TabIndex = 3;
            this.WeekdayParsingLabel.Text = "Этот день недели";
            // 
            // TypeValueForParsingLabel
            // 
            this.TypeValueForParsingLabel.AutoSize = true;
            this.TypeValueForParsingLabel.Location = new System.Drawing.Point(21, 34);
            this.TypeValueForParsingLabel.Name = "TypeValueForParsingLabel";
            this.TypeValueForParsingLabel.Size = new System.Drawing.Size(118, 13);
            this.TypeValueForParsingLabel.TabIndex = 2;
            this.TypeValueForParsingLabel.Text = "Type value for parsing: ";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(180, 50);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 1;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(20, 50);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(154, 20);
            this.ParseTextBox.TabIndex = 0;
            // 
            // EnumerationGroupBox
            // 
            this.EnumerationGroupBox.AutoSize = true;
            this.EnumerationGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationGroupBox.Controls.Add(this.ChooseEnumarationLabel);
            this.EnumerationGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationGroupBox.Controls.Add(this.ChooseValueBox);
            this.EnumerationGroupBox.Controls.Add(this.ChooseEnumerationBox);
            this.EnumerationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumerationGroupBox.Location = new System.Drawing.Point(2, 2);
            this.EnumerationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumerationGroupBox.Size = new System.Drawing.Size(588, 196);
            this.EnumerationGroupBox.TabIndex = 0;
            this.EnumerationGroupBox.TabStop = false;
            this.EnumerationGroupBox.Text = "Enumarations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(292, 17);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(54, 13);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value: ";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(155, 17);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumarationLabel
            // 
            this.ChooseEnumarationLabel.AutoSize = true;
            this.ChooseEnumarationLabel.Location = new System.Drawing.Point(2, 17);
            this.ChooseEnumarationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseEnumarationLabel.Name = "ChooseEnumarationLabel";
            this.ChooseEnumarationLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumarationLabel.TabIndex = 3;
            this.ChooseEnumarationLabel.Text = "Choose enumaration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(295, 32);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(76, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ChooseValueBox
            // 
            this.ChooseValueBox.FormattingEnabled = true;
            this.ChooseValueBox.Location = new System.Drawing.Point(158, 32);
            this.ChooseValueBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseValueBox.Name = "ChooseValueBox";
            this.ChooseValueBox.Size = new System.Drawing.Size(124, 147);
            this.ChooseValueBox.TabIndex = 1;
            this.ChooseValueBox.SelectedIndexChanged += new System.EventHandler(this.ChooseValueBox_SelectedIndexChanged);
            // 
            // ChooseEnumerationBox
            // 
            this.ChooseEnumerationBox.FormattingEnabled = true;
            this.ChooseEnumerationBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Season",
            "SmartphoneManufactures",
            "Weekday"});
            this.ChooseEnumerationBox.Location = new System.Drawing.Point(4, 32);
            this.ChooseEnumerationBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseEnumerationBox.Name = "ChooseEnumerationBox";
            this.ChooseEnumerationBox.Size = new System.Drawing.Size(116, 147);
            this.ChooseEnumerationBox.TabIndex = 0;
            this.ChooseEnumerationBox.SelectedIndexChanged += new System.EventHandler(this.ChooseEnumerationBox_SelectedIndexChanged);
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.GoSeasonButton);
            this.SeasonGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(289, 198);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(303, 142);
            this.SeasonGroupBox.TabIndex = 4;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(8, 45);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(92, 21);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // GoSeasonButton
            // 
            this.GoSeasonButton.Location = new System.Drawing.Point(117, 45);
            this.GoSeasonButton.Name = "GoSeasonButton";
            this.GoSeasonButton.Size = new System.Drawing.Size(75, 23);
            this.GoSeasonButton.TabIndex = 2;
            this.GoSeasonButton.Text = "Go!";
            this.GoSeasonButton.UseVisualStyleBackColor = true;
            this.GoSeasonButton.Click += new System.EventHandler(this.GoSeasonButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(8, 29);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseSeasonLabel.TabIndex = 0;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.movieGroupBox);
            this.ClassesTabPage.Controls.Add(this.rectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Size = new System.Drawing.Size(592, 340);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // movieGroupBox
            // 
            this.movieGroupBox.Controls.Add(this.movieRatingTextBox);
            this.movieGroupBox.Controls.Add(this.movieRatingLabel);
            this.movieGroupBox.Controls.Add(this.movieDurationTextBox);
            this.movieGroupBox.Controls.Add(this.movieDurationLabel);
            this.movieGroupBox.Controls.Add(this.movieFindButton);
            this.movieGroupBox.Controls.Add(this.movieGenreTextBox);
            this.movieGroupBox.Controls.Add(this.movieYearTextBox);
            this.movieGroupBox.Controls.Add(this.movieNameTextBox);
            this.movieGroupBox.Controls.Add(this.movieGenreLabel);
            this.movieGroupBox.Controls.Add(this.movieYearLabel);
            this.movieGroupBox.Controls.Add(this.movieNameLabel);
            this.movieGroupBox.Controls.Add(this.MoviesListBox);
            this.movieGroupBox.Location = new System.Drawing.Point(296, 5);
            this.movieGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieGroupBox.Name = "movieGroupBox";
            this.movieGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.movieGroupBox.Size = new System.Drawing.Size(289, 333);
            this.movieGroupBox.TabIndex = 1;
            this.movieGroupBox.TabStop = false;
            this.movieGroupBox.Text = "Movie";
            // 
            // movieRatingTextBox
            // 
            this.movieRatingTextBox.Location = new System.Drawing.Point(181, 212);
            this.movieRatingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieRatingTextBox.Name = "movieRatingTextBox";
            this.movieRatingTextBox.Size = new System.Drawing.Size(76, 20);
            this.movieRatingTextBox.TabIndex = 11;
            this.movieRatingTextBox.TextChanged += new System.EventHandler(this.movieRatingTextBox_TextChanged);
            // 
            // movieRatingLabel
            // 
            this.movieRatingLabel.AutoSize = true;
            this.movieRatingLabel.Location = new System.Drawing.Point(178, 196);
            this.movieRatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieRatingLabel.Name = "movieRatingLabel";
            this.movieRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.movieRatingLabel.TabIndex = 10;
            this.movieRatingLabel.Text = "Rating:";
            // 
            // movieDurationTextBox
            // 
            this.movieDurationTextBox.Location = new System.Drawing.Point(181, 174);
            this.movieDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieDurationTextBox.Name = "movieDurationTextBox";
            this.movieDurationTextBox.Size = new System.Drawing.Size(76, 20);
            this.movieDurationTextBox.TabIndex = 9;
            this.movieDurationTextBox.TextChanged += new System.EventHandler(this.movieDurationTextBox_TextChanged);
            // 
            // movieDurationLabel
            // 
            this.movieDurationLabel.AutoSize = true;
            this.movieDurationLabel.Location = new System.Drawing.Point(178, 158);
            this.movieDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieDurationLabel.Name = "movieDurationLabel";
            this.movieDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.movieDurationLabel.TabIndex = 8;
            this.movieDurationLabel.Text = "Duration:";
            // 
            // movieFindButton
            // 
            this.movieFindButton.Location = new System.Drawing.Point(182, 241);
            this.movieFindButton.Margin = new System.Windows.Forms.Padding(2);
            this.movieFindButton.Name = "movieFindButton";
            this.movieFindButton.Size = new System.Drawing.Size(75, 19);
            this.movieFindButton.TabIndex = 7;
            this.movieFindButton.Text = "Find";
            this.movieFindButton.UseVisualStyleBackColor = true;
            this.movieFindButton.Click += new System.EventHandler(this.movieFindButton_Click);
            // 
            // movieGenreTextBox
            // 
            this.movieGenreTextBox.Location = new System.Drawing.Point(181, 133);
            this.movieGenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieGenreTextBox.Name = "movieGenreTextBox";
            this.movieGenreTextBox.Size = new System.Drawing.Size(76, 20);
            this.movieGenreTextBox.TabIndex = 6;
            this.movieGenreTextBox.TextChanged += new System.EventHandler(this.movieGenreTextBox_TextChanged);
            // 
            // movieYearTextBox
            // 
            this.movieYearTextBox.Location = new System.Drawing.Point(181, 91);
            this.movieYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieYearTextBox.Name = "movieYearTextBox";
            this.movieYearTextBox.Size = new System.Drawing.Size(76, 20);
            this.movieYearTextBox.TabIndex = 5;
            this.movieYearTextBox.TextChanged += new System.EventHandler(this.movieYearTextBox_TextChanged);
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Location = new System.Drawing.Point(181, 50);
            this.movieNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.movieNameTextBox.TabIndex = 4;
            this.movieNameTextBox.TextChanged += new System.EventHandler(this.movieNameTextBox_TextChanged);
            // 
            // movieGenreLabel
            // 
            this.movieGenreLabel.AutoSize = true;
            this.movieGenreLabel.Location = new System.Drawing.Point(178, 117);
            this.movieGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieGenreLabel.Name = "movieGenreLabel";
            this.movieGenreLabel.Size = new System.Drawing.Size(39, 13);
            this.movieGenreLabel.TabIndex = 3;
            this.movieGenreLabel.Text = "Genre:";
            // 
            // movieYearLabel
            // 
            this.movieYearLabel.AutoSize = true;
            this.movieYearLabel.Location = new System.Drawing.Point(178, 75);
            this.movieYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieYearLabel.Name = "movieYearLabel";
            this.movieYearLabel.Size = new System.Drawing.Size(32, 13);
            this.movieYearLabel.TabIndex = 2;
            this.movieYearLabel.Text = "Year:";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Location = new System.Drawing.Point(178, 35);
            this.movieNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(38, 13);
            this.movieNameLabel.TabIndex = 1;
            this.movieNameLabel.Text = "Name:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(18, 35);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(138, 225);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // rectanglesGroupBox
            // 
            this.rectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.rectanglesGroupBox.Controls.Add(this.IdLabel);
            this.rectanglesGroupBox.Controls.Add(this.CenterYTextbox);
            this.rectanglesGroupBox.Controls.Add(this.CenterXTextBox);
            this.rectanglesGroupBox.Controls.Add(this.CentrerLabel);
            this.rectanglesGroupBox.Controls.Add(this.RectanglesFindButton);
            this.rectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.rectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.label3);
            this.rectanglesGroupBox.Controls.Add(this.label2);
            this.rectanglesGroupBox.Controls.Add(this.label1);
            this.rectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.rectanglesGroupBox.Location = new System.Drawing.Point(6, 5);
            this.rectanglesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rectanglesGroupBox.Name = "rectanglesGroupBox";
            this.rectanglesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rectanglesGroupBox.Size = new System.Drawing.Size(289, 328);
            this.rectanglesGroupBox.TabIndex = 0;
            this.rectanglesGroupBox.TabStop = false;
            this.rectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(252, 212);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(32, 20);
            this.IdTextBox.TabIndex = 12;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(250, 196);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "Id:";
            // 
            // CenterYTextbox
            // 
            this.CenterYTextbox.Location = new System.Drawing.Point(208, 212);
            this.CenterYTextbox.Name = "CenterYTextbox";
            this.CenterYTextbox.Size = new System.Drawing.Size(27, 20);
            this.CenterYTextbox.TabIndex = 10;
            this.CenterYTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CenterYTextbox_KeyPress);
            // 
            // CenterXTextBox
            // 
            this.CenterXTextBox.Location = new System.Drawing.Point(164, 212);
            this.CenterXTextBox.Name = "CenterXTextBox";
            this.CenterXTextBox.Size = new System.Drawing.Size(27, 20);
            this.CenterXTextBox.TabIndex = 9;
            this.CenterXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CenterXTextBox_KeyPress);
            // 
            // CentrerLabel
            // 
            this.CentrerLabel.AutoSize = true;
            this.CentrerLabel.Location = new System.Drawing.Point(160, 196);
            this.CentrerLabel.Name = "CentrerLabel";
            this.CentrerLabel.Size = new System.Drawing.Size(78, 13);
            this.CentrerLabel.TabIndex = 8;
            this.CentrerLabel.Text = "Center x and y:";
            // 
            // RectanglesFindButton
            // 
            this.RectanglesFindButton.Location = new System.Drawing.Point(182, 240);
            this.RectanglesFindButton.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesFindButton.Name = "RectanglesFindButton";
            this.RectanglesFindButton.Size = new System.Drawing.Size(75, 19);
            this.RectanglesFindButton.TabIndex = 7;
            this.RectanglesFindButton.Text = "Find";
            this.RectanglesFindButton.UseVisualStyleBackColor = true;
            this.RectanglesFindButton.Click += new System.EventHandler(this.RectanglesFindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(182, 151);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(76, 20);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(181, 100);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(76, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(182, 50);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(76, 20);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenght:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(18, 35);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(138, 225);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.AddRectanglePanelButton);
            this.RectanglesTabPage.Controls.Add(this.DeleteRectanglePanelButton);
            this.RectanglesTabPage.Controls.Add(this.HeightPanelTextBox);
            this.RectanglesTabPage.Controls.Add(this.XPanelTextBox);
            this.RectanglesTabPage.Controls.Add(this.WidthPanelTextBox);
            this.RectanglesTabPage.Controls.Add(this.YPanelTextBox);
            this.RectanglesTabPage.Controls.Add(this.IdPanelTextBox);
            this.RectanglesTabPage.Controls.Add(this.CoordinateYPanelLabel);
            this.RectanglesTabPage.Controls.Add(this.CoordinateXPanelLabel);
            this.RectanglesTabPage.Controls.Add(this.WidthPanelLabel);
            this.RectanglesTabPage.Controls.Add(this.PanelRectangleIdLabel);
            this.RectanglesTabPage.Controls.Add(this.HeightPanelLabel);
            this.RectanglesTabPage.Controls.Add(this.PanelSelectedRectagleLabel);
            this.RectanglesTabPage.Controls.Add(this.ClassRectanglesLabel);
            this.RectanglesTabPage.Controls.Add(this.ClassRectanglesListBox);
            this.RectanglesTabPage.Controls.Add(this.RectanglePanel);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.RectanglesTabPage.Size = new System.Drawing.Size(592, 340);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectagles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // AddRectanglePanelButton
            // 
            this.AddRectanglePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectanglePanelButton.Location = new System.Drawing.Point(108, 154);
            this.AddRectanglePanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRectanglePanelButton.Name = "AddRectanglePanelButton";
            this.AddRectanglePanelButton.Size = new System.Drawing.Size(65, 25);
            this.AddRectanglePanelButton.TabIndex = 15;
            this.AddRectanglePanelButton.Text = "Add";
            this.AddRectanglePanelButton.UseVisualStyleBackColor = true;
            this.AddRectanglePanelButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // DeleteRectanglePanelButton
            // 
            this.DeleteRectanglePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRectanglePanelButton.Location = new System.Drawing.Point(29, 154);
            this.DeleteRectanglePanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteRectanglePanelButton.Name = "DeleteRectanglePanelButton";
            this.DeleteRectanglePanelButton.Size = new System.Drawing.Size(65, 25);
            this.DeleteRectanglePanelButton.TabIndex = 14;
            this.DeleteRectanglePanelButton.Text = "Delete";
            this.DeleteRectanglePanelButton.UseVisualStyleBackColor = true;
            this.DeleteRectanglePanelButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // HeightPanelTextBox
            // 
            this.HeightPanelTextBox.Location = new System.Drawing.Point(47, 315);
            this.HeightPanelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightPanelTextBox.Name = "HeightPanelTextBox";
            this.HeightPanelTextBox.Size = new System.Drawing.Size(76, 20);
            this.HeightPanelTextBox.TabIndex = 13;
            // 
            // XPanelTextBox
            // 
            this.XPanelTextBox.Location = new System.Drawing.Point(47, 230);
            this.XPanelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XPanelTextBox.Name = "XPanelTextBox";
            this.XPanelTextBox.Size = new System.Drawing.Size(76, 20);
            this.XPanelTextBox.TabIndex = 12;
            // 
            // WidthPanelTextBox
            // 
            this.WidthPanelTextBox.Location = new System.Drawing.Point(47, 287);
            this.WidthPanelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthPanelTextBox.Name = "WidthPanelTextBox";
            this.WidthPanelTextBox.Size = new System.Drawing.Size(76, 20);
            this.WidthPanelTextBox.TabIndex = 11;
            // 
            // YPanelTextBox
            // 
            this.YPanelTextBox.Location = new System.Drawing.Point(47, 258);
            this.YPanelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YPanelTextBox.Name = "YPanelTextBox";
            this.YPanelTextBox.Size = new System.Drawing.Size(76, 20);
            this.YPanelTextBox.TabIndex = 10;
            // 
            // IdPanelTextBox
            // 
            this.IdPanelTextBox.Location = new System.Drawing.Point(47, 202);
            this.IdPanelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdPanelTextBox.Name = "IdPanelTextBox";
            this.IdPanelTextBox.Size = new System.Drawing.Size(76, 20);
            this.IdPanelTextBox.TabIndex = 9;
            // 
            // CoordinateYPanelLabel
            // 
            this.CoordinateYPanelLabel.AutoSize = true;
            this.CoordinateYPanelLabel.Location = new System.Drawing.Point(28, 263);
            this.CoordinateYPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoordinateYPanelLabel.Name = "CoordinateYPanelLabel";
            this.CoordinateYPanelLabel.Size = new System.Drawing.Size(17, 13);
            this.CoordinateYPanelLabel.TabIndex = 8;
            this.CoordinateYPanelLabel.Text = "Y:";
            // 
            // CoordinateXPanelLabel
            // 
            this.CoordinateXPanelLabel.AutoSize = true;
            this.CoordinateXPanelLabel.Location = new System.Drawing.Point(29, 235);
            this.CoordinateXPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoordinateXPanelLabel.Name = "CoordinateXPanelLabel";
            this.CoordinateXPanelLabel.Size = new System.Drawing.Size(17, 13);
            this.CoordinateXPanelLabel.TabIndex = 7;
            this.CoordinateXPanelLabel.Text = "X:";
            // 
            // WidthPanelLabel
            // 
            this.WidthPanelLabel.AutoSize = true;
            this.WidthPanelLabel.Location = new System.Drawing.Point(10, 289);
            this.WidthPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthPanelLabel.Name = "WidthPanelLabel";
            this.WidthPanelLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthPanelLabel.TabIndex = 6;
            this.WidthPanelLabel.Text = "Width:";
            // 
            // PanelRectangleIdLabel
            // 
            this.PanelRectangleIdLabel.AutoSize = true;
            this.PanelRectangleIdLabel.Location = new System.Drawing.Point(27, 206);
            this.PanelRectangleIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PanelRectangleIdLabel.Name = "PanelRectangleIdLabel";
            this.PanelRectangleIdLabel.Size = new System.Drawing.Size(19, 13);
            this.PanelRectangleIdLabel.TabIndex = 5;
            this.PanelRectangleIdLabel.Text = "Id:";
            // 
            // HeightPanelLabel
            // 
            this.HeightPanelLabel.AutoSize = true;
            this.HeightPanelLabel.Location = new System.Drawing.Point(6, 318);
            this.HeightPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightPanelLabel.Name = "HeightPanelLabel";
            this.HeightPanelLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightPanelLabel.TabIndex = 4;
            this.HeightPanelLabel.Text = "Height:";
            // 
            // PanelSelectedRectagleLabel
            // 
            this.PanelSelectedRectagleLabel.AutoSize = true;
            this.PanelSelectedRectagleLabel.Location = new System.Drawing.Point(6, 186);
            this.PanelSelectedRectagleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PanelSelectedRectagleLabel.Name = "PanelSelectedRectagleLabel";
            this.PanelSelectedRectagleLabel.Size = new System.Drawing.Size(104, 13);
            this.PanelSelectedRectagleLabel.TabIndex = 3;
            this.PanelSelectedRectagleLabel.Text = "Selected Rectangle:";
            // 
            // ClassRectanglesLabel
            // 
            this.ClassRectanglesLabel.AutoSize = true;
            this.ClassRectanglesLabel.Location = new System.Drawing.Point(4, 13);
            this.ClassRectanglesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassRectanglesLabel.Name = "ClassRectanglesLabel";
            this.ClassRectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.ClassRectanglesLabel.TabIndex = 2;
            this.ClassRectanglesLabel.Text = "Rectangles:";
            // 
            // ClassRectanglesListBox
            // 
            this.ClassRectanglesListBox.FormattingEnabled = true;
            this.ClassRectanglesListBox.Location = new System.Drawing.Point(2, 29);
            this.ClassRectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassRectanglesListBox.Name = "ClassRectanglesListBox";
            this.ClassRectanglesListBox.Size = new System.Drawing.Size(190, 121);
            this.ClassRectanglesListBox.TabIndex = 1;
            this.ClassRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.ClassRectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglePanel.Location = new System.Drawing.Point(215, 5);
            this.RectanglePanel.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(373, 331);
            this.RectanglePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsTabPage.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationGroupBox.ResumeLayout(false);
            this.EnumerationGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.movieGroupBox.ResumeLayout(false);
            this.movieGroupBox.PerformLayout();
            this.rectanglesGroupBox.ResumeLayout(false);
            this.rectanglesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationGroupBox;
        private System.Windows.Forms.ListBox ChooseValueBox;
        private System.Windows.Forms.ListBox ChooseEnumerationBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumarationLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.TextBox ParseTextBox;
        private System.Windows.Forms.Label WeekdayParsingLabel;
        private System.Windows.Forms.Label TypeValueForParsingLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.Button GoSeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox rectanglesGroupBox;
        private System.Windows.Forms.Button RectanglesFindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.GroupBox movieGroupBox;
        private System.Windows.Forms.Button movieFindButton;
        private System.Windows.Forms.TextBox movieGenreTextBox;
        private System.Windows.Forms.TextBox movieYearTextBox;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.Label movieGenreLabel;
        private System.Windows.Forms.Label movieYearLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TextBox movieRatingTextBox;
        private System.Windows.Forms.Label movieRatingLabel;
        private System.Windows.Forms.TextBox movieDurationTextBox;
        private System.Windows.Forms.Label movieDurationLabel;
        private System.Windows.Forms.TextBox CenterXTextBox;
        private System.Windows.Forms.Label CentrerLabel;
        private System.Windows.Forms.TextBox CenterYTextbox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.Label ClassRectanglesLabel;
        private System.Windows.Forms.ListBox ClassRectanglesListBox;
        private System.Windows.Forms.Panel RectanglePanel;
        private System.Windows.Forms.Label CoordinateYPanelLabel;
        private System.Windows.Forms.Label CoordinateXPanelLabel;
        private System.Windows.Forms.Label WidthPanelLabel;
        private System.Windows.Forms.Label PanelRectangleIdLabel;
        private System.Windows.Forms.Label HeightPanelLabel;
        private System.Windows.Forms.Label PanelSelectedRectagleLabel;
        private System.Windows.Forms.TextBox HeightPanelTextBox;
        private System.Windows.Forms.TextBox XPanelTextBox;
        private System.Windows.Forms.TextBox WidthPanelTextBox;
        private System.Windows.Forms.TextBox YPanelTextBox;
        private System.Windows.Forms.TextBox IdPanelTextBox;
        private System.Windows.Forms.Button AddRectanglePanelButton;
        private System.Windows.Forms.Button DeleteRectanglePanelButton;
    }
}

