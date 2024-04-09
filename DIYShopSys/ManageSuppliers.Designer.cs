namespace DIYShopSys
{
    partial class ManageSuppliers
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
            LabelForEmail = new Label();
            LabelForPhoneNumber = new Label();
            LabelForName = new Label();
            Email = new TextBox();
            PhoneNumber = new TextBox();
            SupName = new TextBox();
            ReturnButton = new Button();
            SubmitButton = new Button();
            labelForDeliveryFee = new Label();
            DeliveryFee = new TextBox();
            LabelForRepName = new Label();
            RepName = new TextBox();
            SuspendLayout();
            // 
            // LabelForEmail
            // 
            LabelForEmail.AutoSize = true;
            LabelForEmail.Location = new Point(33, 121);
            LabelForEmail.Name = "LabelForEmail";
            LabelForEmail.Size = new Size(36, 15);
            LabelForEmail.TabIndex = 16;
            LabelForEmail.Text = "Email";
            // 
            // LabelForPhoneNumber
            // 
            LabelForPhoneNumber.AutoSize = true;
            LabelForPhoneNumber.Location = new Point(33, 92);
            LabelForPhoneNumber.Name = "LabelForPhoneNumber";
            LabelForPhoneNumber.Size = new Size(88, 15);
            LabelForPhoneNumber.TabIndex = 15;
            LabelForPhoneNumber.Text = "Phone Number";
            // 
            // LabelForName
            // 
            LabelForName.AutoSize = true;
            LabelForName.Location = new Point(33, 63);
            LabelForName.Name = "LabelForName";
            LabelForName.Size = new Size(39, 15);
            LabelForName.TabIndex = 14;
            LabelForName.Text = "Name";
            // 
            // Email
            // 
            Email.Location = new Point(125, 118);
            Email.Name = "Email";
            Email.Size = new Size(169, 23);
            Email.TabIndex = 13;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(125, 89);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(169, 23);
            PhoneNumber.TabIndex = 12;
            // 
            // SupName
            // 
            SupName.Location = new Point(125, 60);
            SupName.Name = "SupName";
            SupName.Size = new Size(169, 23);
            SupName.TabIndex = 11;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(279, 15);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 10;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(160, 216);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 17;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // labelForDeliveryFee
            // 
            labelForDeliveryFee.AutoSize = true;
            labelForDeliveryFee.Location = new Point(33, 150);
            labelForDeliveryFee.Name = "labelForDeliveryFee";
            labelForDeliveryFee.Size = new Size(70, 15);
            labelForDeliveryFee.TabIndex = 19;
            labelForDeliveryFee.Text = "Delivery Fee";
            // 
            // DeliveryFee
            // 
            DeliveryFee.Location = new Point(125, 147);
            DeliveryFee.Name = "DeliveryFee";
            DeliveryFee.Size = new Size(169, 23);
            DeliveryFee.TabIndex = 18;
            // 
            // LabelForRepName
            // 
            LabelForRepName.AutoSize = true;
            LabelForRepName.Location = new Point(33, 181);
            LabelForRepName.Name = "LabelForRepName";
            LabelForRepName.Size = new Size(62, 15);
            LabelForRepName.TabIndex = 20;
            LabelForRepName.Text = "Rep Name";
            // 
            // RepName
            // 
            RepName.Location = new Point(125, 178);
            RepName.Name = "RepName";
            RepName.Size = new Size(169, 23);
            RepName.TabIndex = 21;
            // 
            // ManageSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 280);
            Controls.Add(RepName);
            Controls.Add(LabelForRepName);
            Controls.Add(labelForDeliveryFee);
            Controls.Add(DeliveryFee);
            Controls.Add(SubmitButton);
            Controls.Add(LabelForEmail);
            Controls.Add(LabelForPhoneNumber);
            Controls.Add(LabelForName);
            Controls.Add(Email);
            Controls.Add(PhoneNumber);
            Controls.Add(SupName);
            Controls.Add(ReturnButton);
            Name = "ManageSuppliers";
            Text = "add Suplier";
            FormClosed += ManageItems_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelForEmail;
        private Label LabelForPhoneNumber;
        private Label LabelForName;
        private TextBox Email;
        private TextBox PhoneNumber;
        private TextBox SupName;
        private Button ReturnButton;
        private Button SubmitButton;
        private Label labelForDeliveryFee;
        private TextBox DeliveryFee;
        private Label LabelForRepName;
        private TextBox RepName;
    }
}