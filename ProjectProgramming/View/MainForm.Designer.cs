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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.rectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesFindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.rectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnumsTabPage);
            this.tabControl1.Controls.Add(this.ClassesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationGroupBox);
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.EnumerationGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(76, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ChooseValueBox
            // 
            this.ChooseValueBox.FormattingEnabled = true;
            this.ChooseValueBox.Location = new System.Drawing.Point(158, 32);
            this.ChooseValueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ChooseEnumerationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ClassesTabPage.Controls.Add(this.rectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(592, 340);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesGroupBox
            // 
            this.rectanglesGroupBox.Controls.Add(this.RectanglesFindButton);
            this.rectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.rectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.label3);
            this.rectanglesGroupBox.Controls.Add(this.label2);
            this.rectanglesGroupBox.Controls.Add(this.label1);
            this.rectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.rectanglesGroupBox.Location = new System.Drawing.Point(6, 5);
            this.rectanglesGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rectanglesGroupBox.Name = "rectanglesGroupBox";
            this.rectanglesGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rectanglesGroupBox.Size = new System.Drawing.Size(289, 328);
            this.rectanglesGroupBox.TabIndex = 0;
            this.rectanglesGroupBox.TabStop = false;
            this.rectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesFindButton
            // 
            this.RectanglesFindButton.Location = new System.Drawing.Point(182, 240);
            this.RectanglesFindButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RectanglesFindButton.Name = "RectanglesFindButton";
            this.RectanglesFindButton.Size = new System.Drawing.Size(75, 19);
            this.RectanglesFindButton.TabIndex = 7;
            this.RectanglesFindButton.Text = "Find";
            this.RectanglesFindButton.UseVisualStyleBackColor = true;
            this.RectanglesFindButton.Click += new System.EventHandler(this.RectanglesFindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(182, 179);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(76, 20);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(182, 115);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(76, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(182, 55);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(76, 20);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 40);
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
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(138, 225);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsTabPage.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationGroupBox.ResumeLayout(false);
            this.EnumerationGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.rectanglesGroupBox.ResumeLayout(false);
            this.rectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

