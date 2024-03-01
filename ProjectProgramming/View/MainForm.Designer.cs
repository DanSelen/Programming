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
            this.WeekdayParsingBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.TypeValueForParsingLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumarationLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ChooseValueBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumerationBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.WeekdayParsingBox.SuspendLayout();
            this.EnumerationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnumsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationBox);
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
            // WeekdayParsingBox
            // 
            this.WeekdayParsingBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingBox.Controls.Add(this.TypeValueForParsingLabel);
            this.WeekdayParsingBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayParsingBox.Location = new System.Drawing.Point(2, 198);
            this.WeekdayParsingBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingBox.Name = "WeekdayParsingBox";
            this.WeekdayParsingBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingBox.Size = new System.Drawing.Size(282, 140);
            this.WeekdayParsingBox.TabIndex = 3;
            this.WeekdayParsingBox.TabStop = false;
            this.WeekdayParsingBox.Text = "Weekday Parsing";
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
            // EnumerationBox
            // 
            this.EnumerationBox.AutoSize = true;
            this.EnumerationBox.Controls.Add(this.IntValueLabel);
            this.EnumerationBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationBox.Controls.Add(this.ChooseEnumarationLabel);
            this.EnumerationBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationBox.Controls.Add(this.ChooseValueBox);
            this.EnumerationBox.Controls.Add(this.ChooseEnumerationBox);
            this.EnumerationBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumerationBox.Location = new System.Drawing.Point(2, 2);
            this.EnumerationBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationBox.Name = "EnumerationBox";
            this.EnumerationBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumerationBox.Size = new System.Drawing.Size(588, 196);
            this.EnumerationBox.TabIndex = 0;
            this.EnumerationBox.TabStop = false;
            this.EnumerationBox.Text = "Enumarations";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsTabPage.PerformLayout();
            this.WeekdayParsingBox.ResumeLayout(false);
            this.WeekdayParsingBox.PerformLayout();
            this.EnumerationBox.ResumeLayout(false);
            this.EnumerationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationBox;
        private System.Windows.Forms.ListBox ChooseValueBox;
        private System.Windows.Forms.ListBox ChooseEnumerationBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.GroupBox WeekdayParsingBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumarationLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.TextBox ParseTextBox;
        private System.Windows.Forms.Label WeekdayParsingLabel;
        private System.Windows.Forms.Label TypeValueForParsingLabel;
        private System.Windows.Forms.Button ParseButton;
    }
}

