namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            BuildingLabel = new Label();
            CityLabel = new Label();
            ApartmentLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            StreetLabel = new Label();
            StreetTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(14, 10);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(117, 17);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(14, 44);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(65, 15);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(13, 84);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(13, 147);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 3;
            BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(294, 84);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(201, 147);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 5;
            ApartmentLabel.Text = "Apartment:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(86, 44);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(99, 23);
            PostIndexTextBox.TabIndex = 6;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(86, 81);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(201, 23);
            CountryTextBox.TabIndex = 7;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(86, 144);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 23);
            BuildingTextBox.TabIndex = 8;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(331, 81);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(150, 23);
            CityTextBox.TabIndex = 9;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(274, 144);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 23);
            ApartmentTextBox.TabIndex = 10;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(14, 116);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 11;
            StreetLabel.Text = "Street:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(86, 113);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(395, 23);
            StreetTextBox.TabIndex = 12;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StreetTextBox);
            Controls.Add(StreetLabel);
            Controls.Add(ApartmentTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(CityLabel);
            Controls.Add(BuildingLabel);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            Name = "AddressControl";
            Size = new Size(500, 179);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label BuildingLabel;
        private Label CityLabel;
        private Label ApartmentLabel;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private Label StreetLabel;
        private TextBox StreetTextBox;
    }
}
