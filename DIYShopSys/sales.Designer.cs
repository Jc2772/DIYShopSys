namespace DIYShopSys
{
    partial class sales
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
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Basket).BeginInit();
            SuspendLayout();
            // 
            // Items
            // 
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Location = new Point(12, 40);
            Items.Name = "Items";
            Items.RowTemplate.Height = 25;
            Items.Size = new Size(486, 348);
            Items.TabIndex = 0;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(713, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "button1";
            ReturnButton.UseVisualStyleBackColor = true;
            // 
            // AddToBasket
            // 
            AddToBasket.Location = new Point(135, 415);
            AddToBasket.Name = "AddToBasket";
            AddToBasket.Size = new Size(75, 23);
            AddToBasket.TabIndex = 2;
            AddToBasket.Text = "button2";
            AddToBasket.UseVisualStyleBackColor = true;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(692, 415);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(75, 23);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "button3";
            BuyButton.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            Basket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Basket.Location = new Point(504, 40);
            Basket.Name = "Basket";
            Basket.RowTemplate.Height = 25;
            Basket.Size = new Size(284, 348);
            Basket.TabIndex = 3;
            // 
            // RemoveItemFromBasket
            // 
            RemoveItemFromBasket.Location = new Point(545, 415);
            RemoveItemFromBasket.Name = "RemoveItemFromBasket";
            RemoveItemFromBasket.Size = new Size(75, 23);
            RemoveItemFromBasket.TabIndex = 5;
            RemoveItemFromBasket.Text = "button4";
            RemoveItemFromBasket.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveItemFromBasket);
            Controls.Add(BuyButton);
            Controls.Add(Basket);
            Controls.Add(AddToBasket);
            Controls.Add(ReturnButton);
            Controls.Add(Items);
            Name = "sales";
            Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ((System.ComponentModel.ISupportInitialize)Basket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Items;
        private Button ReturnButton;
        private Button AddToBasket;
        private Button BuyButton;
        private DataGridView Basket;
        private Button RemoveItemFromBasket;
    }
}