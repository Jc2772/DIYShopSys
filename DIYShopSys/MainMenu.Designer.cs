namespace DIYShopSys
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
            ManageItemsToolStripMenuItem = new ToolStripMenuItem();
            ManageDataToolStripMenuItem = new ToolStripMenuItem();
            removeSupplierDetailsToolStripMenuItem = new ToolStripMenuItem();
            querySupplierDetailsToolStripMenuItem = new ToolStripMenuItem();
            typesToolStripMenuItem = new ToolStripMenuItem();
            addTypeToolStripMenuItem = new ToolStripMenuItem();
            updateTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTypeStatusToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            updateItemToolStripMenuItem = new ToolStripMenuItem();
            removeItemToolStripMenuItem = new ToolStripMenuItem();
            restockItemToolStripMenuItem = new ToolStripMenuItem();
            analysisToolStripMenuItem = new ToolStripMenuItem();
            yearlyRevenueAnalysisToolStripMenuItem = new ToolStripMenuItem();
            yearlyItemAnalysisToolStripMenuItem = new ToolStripMenuItem();
            ReturnButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { suppliersToolStripMenuItem, typesToolStripMenuItem, itemsToolStripMenuItem, analysisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(686, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ManageItemsToolStripMenuItem, ManageDataToolStripMenuItem, removeSupplierDetailsToolStripMenuItem, querySupplierDetailsToolStripMenuItem });
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(67, 20);
            suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // ManageItemsToolStripMenuItem
            // 
            ManageItemsToolStripMenuItem.Name = "ManageItemsToolStripMenuItem";
            ManageItemsToolStripMenuItem.Size = new Size(198, 22);
            ManageItemsToolStripMenuItem.Text = "Add Supplier";
            ManageItemsToolStripMenuItem.Click += ManageItemsToolStripMenuItem_Click;
            // 
            // ManageDataToolStripMenuItem
            // 
            ManageDataToolStripMenuItem.Name = "ManageDataToolStripMenuItem";
            ManageDataToolStripMenuItem.Size = new Size(198, 22);
            ManageDataToolStripMenuItem.Text = "Update Supplier";
            ManageDataToolStripMenuItem.Click += ManageDataToolStripMenuItem_Click;
            // 
            // removeSupplierDetailsToolStripMenuItem
            // 
            removeSupplierDetailsToolStripMenuItem.Name = "removeSupplierDetailsToolStripMenuItem";
            removeSupplierDetailsToolStripMenuItem.Size = new Size(198, 22);
            removeSupplierDetailsToolStripMenuItem.Text = "Manage Supplier Status";
            removeSupplierDetailsToolStripMenuItem.Click += removeSupplierDetailsToolStripMenuItem_Click;
            // 
            // querySupplierDetailsToolStripMenuItem
            // 
            querySupplierDetailsToolStripMenuItem.Name = "querySupplierDetailsToolStripMenuItem";
            querySupplierDetailsToolStripMenuItem.Size = new Size(198, 22);
            querySupplierDetailsToolStripMenuItem.Text = "Query Supplier Details";
            querySupplierDetailsToolStripMenuItem.Click += querySupplierDetailsToolStripMenuItem_Click;
            // 
            // typesToolStripMenuItem
            // 
            typesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTypeToolStripMenuItem, updateTypesToolStripMenuItem, manageTypeStatusToolStripMenuItem });
            typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            typesToolStripMenuItem.Size = new Size(48, 20);
            typesToolStripMenuItem.Text = "Types";
            // 
            // addTypeToolStripMenuItem
            // 
            addTypeToolStripMenuItem.Name = "addTypeToolStripMenuItem";
            addTypeToolStripMenuItem.Size = new Size(179, 22);
            addTypeToolStripMenuItem.Text = "Add Type";
            addTypeToolStripMenuItem.Click += addTypeToolStripMenuItem_Click;
            // 
            // updateTypesToolStripMenuItem
            // 
            updateTypesToolStripMenuItem.Name = "updateTypesToolStripMenuItem";
            updateTypesToolStripMenuItem.Size = new Size(179, 22);
            updateTypesToolStripMenuItem.Text = "Update Types";
            updateTypesToolStripMenuItem.Click += updateTypesToolStripMenuItem_Click;
            // 
            // manageTypeStatusToolStripMenuItem
            // 
            manageTypeStatusToolStripMenuItem.Name = "manageTypeStatusToolStripMenuItem";
            manageTypeStatusToolStripMenuItem.Size = new Size(179, 22);
            manageTypeStatusToolStripMenuItem.Text = "Manage Type Status";
            manageTypeStatusToolStripMenuItem.Click += manageTypeStatusToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, updateItemToolStripMenuItem, removeItemToolStripMenuItem, restockItemToolStripMenuItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(48, 20);
            itemsToolStripMenuItem.Text = "Items";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(179, 22);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // updateItemToolStripMenuItem
            // 
            updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            updateItemToolStripMenuItem.Size = new Size(179, 22);
            updateItemToolStripMenuItem.Text = "Update Item Details";
            updateItemToolStripMenuItem.Click += updateItemToolStripMenuItem_Click;
            // 
            // removeItemToolStripMenuItem
            // 
            removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            removeItemToolStripMenuItem.Size = new Size(179, 22);
            removeItemToolStripMenuItem.Text = "Manage Item Status";
            removeItemToolStripMenuItem.Click += removeItemToolStripMenuItem_Click;
            // 
            // restockItemToolStripMenuItem
            // 
            restockItemToolStripMenuItem.Name = "restockItemToolStripMenuItem";
            restockItemToolStripMenuItem.Size = new Size(179, 22);
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
            // ReturnButton
            // 
            ReturnButton.Location = new Point(611, 1);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 450);
            Controls.Add(ReturnButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(702, 489);
            MinimumSize = new Size(702, 489);
            Name = "MainMenu";
            Text = "Main Menu";
            FormClosed += MainMenu_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem ManageItemsToolStripMenuItem;
        private ToolStripMenuItem ManageDataToolStripMenuItem;
        private ToolStripMenuItem removeSupplierDetailsToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem analysisToolStripMenuItem;
        private ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private ToolStripMenuItem yearlyItemAnalysisToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem updateItemToolStripMenuItem;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private ToolStripMenuItem restockItemToolStripMenuItem;
        private ToolStripMenuItem typesToolStripMenuItem;
        private ToolStripMenuItem addTypeToolStripMenuItem;
        private ToolStripMenuItem updateTypesToolStripMenuItem;
        private ToolStripMenuItem manageTypeStatusToolStripMenuItem;
        private ToolStripMenuItem querySupplierDetailsToolStripMenuItem;
        private Button ReturnButton;
    }
}