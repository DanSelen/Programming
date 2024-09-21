﻿namespace ObjectOrientedPractics
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
            TabControl = new TabControl();
            TabPage1 = new TabPage();
            ItemsTab1 = new View.Tabs.ItemsTab();
            TabPage2 = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            TabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPage1);
            TabControl.Controls.Add(TabPage2);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(964, 631);
            TabControl.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(ItemsTab1);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(956, 603);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Items";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab1
            // 
            ItemsTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTab1.Location = new Point(3, 3);
            ItemsTab1.MinimumSize = new Size(400, 400);
            ItemsTab1.Name = "ItemsTab1";
            ItemsTab1.Size = new Size(927, 584);
            ItemsTab1.TabIndex = 0;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(customersTab1);
            TabPage2.Location = new Point(4, 24);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(956, 603);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Customers";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Location = new Point(8, 6);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(927, 584);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 631);
            Controls.Add(TabControl);
            Name = "MainForm";
            Text = "MainForm";
            TabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private View.Tabs.ItemsTab ItemsTab1;
        private View.Tabs.CustomersTab customersTab1;
    }
}