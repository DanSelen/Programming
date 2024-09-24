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
            ItemsPanel = new Panel();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            AddButton = new Button();
            RemoveButton = new Button();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemsPanel.SuspendLayout();
            SelectedItemsPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsPanel
            // 
            ItemsPanel.BackColor = SystemColors.ControlLightLight;
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Controls.Add(ItemsLabel);
            ItemsPanel.Controls.Add(AddButton);
            ItemsPanel.Controls.Add(RemoveButton);
            ItemsPanel.Dock = DockStyle.Fill;
            ItemsPanel.Location = new Point(3, 3);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(324, 572);
            ItemsPanel.TabIndex = 9;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 43);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(310, 469);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.MouseClick += ItemsListBox_MouseClick;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
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
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 518);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 44);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(109, 518);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(100, 44);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SelectedItemsPanel
            // 
            SelectedItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            SelectedItemsPanel.Location = new Point(333, 3);
            SelectedItemsPanel.Name = "SelectedItemsPanel";
            SelectedItemsPanel.Size = new Size(585, 572);
            SelectedItemsPanel.TabIndex = 10;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(18, 248);
            DescriptionTextBox.MinimumSize = new Size(125, 75);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(549, 223);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NameTextBox.Location = new Point(18, 138);
            NameTextBox.MinimumSize = new Size(125, 75);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(549, 75);
            NameTextBox.TabIndex = 7;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(53, 81);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 6;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.83062F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.16938F));
            tableLayoutPanel1.Controls.Add(SelectedItemsPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(ItemsPanel, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(921, 578);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 400);
            Name = "ItemsTab";
            Size = new Size(927, 584);
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            SelectedItemsPanel.ResumeLayout(false);
            SelectedItemsPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsPanel;
        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Panel SelectedItemsPanel;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label SelectedItemLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
