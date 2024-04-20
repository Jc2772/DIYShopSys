namespace DIYShopSys
{
    partial class ManageTypes
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
            TypeName = new TextBox();
            LabelForTypeName = new Label();
            ReturnButton = new Button();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // TypeName
            // 
            TypeName.Location = new Point(87, 52);
            TypeName.Name = "TypeName";
            TypeName.Size = new Size(100, 23);
            TypeName.TabIndex = 0;
            // 
            // LabelForTypeName
            // 
            LabelForTypeName.AutoSize = true;
            LabelForTypeName.Location = new Point(30, 52);
            LabelForTypeName.Name = "LabelForTypeName";
            LabelForTypeName.Size = new Size(39, 15);
            LabelForTypeName.TabIndex = 1;
            LabelForTypeName.Text = "Name";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(186, 13);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(53, 23);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(96, 81);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ManageTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 144);
            Controls.Add(SubmitButton);
            Controls.Add(ReturnButton);
            Controls.Add(LabelForTypeName);
            Controls.Add(TypeName);
            MaximumSize = new Size(275, 183);
            MinimumSize = new Size(275, 183);
            Name = "ManageTypes";
            Text = "Form1";
            FormClosed += ManageItems_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TypeName;
        private Label LabelForTypeName;
        private Button ReturnButton;
        private Button SubmitButton;
    }
}