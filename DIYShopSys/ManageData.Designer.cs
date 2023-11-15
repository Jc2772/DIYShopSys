namespace DIYShopSys
{
    partial class ManageData
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
            Grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(326, 415);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(113, 23);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit Button";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(682, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(106, 23);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Return Button";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.BackgroundColor = SystemColors.Control;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Location = new Point(12, 76);
            Grid.MultiSelect = false;
            Grid.Name = "Grid";
            Grid.RowTemplate.Height = 25;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.Size = new Size(776, 286);
            Grid.TabIndex = 2;
            // 
            // ManageData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Grid);
            Controls.Add(ReturnButton);
            Controls.Add(SubmitButton);
            Name = "ManageData";
            Text = "Form1";
            FormClosed += ManageData_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SubmitButton;
        private Button ReturnButton;
        private DataGridView Grid;
    }
}