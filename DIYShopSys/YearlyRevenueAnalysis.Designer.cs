namespace DIYShopSys
{
    partial class YearlyRevenueAnalysis
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(410, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Return Button";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // YearlyRevenueAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 760);
            Controls.Add(ReturnButton);
            Name = "YearlyRevenueAnalysis";
            Text = "analysis";
            ResumeLayout(false);
        }

        #endregion
        private Button ReturnButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}