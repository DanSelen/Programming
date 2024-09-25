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
            AddressTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            SelectedCustomerLabel = new Label();
            IdLabel = new Label();
            FullNameLabel = new Label();
            AddressLabel = new Label();
            Panel2 = new Panel();
            CustomersListBox = new ListBox();
            CustomersLabel = new Label();
            CustomersPanel = new Panel();
            GenerateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedCustomerPanel.SuspendLayout();
            CustomersPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom;
            RemoveButton.Location = new Point(115, 604);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(114, 59);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 604);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(114, 59);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerPanel.BackColor = SystemColors.ButtonHighlight;
            SelectedCustomerPanel.Controls.Add(AddressTextBox);
            SelectedCustomerPanel.Controls.Add(FullNameTextBox);
            SelectedCustomerPanel.Controls.Add(IdTextBox);
            SelectedCustomerPanel.Controls.Add(SelectedCustomerLabel);
            SelectedCustomerPanel.Controls.Add(IdLabel);
            SelectedCustomerPanel.Controls.Add(FullNameLabel);
            SelectedCustomerPanel.Controls.Add(AddressLabel);
            SelectedCustomerPanel.Location = new Point(349, 4);
            SelectedCustomerPanel.Margin = new Padding(3, 4, 3, 4);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            SelectedCustomerPanel.Size = new Size(629, 241);
            SelectedCustomerPanel.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(95, 123);
            AddressTextBox.Margin = new Padding(3, 4, 3, 4);
            AddressTextBox.MinimumSize = new Size(114, 125);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(503, 125);
            AddressTextBox.TabIndex = 2;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(95, 84);
            FullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(293, 27);
            FullNameTextBox.TabIndex = 1;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(95, 45);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(114, 27);
            IdTextBox.TabIndex = 0;
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerLabel.Location = new Point(3, 8);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(160, 23);
            SelectedCustomerLabel.TabIndex = 3;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 49);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(3, 91);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(79, 20);
            FullNameLabel.TabIndex = 5;
            FullNameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(3, 131);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Address:";
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.BackColor = SystemColors.ButtonHighlight;
            Panel2.Location = new Point(349, 253);
            Panel2.Margin = new Padding(3, 4, 3, 4);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(629, 435);
            Panel2.TabIndex = 2;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(3, 35);
            CustomersListBox.Margin = new Padding(3, 4, 3, 4);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(323, 544);
            CustomersListBox.TabIndex = 3;
            CustomersListBox.MouseClick += CustomersListBox_MouseClick;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.BackColor = SystemColors.ControlLightLight;
            CustomersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(3, 8);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(94, 23);
            CustomersLabel.TabIndex = 2;
            CustomersLabel.Text = "Customers";
            CustomersLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersPanel.BackColor = SystemColors.ControlLightLight;
            CustomersPanel.Controls.Add(GenerateButton);
            CustomersPanel.Controls.Add(CustomersLabel);
            CustomersPanel.Controls.Add(AddButton);
            CustomersPanel.Controls.Add(RemoveButton);
            CustomersPanel.Controls.Add(CustomersListBox);
            CustomersPanel.Location = new Point(3, 4);
            CustomersPanel.Margin = new Padding(3, 4, 3, 4);
            CustomersPanel.Name = "CustomersPanel";
            tableLayoutPanel1.SetRowSpan(CustomersPanel, 2);
            CustomersPanel.Size = new Size(340, 684);
            CustomersPanel.TabIndex = 3;
            // 
            // GenerateButton
            // 
            GenerateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GenerateButton.Location = new Point(222, 604);
            GenerateButton.Margin = new Padding(3, 4, 3, 4);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(114, 59);
            GenerateButton.TabIndex = 4;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.3535347F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.64646F));
            tableLayoutPanel1.Controls.Add(Panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(SelectedCustomerPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(CustomersPanel, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.98616F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.01384F));
            tableLayoutPanel1.Size = new Size(981, 692);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomersTab";
            Size = new Size(1000, 700);
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            CustomersPanel.ResumeLayout(false);
            CustomersPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label AddressLabel;
        private Panel CustomersPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button GenerateButton;
    }
}
