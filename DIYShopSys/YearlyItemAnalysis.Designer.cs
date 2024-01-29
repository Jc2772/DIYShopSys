namespace DIYShopSys
{
    partial class YearlyItemAnalysis
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
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(413, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 3;
            ReturnButton.Text = "Return Button";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // YearlyItemAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 344);
            Controls.Add(ReturnButton);
            Name = "YearlyItemAnalysis";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnButton;
    }
}