namespace DIYShopSys
{
    partial class Sales
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
            AddToBasket = new Button();
            Basketlabel = new Label();
            RemoveFromBasket = new Button();
            TotalLabel = new Label();
            Basket = new DataGridView();
            BuyButton = new Button();
            ReturnButton = new Button();
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
            Items.Location = new Point(18, 80);
            Items.MultiSelect = false;
            Items.Name = "Items";
            Items.ReadOnly = true;
            Items.RowTemplate.Height = 25;
            Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Items.Size = new Size(432, 290);
            Items.TabIndex = 9;
            // 
            // AddToBasket
            // 
            AddToBasket.Location = new Point(18, 376);
            AddToBasket.Name = "AddToBasket";
            AddToBasket.Size = new Size(133, 23);
            AddToBasket.TabIndex = 10;
            AddToBasket.Text = "Add Item to Basket";
            AddToBasket.UseVisualStyleBackColor = true;
            AddToBasket.Click += AddToBasket_Click;
            // 
            // Basketlabel
            // 
            Basketlabel.AutoSize = true;
            Basketlabel.Location = new Point(602, 50);
            Basketlabel.Name = "Basketlabel";
            Basketlabel.Size = new Size(41, 15);
            Basketlabel.TabIndex = 15;
            Basketlabel.Text = "Basket";
            // 
            // RemoveFromBasket
            // 
            RemoveFromBasket.Location = new Point(602, 376);
            RemoveFromBasket.Name = "RemoveFromBasket";
            RemoveFromBasket.Size = new Size(180, 23);
            RemoveFromBasket.TabIndex = 13;
            RemoveFromBasket.Text = "Remove Item from Basket";
            RemoveFromBasket.UseVisualStyleBackColor = true;
            RemoveFromBasket.Click += RemoveFromBasket_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(440, 380);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(43, 15);
            TotalLabel.TabIndex = 14;
            TotalLabel.Text = "Total =";
            // 
            // Basket
            // 
            Basket.AllowUserToAddRows = false;
            Basket.AllowUserToDeleteRows = false;
            Basket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Basket.BackgroundColor = SystemColors.Control;
            Basket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Basket.Location = new Point(470, 80);
            Basket.MultiSelect = false;
            Basket.Name = "Basket";
            Basket.ReadOnly = true;
            Basket.RowTemplate.Height = 25;
            Basket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Basket.Size = new Size(312, 290);
            Basket.TabIndex = 11;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(542, 376);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(54, 23);
            BuyButton.TabIndex = 12;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(713, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 16;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnButton);
            Controls.Add(Items);
            Controls.Add(AddToBasket);
            Controls.Add(Basketlabel);
            Controls.Add(RemoveFromBasket);
            Controls.Add(TotalLabel);
            Controls.Add(Basket);
            Controls.Add(BuyButton);
            Name = "Sales";
            Text = "Sales";
            FormClosed += Sales_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ((System.ComponentModel.ISupportInitialize)Basket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Items;
        private Button AddToBasket;
        private Label Basketlabel;
        private Button RemoveFromBasket;
        private Label TotalLabel;
        private DataGridView Basket;
        private Button BuyButton;
        private Button ReturnButton;
    }
}