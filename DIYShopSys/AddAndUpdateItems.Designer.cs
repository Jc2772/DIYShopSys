namespace DIYShopSys
{
    partial class AddAndUpdateItems
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
            SubmitButton = new Button();
            ReturnButton = new Button();
            ItemName = new TextBox();
            Price = new TextBox();
            Quantity = new TextBox();
            Supplier = new ComboBox();
            LabelForName = new Label();
            LabelForPrice = new Label();
            LabelForSupplier = new Label();
            LabelForQuantity = new Label();
            LabelForCost = new Label();
            Cost = new TextBox();
            LabelForType = new Label();
            Type = new ComboBox();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(135, 250);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(271, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // ItemName
            // 
            ItemName.Location = new Point(117, 57);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(169, 23);
            ItemName.TabIndex = 2;
            // 
            // Price
            // 
            Price.Location = new Point(117, 88);
            Price.Name = "Price";
            Price.Size = new Size(169, 23);
            Price.TabIndex = 4;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(117, 207);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(169, 23);
            Quantity.TabIndex = 5;
            // 
            // Supplier
            // 
            Supplier.FormattingEnabled = true;
            Supplier.Location = new Point(117, 178);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(169, 23);
            Supplier.TabIndex = 6;
            // 
            // LabelForName
            // 
            LabelForName.AutoSize = true;
            LabelForName.Location = new Point(25, 60);
            LabelForName.Name = "LabelForName";
            LabelForName.Size = new Size(39, 15);
            LabelForName.TabIndex = 7;
            LabelForName.Text = "Name";
            // 
            // LabelForPrice
            // 
            LabelForPrice.AutoSize = true;
            LabelForPrice.Location = new Point(25, 91);
            LabelForPrice.Name = "LabelForPrice";
            LabelForPrice.Size = new Size(33, 15);
            LabelForPrice.TabIndex = 9;
            LabelForPrice.Text = "Price";
            // 
            // LabelForSupplier
            // 
            LabelForSupplier.AutoSize = true;
            LabelForSupplier.Location = new Point(25, 178);
            LabelForSupplier.Name = "LabelForSupplier";
            LabelForSupplier.Size = new Size(50, 15);
            LabelForSupplier.TabIndex = 10;
            LabelForSupplier.Text = "Supplier";
            // 
            // LabelForQuantity
            // 
            LabelForQuantity.AutoSize = true;
            LabelForQuantity.Location = new Point(25, 210);
            LabelForQuantity.Name = "LabelForQuantity";
            LabelForQuantity.Size = new Size(53, 15);
            LabelForQuantity.TabIndex = 11;
            LabelForQuantity.Text = "Quantity";
            // 
            // LabelForCost
            // 
            LabelForCost.AutoSize = true;
            LabelForCost.Location = new Point(25, 122);
            LabelForCost.Name = "LabelForCost";
            LabelForCost.Size = new Size(31, 15);
            LabelForCost.TabIndex = 13;
            LabelForCost.Text = "Cost";
            // 
            // Cost
            // 
            Cost.Location = new Point(117, 122);
            Cost.Name = "Cost";
            Cost.Size = new Size(169, 23);
            Cost.TabIndex = 12;
            // 
            // LabelForType
            // 
            LabelForType.AutoSize = true;
            LabelForType.Location = new Point(25, 151);
            LabelForType.Name = "LabelForType";
            LabelForType.Size = new Size(36, 15);
            LabelForType.TabIndex = 15;
            LabelForType.Text = "Types";
            // 
            // Type
            // 
            Type.FormattingEnabled = true;
            Type.Location = new Point(117, 151);
            Type.Name = "Type";
            Type.Size = new Size(169, 23);
            Type.TabIndex = 14;
            // 
            // AddAndUpdateItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 285);
            Controls.Add(LabelForType);
            Controls.Add(Type);
            Controls.Add(LabelForCost);
            Controls.Add(Cost);
            Controls.Add(LabelForQuantity);
            Controls.Add(LabelForSupplier);
            Controls.Add(LabelForPrice);
            Controls.Add(LabelForName);
            Controls.Add(Supplier);
            Controls.Add(Quantity);
            Controls.Add(Price);
            Controls.Add(ItemName);
            Controls.Add(ReturnButton);
            Controls.Add(SubmitButton);
            Name = "AddAndUpdateItems";
            Text = "Form2";
            FormClosed += AddAndUpdateItems_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ReturnButton;
        private TextBox ItemName;
        private TextBox Price;
        private TextBox Quantity;
        private ComboBox Supplier;
        private Label LabelForName;
        private Label LabelForPrice;
        private Label LabelForSupplier;
        private Label LabelForQuantity;
        private Label LabelForCost;
        private TextBox Cost;
        private Label LabelForType;
        private ComboBox Type;
    }
}