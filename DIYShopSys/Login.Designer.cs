namespace DIYShopSys
{
    partial class Login
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
            LabelForPassword = new Label();
            Password = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LabelForPassword
            // 
            LabelForPassword.AutoSize = true;
            LabelForPassword.Location = new Point(12, 22);
            LabelForPassword.Name = "LabelForPassword";
            LabelForPassword.Size = new Size(57, 15);
            LabelForPassword.TabIndex = 1;
            LabelForPassword.Text = "Password";
            // 
            // Password
            // 
            Password.Location = new Point(75, 19);
            Password.Name = "Password";
            Password.Size = new Size(128, 23);
            Password.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(75, 48);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 94);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(LabelForPassword);
            MaximumSize = new Size(245, 133);
            MinimumSize = new Size(245, 133);
            Name = "Login";
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelForPassword;
        private TextBox Password;
        private Button LoginButton;
    }
}