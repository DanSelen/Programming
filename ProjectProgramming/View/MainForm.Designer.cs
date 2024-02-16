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
            this.EnumerationBox = new System.Windows.Forms.GroupBox();
            this.ChooseEnumerationBox = new System.Windows.Forms.ListBox();
            this.ChooseValueBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingBox = new System.Windows.Forms.GroupBox();
            this.ChooseEnumarationLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumerationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnumsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(792, 421);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Tag = "";
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
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
            this.EnumerationBox.Location = new System.Drawing.Point(3, 3);
            this.EnumerationBox.Name = "EnumerationBox";
            this.EnumerationBox.Size = new System.Drawing.Size(786, 241);
            this.EnumerationBox.TabIndex = 0;
            this.EnumerationBox.TabStop = false;
            this.EnumerationBox.Text = "Enumarations";
            // 
            // ChooseEnumerationBox
            // 
            this.ChooseEnumerationBox.FormattingEnabled = true;
            this.ChooseEnumerationBox.ItemHeight = 16;
            this.ChooseEnumerationBox.Location = new System.Drawing.Point(6, 40);
            this.ChooseEnumerationBox.Name = "ChooseEnumerationBox";
            this.ChooseEnumerationBox.Size = new System.Drawing.Size(154, 180);
            this.ChooseEnumerationBox.TabIndex = 0;
            // 
            // ChooseValueBox
            // 
            this.ChooseValueBox.FormattingEnabled = true;
            this.ChooseValueBox.ItemHeight = 16;
            this.ChooseValueBox.Location = new System.Drawing.Point(210, 40);
            this.ChooseValueBox.Name = "ChooseValueBox";
            this.ChooseValueBox.Size = new System.Drawing.Size(164, 180);
            this.ChooseValueBox.TabIndex = 1;
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(393, 40);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // WeekdayParsingBox
            // 
            this.WeekdayParsingBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayParsingBox.Location = new System.Drawing.Point(3, 244);
            this.WeekdayParsingBox.Name = "WeekdayParsingBox";
            this.WeekdayParsingBox.Size = new System.Drawing.Size(324, 174);
            this.WeekdayParsingBox.TabIndex = 3;
            this.WeekdayParsingBox.TabStop = false;
            this.WeekdayParsingBox.Text = "Weekday Parsing";
            // 
            // ChooseEnumarationLabel
            // 
            this.ChooseEnumarationLabel.AutoSize = true;
            this.ChooseEnumarationLabel.Location = new System.Drawing.Point(3, 21);
            this.ChooseEnumarationLabel.Name = "ChooseEnumarationLabel";
            this.ChooseEnumarationLabel.Size = new System.Drawing.Size(134, 16);
            this.ChooseEnumarationLabel.TabIndex = 3;
            this.ChooseEnumarationLabel.Text = "Choose enumaration:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(207, 21);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(93, 16);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(390, 21);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(62, 16);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsTabPage.PerformLayout();
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
    }
}

