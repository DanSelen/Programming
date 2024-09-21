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
            ItemsPanel = new Panel();
            ItemsLabel = new Label();
            SelectedItemsPanel = new Panel();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            SelectedItemLabel = new Label();
            ItemsPanel.SuspendLayout();
            SelectedItemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 33);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(310, 484);
            ItemsListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 523);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 44);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(109, 523);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(100, 44);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsPanel.BackColor = SystemColors.ControlLightLight;
            ItemsPanel.Controls.Add(ItemsLabel);
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Controls.Add(AddButton);
            ItemsPanel.Controls.Add(RemoveButton);
            ItemsPanel.Location = new Point(3, 3);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(327, 577);
            ItemsPanel.TabIndex = 9;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(5, 10);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(42, 17);
            ItemsLabel.TabIndex = 4;
            ItemsLabel.Text = "Items";
            // 
            // SelectedItemsPanel
            // 
            SelectedItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemsPanel.BackColor = SystemColors.ButtonHighlight;
            SelectedItemsPanel.Controls.Add(DescriptionTextBox);
            SelectedItemsPanel.Controls.Add(NameTextBox);
            SelectedItemsPanel.Controls.Add(CostTextBox);
            SelectedItemsPanel.Controls.Add(IdTextBox);
            SelectedItemsPanel.Controls.Add(DescriptionLabel);
            SelectedItemsPanel.Controls.Add(NameLabel);
            SelectedItemsPanel.Controls.Add(CostLabel);
            SelectedItemsPanel.Controls.Add(IdLabel);
            SelectedItemsPanel.Controls.Add(SelectedItemLabel);
            SelectedItemsPanel.Location = new Point(335, 4);
            SelectedItemsPanel.Name = "SelectedItemsPanel";
            SelectedItemsPanel.Size = new Size(589, 576);
            SelectedItemsPanel.TabIndex = 10;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(18, 248);
            DescriptionTextBox.MinimumSize = new Size(125, 75);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(553, 227);
            DescriptionTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(18, 138);
            NameTextBox.MinimumSize = new Size(125, 75);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(553, 75);
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
            SelectedItemLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemLabel.Location = new Point(17, 10);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(91, 17);
            SelectedItemLabel.TabIndex = 0;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemsPanel);
            Controls.Add(ItemsPanel);
            MinimumSize = new Size(400, 400);
            Name = "ItemsTab";
            Size = new Size(927, 584);
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            SelectedItemsPanel.ResumeLayout(false);
            SelectedItemsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Panel ItemsPanel;
        private Panel SelectedItemsPanel;
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
