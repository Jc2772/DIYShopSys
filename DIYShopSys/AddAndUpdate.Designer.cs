namespace DIYShopSys
{
    partial class AddAndUpdate
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
            Input1 = new TextBox();
            Input2 = new TextBox();
            Input3 = new TextBox();
            Input4 = new TextBox();
            ComboBox = new ComboBox();
            LabelForInput1 = new Label();
            LabelForInput2 = new Label();
            LabelForInput3 = new Label();
            LabelForCombo = new Label();
            LabelForInput4 = new Label();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(148, 217);
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
            // Input1
            // 
            Input1.Location = new Point(117, 57);
            Input1.Name = "Input1";
            Input1.Size = new Size(169, 23);
            Input1.TabIndex = 2;
            // 
            // Input2
            // 
            Input2.Location = new Point(117, 86);
            Input2.Name = "Input2";
            Input2.Size = new Size(169, 23);
            Input2.TabIndex = 3;
            // 
            // Input3
            // 
            Input3.Location = new Point(117, 115);
            Input3.Name = "Input3";
            Input3.Size = new Size(169, 23);
            Input3.TabIndex = 4;
            // 
            // Input4
            // 
            Input4.Location = new Point(117, 173);
            Input4.Name = "Input4";
            Input4.Size = new Size(169, 23);
            Input4.TabIndex = 5;
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(117, 144);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(169, 23);
            ComboBox.TabIndex = 6;
            // 
            // LabelForInput1
            // 
            LabelForInput1.AutoSize = true;
            LabelForInput1.Location = new Point(25, 60);
            LabelForInput1.Name = "LabelForInput1";
            LabelForInput1.Size = new Size(86, 15);
            LabelForInput1.TabIndex = 7;
            LabelForInput1.Text = "LabelForInput1";
            // 
            // LabelForInput2
            // 
            LabelForInput2.AutoSize = true;
            LabelForInput2.Location = new Point(25, 89);
            LabelForInput2.Name = "LabelForInput2";
            LabelForInput2.Size = new Size(86, 15);
            LabelForInput2.TabIndex = 8;
            LabelForInput2.Text = "LabelForInput2";
            // 
            // LabelForInput3
            // 
            LabelForInput3.AutoSize = true;
            LabelForInput3.Location = new Point(25, 118);
            LabelForInput3.Name = "LabelForInput3";
            LabelForInput3.Size = new Size(86, 15);
            LabelForInput3.TabIndex = 9;
            LabelForInput3.Text = "LabelForInput3";
            // 
            // LabelForCombo
            // 
            LabelForCombo.AutoSize = true;
            LabelForCombo.Location = new Point(19, 147);
            LabelForCombo.Name = "LabelForCombo";
            LabelForCombo.Size = new Size(92, 15);
            LabelForCombo.TabIndex = 10;
            LabelForCombo.Text = "LabelForCombo";
            // 
            // LabelForInput4
            // 
            LabelForInput4.AutoSize = true;
            LabelForInput4.Location = new Point(25, 176);
            LabelForInput4.Name = "LabelForInput4";
            LabelForInput4.Size = new Size(86, 15);
            LabelForInput4.TabIndex = 11;
            LabelForInput4.Text = "LabelForInput4";
            // 
            // AddAndUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 285);
            Controls.Add(LabelForInput4);
            Controls.Add(LabelForCombo);
            Controls.Add(LabelForInput3);
            Controls.Add(LabelForInput2);
            Controls.Add(LabelForInput1);
            Controls.Add(ComboBox);
            Controls.Add(Input4);
            Controls.Add(Input3);
            Controls.Add(Input2);
            Controls.Add(Input1);
            Controls.Add(ReturnButton);
            Controls.Add(SubmitButton);
            Name = "AddAndUpdate";
            Text = "Form2";
            FormClosed += AddAndUpdate_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ReturnButton;
        private TextBox Input1;
        private TextBox Input2;
        private TextBox Input3;
        private TextBox Input4;
        private ComboBox ComboBox;
        private Label LabelForInput1;
        private Label LabelForInput2;
        private Label LabelForInput3;
        private Label LabelForCombo;
        private Label LabelForInput4;
    }
}