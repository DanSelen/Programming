namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            panel1 = new Panel();
            ItemsLabel = new Label();
            panel2 = new Panel();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            SelectedItemLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 33);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(310, 454);
            ItemsListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 498);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 44);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(109, 498);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(100, 44);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ItemsLabel);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(RemoveButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 573);
            panel1.TabIndex = 9;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(5, 10);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(39, 15);
            ItemsLabel.TabIndex = 4;
            ItemsLabel.Text = "Items";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(DescriptionTextBox);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(CostTextBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(DescriptionLabel);
            panel2.Controls.Add(NameLabel);
            panel2.Controls.Add(CostLabel);
            panel2.Controls.Add(IdLabel);
            panel2.Controls.Add(SelectedItemLabel);
            panel2.Location = new Point(335, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 571);
            panel2.TabIndex = 10;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(13, 248);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(505, 159);
            DescriptionTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(13, 138);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(509, 71);
            NameTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(53, 81);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(53, 51);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(13, 230);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(13, 120);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(13, 84);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(15, 54);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemLabel.Location = new Point(17, 10);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(86, 15);
            SelectedItemLabel.TabIndex = 0;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemsTab";
            Size = new Size(894, 580);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Panel panel1;
        private Panel panel2;
        private Label SelectedItemLabel;
        private Label ItemsLabel;
        private TextBox IdTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
    }
}
