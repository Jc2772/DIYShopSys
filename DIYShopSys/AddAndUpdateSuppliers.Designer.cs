namespace DIYShopSys
{
    partial class AddAndUpdateSuppliers
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
            // Name
            // 
            SupName.Location = new Point(125, 60);
            SupName.Name = "Name";
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
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(158, 147);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 17;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 204);
            Controls.Add(SubmitButton);
            Controls.Add(LabelForEmail);
            Controls.Add(LabelForPhoneNumber);
            Controls.Add(LabelForName);
            Controls.Add(Email);
            Controls.Add(PhoneNumber);
            Controls.Add(SupName);
            Controls.Add(ReturnButton);
            Name = "AddAndUpdateSuppliers";
            Text = "Form1";
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
    }
}