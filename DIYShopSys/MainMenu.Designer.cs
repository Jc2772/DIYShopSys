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
            AddAndUpdateItemsToolStripMenuItem = new ToolStripMenuItem();
            ManageDataToolStripMenuItem = new ToolStripMenuItem();
            removeSupplierDetailsToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            updateItemToolStripMenuItem = new ToolStripMenuItem();
            removeItemToolStripMenuItem = new ToolStripMenuItem();
            queryItemsToolStripMenuItem = new ToolStripMenuItem();
            restockItemToolStripMenuItem = new ToolStripMenuItem();
            analysisToolStripMenuItem = new ToolStripMenuItem();
            yearlyRevenueAnalysisToolStripMenuItem = new ToolStripMenuItem();
            yearlyItemAnalysisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { suppliersToolStripMenuItem, itemsToolStripMenuItem, analysisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddAndUpdateItemsToolStripMenuItem, ManageDataToolStripMenuItem, removeSupplierDetailsToolStripMenuItem });
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(67, 20);
            suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // AddAndUpdateItemsToolStripMenuItem
            // 
            AddAndUpdateItemsToolStripMenuItem.Name = "AddAndUpdateItemsToolStripMenuItem";
            AddAndUpdateItemsToolStripMenuItem.Size = new Size(201, 22);
            AddAndUpdateItemsToolStripMenuItem.Text = "add supplier";
            AddAndUpdateItemsToolStripMenuItem.Click += AddAndUpdateItemsToolStripMenuItem_Click;
            // 
            // ManageDataToolStripMenuItem
            // 
            ManageDataToolStripMenuItem.Name = "ManageDataToolStripMenuItem";
            ManageDataToolStripMenuItem.Size = new Size(201, 22);
            ManageDataToolStripMenuItem.Text = "update supplier";
            ManageDataToolStripMenuItem.Click += ManageDataToolStripMenuItem_Click;
            // 
            // removeSupplierDetailsToolStripMenuItem
            // 
            removeSupplierDetailsToolStripMenuItem.Name = "removeSupplierDetailsToolStripMenuItem";
            removeSupplierDetailsToolStripMenuItem.Size = new Size(201, 22);
            removeSupplierDetailsToolStripMenuItem.Text = "Remove Supplier Details";
            removeSupplierDetailsToolStripMenuItem.Click += removeSupplierDetailsToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, updateItemToolStripMenuItem, removeItemToolStripMenuItem, queryItemsToolStripMenuItem, restockItemToolStripMenuItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(48, 20);
            itemsToolStripMenuItem.Text = "Items";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(180, 22);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // updateItemToolStripMenuItem
            // 
            updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            updateItemToolStripMenuItem.Size = new Size(180, 22);
            updateItemToolStripMenuItem.Text = "Update Item Details";
            updateItemToolStripMenuItem.Click += updateItemToolStripMenuItem_Click;
            // 
            // removeItemToolStripMenuItem
            // 
            removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            removeItemToolStripMenuItem.Size = new Size(180, 22);
            removeItemToolStripMenuItem.Text = "Remove Item";
            removeItemToolStripMenuItem.Click += removeItemToolStripMenuItem_Click;
            // 
            // queryItemsToolStripMenuItem
            // 
            queryItemsToolStripMenuItem.Name = "queryItemsToolStripMenuItem";
            queryItemsToolStripMenuItem.Size = new Size(180, 22);
            queryItemsToolStripMenuItem.Text = "Query Items";
            queryItemsToolStripMenuItem.Click += queryItemsToolStripMenuItem_Click;
            // 
            // restockItemToolStripMenuItem
            // 
            restockItemToolStripMenuItem.Name = "restockItemToolStripMenuItem";
            restockItemToolStripMenuItem.Size = new Size(180, 22);
            restockItemToolStripMenuItem.Text = "Restock Item";
            restockItemToolStripMenuItem.Click += restockItemToolStripMenuItem_Click;
            // 
            // analysisToolStripMenuItem
            // 
            analysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yearlyRevenueAnalysisToolStripMenuItem, yearlyItemAnalysisToolStripMenuItem });
            analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            analysisToolStripMenuItem.Size = new Size(62, 20);
            analysisToolStripMenuItem.Text = "Analysis";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            yearlyRevenueAnalysisToolStripMenuItem.Size = new Size(199, 22);
            yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            yearlyRevenueAnalysisToolStripMenuItem.Click += yearlyRevenueAnalysisToolStripMenuItem_Click;
            // 
            // yearlyItemAnalysisToolStripMenuItem
            // 
            yearlyItemAnalysisToolStripMenuItem.Name = "yearlyItemAnalysisToolStripMenuItem";
            yearlyItemAnalysisToolStripMenuItem.Size = new Size(199, 22);
            yearlyItemAnalysisToolStripMenuItem.Text = "Yearly Item Analysis";
            yearlyItemAnalysisToolStripMenuItem.Click += yearlyItemAnalysisToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem AddAndUpdateItemsToolStripMenuItem;
        private ToolStripMenuItem ManageDataToolStripMenuItem;
        private ToolStripMenuItem removeSupplierDetailsToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem analysisToolStripMenuItem;
        private ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private ToolStripMenuItem yearlyItemAnalysisToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem updateItemToolStripMenuItem;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private ToolStripMenuItem queryItemsToolStripMenuItem;
        private ToolStripMenuItem restockItemToolStripMenuItem;
    }
}