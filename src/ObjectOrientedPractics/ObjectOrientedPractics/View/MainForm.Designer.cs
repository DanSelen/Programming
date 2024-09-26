namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TabControl = new TabControl();
            TabPage1 = new TabPage();
            TabPage2 = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            itemsTab1 = new View.Tabs.ItemsTab();
            TabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPage1);
            TabControl.Controls.Add(TabPage2);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(964, 631);
            TabControl.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(itemsTab1);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3, 3, 3, 3);
            TabPage1.Size = new Size(956, 603);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Items";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(customersTab1);
            TabPage2.Location = new Point(4, 24);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3, 3, 3, 3);
            TabPage2.Size = new Size(956, 603);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Customers";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(950, 597);
            customersTab1.TabIndex = 0;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.MinimumSize = new Size(400, 400);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(950, 597);
            itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 631);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Oriented Practics";
            TabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
    }
}
