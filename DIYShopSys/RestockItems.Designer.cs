namespace DIYShopSys
{
    partial class RestockItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Items = new DataGridView();
            ReturnButton = new Button();
            AddToBasket = new Button();
            BuyButton = new Button();
            Basket = new DataGridView();
            RemoveItemFromBasket = new Button();
            TotalLabel = new Label();
            ItemLabel = new Label();
            Basketlabel = new Label();
            Supplier = new ComboBox();
            GroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Basket).BeginInit();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Items
            // 
            Items.AllowUserToAddRows = false;
            Items.AllowUserToDeleteRows = false;
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = SystemColors.Control;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Location = new Point(6, 66);
            Items.MultiSelect = false;
            Items.Name = "Items";
            Items.ReadOnly = true;
            Items.RowTemplate.Height = 25;
            Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Items.Size = new Size(432, 290);
            Items.TabIndex = 0;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(713, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // AddToBasket
            // 
            AddToBasket.Location = new Point(6, 362);
            AddToBasket.Name = "AddToBasket";
            AddToBasket.Size = new Size(133, 23);
            AddToBasket.TabIndex = 2;
            AddToBasket.Text = "Add Item to Order List";
            AddToBasket.UseVisualStyleBackColor = true;
            AddToBasket.Click += AddToBasket_Click;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(530, 362);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(54, 23);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // Basket
            // 
            Basket.AllowUserToAddRows = false;
            Basket.AllowUserToDeleteRows = false;
            Basket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Basket.BackgroundColor = SystemColors.Control;
            Basket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Basket.Location = new Point(458, 66);
            Basket.MultiSelect = false;
            Basket.Name = "Basket";
            Basket.ReadOnly = true;
            Basket.RowTemplate.Height = 25;
            Basket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Basket.Size = new Size(312, 290);
            Basket.TabIndex = 3;
            // 
            // RemoveItemFromBasket
            // 
            RemoveItemFromBasket.Location = new Point(590, 362);
            RemoveItemFromBasket.Name = "RemoveItemFromBasket";
            RemoveItemFromBasket.Size = new Size(180, 23);
            RemoveItemFromBasket.TabIndex = 5;
            RemoveItemFromBasket.Text = "Remove Item from Order List";
            RemoveItemFromBasket.UseVisualStyleBackColor = true;
            RemoveItemFromBasket.Click += RemoveItemFromBasket_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(428, 366);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(43, 15);
            TotalLabel.TabIndex = 6;
            TotalLabel.Text = "Total =";
            // 
            // ItemLabel
            // 
            ItemLabel.AutoSize = true;
            ItemLabel.Location = new Point(12, 16);
            ItemLabel.Name = "ItemLabel";
            ItemLabel.Size = new Size(36, 15);
            ItemLabel.TabIndex = 7;
            ItemLabel.Text = "Items";
            // 
            // Basketlabel
            // 
            Basketlabel.AutoSize = true;
            Basketlabel.Location = new Point(575, 37);
            Basketlabel.Name = "Basketlabel";
            Basketlabel.Size = new Size(82, 15);
            Basketlabel.TabIndex = 8;
            Basketlabel.Text = "Ordered Items";
            // 
            // Supplier
            // 
            Supplier.FormattingEnabled = true;
            Supplier.Location = new Point(12, 45);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(121, 23);
            Supplier.TabIndex = 9;
            Supplier.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(Items);
            GroupBox.Controls.Add(AddToBasket);
            GroupBox.Controls.Add(Basketlabel);
            GroupBox.Controls.Add(RemoveItemFromBasket);
            GroupBox.Controls.Add(TotalLabel);
            GroupBox.Controls.Add(Basket);
            GroupBox.Controls.Add(BuyButton);
            GroupBox.Location = new Point(12, 74);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(776, 393);
            GroupBox.TabIndex = 10;
            GroupBox.TabStop = false;
            GroupBox.Visible = false;
            // 
            // RestockItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(GroupBox);
            Controls.Add(Supplier);
            Controls.Add(ItemLabel);
            Controls.Add(ReturnButton);
            Name = "RestockItems";
            Text = "Restock Items";
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ((System.ComponentModel.ISupportInitialize)Basket).EndInit();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Items;
        private Button ReturnButton;
        private Button AddToBasket;
        private Button BuyButton;
        private DataGridView Basket;
        private Button RemoveItemFromBasket;
        private Label TotalLabel;
        private Label ItemLabel;
        private Label Basketlabel;
        private ComboBox Supplier;
        private GroupBox GroupBox;
    }
}