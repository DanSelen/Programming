namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            RemoveButton = new Button();
            AddButton = new Button();
            SelectedCustomerPanel = new Panel();
            AddressLabel = new Label();
            FullNameLabel = new Label();
            IdLabel = new Label();
            SelectedCustomerLabel = new Label();
            AddressTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            Panel2 = new Panel();
            CustomersLabel = new Label();
            CustomersListBox = new ListBox();
            CustomersTableLayoutPanel = new TableLayoutPanel();
            SelectedCustomerPanel.SuspendLayout();
            CustomersTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(117, 527);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(109, 46);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 527);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 46);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerPanel.BackColor = SystemColors.ButtonHighlight;
            SelectedCustomerPanel.Controls.Add(AddressLabel);
            SelectedCustomerPanel.Controls.Add(FullNameLabel);
            SelectedCustomerPanel.Controls.Add(IdLabel);
            SelectedCustomerPanel.Controls.Add(SelectedCustomerLabel);
            SelectedCustomerPanel.Controls.Add(AddressTextBox);
            SelectedCustomerPanel.Controls.Add(FullNameTextBox);
            SelectedCustomerPanel.Controls.Add(IdTextBox);
            SelectedCustomerPanel.Location = new Point(348, 3);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            SelectedCustomerPanel.Size = new Size(578, 198);
            SelectedCustomerPanel.TabIndex = 1;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(3, 98);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Address:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(3, 68);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 5;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 37);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerLabel.Location = new Point(3, 6);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(122, 17);
            SelectedCustomerLabel.TabIndex = 3;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(83, 92);
            AddressTextBox.MinimumSize = new Size(100, 95);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(468, 95);
            AddressTextBox.TabIndex = 2;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(83, 63);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(100, 23);
            FullNameTextBox.TabIndex = 1;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(83, 34);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 0;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.BackColor = SystemColors.ButtonHighlight;
            Panel2.Location = new Point(348, 207);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(576, 374);
            Panel2.TabIndex = 2;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.BackColor = SystemColors.ControlLightLight;
            CustomersLabel.Dock = DockStyle.Fill;
            CustomersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(3, 0);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(108, 21);
            CustomersLabel.TabIndex = 2;
            CustomersLabel.Text = "Customers";
            CustomersLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomersListBox
            // 
            CustomersTableLayoutPanel.SetColumnSpan(CustomersListBox, 3);
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 24);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(339, 497);
            CustomersListBox.TabIndex = 3;
            CustomersListBox.MouseClick += CustomersListBox_MouseClick;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersTableLayoutPanel
            // 
            CustomersTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersTableLayoutPanel.BackColor = SystemColors.ControlLightLight;
            CustomersTableLayoutPanel.ColumnCount = 3;
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            CustomersTableLayoutPanel.Controls.Add(RemoveButton, 1, 2);
            CustomersTableLayoutPanel.Controls.Add(CustomersListBox, 0, 1);
            CustomersTableLayoutPanel.Controls.Add(AddButton, 0, 2);
            CustomersTableLayoutPanel.Controls.Add(CustomersLabel, 0, 0);
            CustomersTableLayoutPanel.Location = new Point(3, 4);
            CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            CustomersTableLayoutPanel.RowCount = 3;
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 3.63951468F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 87.17504F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.012132F));
            CustomersTableLayoutPanel.Size = new Size(345, 576);
            CustomersTableLayoutPanel.TabIndex = 3;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersTableLayoutPanel);
            Controls.Add(Panel2);
            Controls.Add(SelectedCustomerPanel);
            Name = "CustomersTab";
            Size = new Size(927, 584);
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            CustomersTableLayoutPanel.ResumeLayout(false);
            CustomersTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button RemoveButton;
        private Button AddButton;
        private Panel SelectedCustomerPanel;
        private Panel Panel2;
        private Label FullNameLabel;
        private Label IdLabel;
        private Label SelectedCustomerLabel;
        private TextBox AddressTextBox;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private ListBox CustomersListBox;
        private Label CustomersLabel;
        private TableLayoutPanel CustomersTableLayoutPanel;
        private Label AddressLabel;
    }
}
