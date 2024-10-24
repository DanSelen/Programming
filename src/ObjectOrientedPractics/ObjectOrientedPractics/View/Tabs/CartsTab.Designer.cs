namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            ItemsLabel = new Label();
            CustomerLabel = new Label();
            CartLabel = new Label();
            AddToCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            ClearCartButton = new Button();
            CartTextBox = new TextBox();
            CustomerComboBox = new ComboBox();
            ItemsListBox = new ListBox();
            AmountLabel = new Label();
            CurrentAmountLabel = new Label();
            SuspendLayout();
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(24, 12);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(46, 17);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerLabel.Location = new Point(297, 40);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(64, 15);
            CustomerLabel.TabIndex = 1;
            CustomerLabel.Text = "Customer:";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(297, 92);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 2;
            CartLabel.Text = "Cart:";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(24, 473);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(100, 44);
            AddToCartButton.TabIndex = 3;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top;
            RemoveItemButton.Location = new Point(552, 423);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(100, 44);
            RemoveItemButton.TabIndex = 4;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(297, 423);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(100, 44);
            CreateOrderButton.TabIndex = 5;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Location = new Point(658, 423);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(100, 44);
            ClearCartButton.TabIndex = 6;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // CartTextBox
            // 
            CartTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartTextBox.Location = new Point(297, 110);
            CartTextBox.Multiline = true;
            CartTextBox.Name = "CartTextBox";
            CartTextBox.Size = new Size(461, 247);
            CartTextBox.TabIndex = 7;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(365, 37);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(393, 23);
            CustomerComboBox.TabIndex = 8;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(24, 43);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(242, 424);
            ItemsListBox.TabIndex = 9;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(682, 360);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(76, 21);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Amount:";
            // 
            // CurrentAmountLabel
            // 
            CurrentAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CurrentAmountLabel.AutoSize = true;
            CurrentAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CurrentAmountLabel.Location = new Point(649, 381);
            CurrentAmountLabel.Name = "CurrentAmountLabel";
            CurrentAmountLabel.Size = new Size(109, 30);
            CurrentAmountLabel.TabIndex = 11;
            CurrentAmountLabel.Text = "Заглушка";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CurrentAmountLabel);
            Controls.Add(AmountLabel);
            Controls.Add(ItemsListBox);
            Controls.Add(CustomerComboBox);
            Controls.Add(CartTextBox);
            Controls.Add(ClearCartButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddToCartButton);
            Controls.Add(CartLabel);
            Controls.Add(CustomerLabel);
            Controls.Add(ItemsLabel);
            Name = "CartsTab";
            Size = new Size(875, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemsLabel;
        private Label CustomerLabel;
        private Label CartLabel;
        private Button AddToCartButton;
        private Button RemoveItemButton;
        private Button CreateOrderButton;
        private Button ClearCartButton;
        private TextBox CartTextBox;
        private ComboBox CustomerComboBox;
        private ListBox ItemsListBox;
        private Label AmountLabel;
        private Label CurrentAmountLabel;
    }
}
