﻿namespace DIYShopSys
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            addSupplierToolStripMenuItem = new ToolStripMenuItem();
            updateSupplierToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { suppliersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addSupplierToolStripMenuItem, updateSupplierToolStripMenuItem });
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(66, 20);
            suppliersToolStripMenuItem.Text = "suppliers";
            // 
            // addSupplierToolStripMenuItem
            // 
            addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            addSupplierToolStripMenuItem.Size = new Size(180, 22);
            addSupplierToolStripMenuItem.Text = "add supplier";
            addSupplierToolStripMenuItem.Click += addSupplierToolStripMenuItem_Click;
            // 
            // updateSupplierToolStripMenuItem
            // 
            updateSupplierToolStripMenuItem.Name = "updateSupplierToolStripMenuItem";
            updateSupplierToolStripMenuItem.Size = new Size(180, 22);
            updateSupplierToolStripMenuItem.Text = "update supplier";
            updateSupplierToolStripMenuItem.Click += updateSupplierToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem addSupplierToolStripMenuItem;
        private ToolStripMenuItem updateSupplierToolStripMenuItem;
    }
}