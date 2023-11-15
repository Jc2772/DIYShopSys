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
            Total = new Label();
            ItemLabel = new Label();
            Basketlabel = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Basket).BeginInit();
            SuspendLayout();
            // 
            // Items
            // 
            Items.AllowUserToAddRows = false;
            Items.AllowUserToDeleteRows = false;
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = SystemColors.Control;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Location = new Point(12, 74);
            Items.Name = "Items";
            Items.RowTemplate.Height = 25;
            Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Items.Size = new Size(458, 314);
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
            AddToBasket.Location = new Point(135, 415);
            AddToBasket.Name = "AddToBasket";
            AddToBasket.Size = new Size(109, 23);
            AddToBasket.TabIndex = 2;
            AddToBasket.Text = "Add Item to basket";
            AddToBasket.UseVisualStyleBackColor = true;
            AddToBasket.Click += AddToBasket_Click;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(734, 415);
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
            Basket.Location = new Point(476, 74);
            Basket.Name = "Basket";
            Basket.RowTemplate.Height = 25;
            Basket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Basket.Size = new Size(312, 314);
            Basket.TabIndex = 3;
            // 
            // RemoveItemFromBasket
            // 
            RemoveItemFromBasket.Location = new Point(504, 415);
            RemoveItemFromBasket.Name = "RemoveItemFromBasket";
            RemoveItemFromBasket.Size = new Size(103, 23);
            RemoveItemFromBasket.TabIndex = 5;
            RemoveItemFromBasket.Text = "Remove Item";
            RemoveItemFromBasket.UseVisualStyleBackColor = true;
            RemoveItemFromBasket.Click += RemoveItemFromBasket_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(689, 391);
            Total.Name = "Total";
            Total.Size = new Size(43, 15);
            Total.TabIndex = 6;
            Total.Text = "Total =";
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
            Basketlabel.Location = new Point(504, 22);
            Basketlabel.Name = "Basketlabel";
            Basketlabel.Size = new Size(82, 15);
            Basketlabel.TabIndex = 8;
            Basketlabel.Text = "Ordered Items";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // RestockItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(Basketlabel);
            Controls.Add(ItemLabel);
            Controls.Add(Total);
            Controls.Add(RemoveItemFromBasket);
            Controls.Add(BuyButton);
            Controls.Add(Basket);
            Controls.Add(AddToBasket);
            Controls.Add(ReturnButton);
            Controls.Add(Items);
            Name = "RestockItems";
            Text = "Restock Items";
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ((System.ComponentModel.ISupportInitialize)Basket).EndInit();
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
        private Label Total;
        private Label ItemLabel;
        private Label Basketlabel;
        private ComboBox comboBox1;
    }
}