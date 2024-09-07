namespace AppForStudent
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
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.TextBoxRecordNumber = new System.Windows.Forms.TextBox();
            this.TextBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.comboBoxFormStudyStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButonStudent = new System.Windows.Forms.Button();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.RemoveButonStudent = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Location = new System.Drawing.Point(341, 156);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(307, 20);
            this.TextBoxFullName.TabIndex = 0;
            this.TextBoxFullName.TextChanged += new System.EventHandler(this.TextBoxFullName_TextChanged);
            // 
            // TextBoxRecordNumber
            // 
            this.TextBoxRecordNumber.Location = new System.Drawing.Point(341, 212);
            this.TextBoxRecordNumber.Name = "TextBoxRecordNumber";
            this.TextBoxRecordNumber.Size = new System.Drawing.Size(307, 20);
            this.TextBoxRecordNumber.TabIndex = 1;
            this.TextBoxRecordNumber.TextChanged += new System.EventHandler(this.TextBoxRecordNumber_TextChanged);
            // 
            // TextBoxGroupNumber
            // 
            this.TextBoxGroupNumber.Location = new System.Drawing.Point(341, 271);
            this.TextBoxGroupNumber.Name = "TextBoxGroupNumber";
            this.TextBoxGroupNumber.Size = new System.Drawing.Size(307, 20);
            this.TextBoxGroupNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите полное имя :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите номер зачетки :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите номер группы:";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(341, 36);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(165, 21);
            this.comboBoxEducation.TabIndex = 6;
            // 
            // comboBoxFormStudyStudent
            // 
            this.comboBoxFormStudyStudent.FormattingEnabled = true;
            this.comboBoxFormStudyStudent.Location = new System.Drawing.Point(341, 92);
            this.comboBoxFormStudyStudent.Name = "comboBoxFormStudyStudent";
            this.comboBoxFormStudyStudent.Size = new System.Drawing.Size(165, 21);
            this.comboBoxFormStudyStudent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите факультет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите форму обучения:";
            // 
            // AddButonStudent
            // 
            this.AddButonStudent.Location = new System.Drawing.Point(341, 311);
            this.AddButonStudent.Name = "AddButonStudent";
            this.AddButonStudent.Size = new System.Drawing.Size(75, 23);
            this.AddButonStudent.TabIndex = 10;
            this.AddButonStudent.Text = "Добавить";
            this.AddButonStudent.UseVisualStyleBackColor = true;
            this.AddButonStudent.Click += new System.EventHandler(this.AddButonStudent_Click);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(12, 12);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(283, 407);
            this.listBoxStudent.TabIndex = 11;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // RemoveButonStudent
            // 
            this.RemoveButonStudent.Location = new System.Drawing.Point(573, 311);
            this.RemoveButonStudent.Name = "RemoveButonStudent";
            this.RemoveButonStudent.Size = new System.Drawing.Size(75, 23);
            this.RemoveButonStudent.TabIndex = 12;
            this.RemoveButonStudent.Text = "Удалить";
            this.RemoveButonStudent.UseVisualStyleBackColor = true;
            this.RemoveButonStudent.Click += new System.EventHandler(this.RemoveButonStudent_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(451, 311);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Обновить данные";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 422);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.RemoveButonStudent);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.AddButonStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFormStudyStudent);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxGroupNumber);
            this.Controls.Add(this.TextBoxRecordNumber);
            this.Controls.Add(this.TextBoxFullName);
            this.Name = "MainForm";
            this.Text = "StudentsControl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.TextBox TextBoxRecordNumber;
        private System.Windows.Forms.TextBox TextBoxGroupNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.ComboBox comboBoxFormStudyStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButonStudent;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.Button RemoveButonStudent;
        private System.Windows.Forms.Button updateButton;
    }
}

