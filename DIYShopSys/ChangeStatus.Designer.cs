namespace DIYShopSys
{
    partial class ChangeStatus
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
            Grid = new DataGridView();
            ReturnButton = new Button();
            Activate = new Button();
            Deativate = new Button();
            SearchLabel = new Label();
            SearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.BackgroundColor = SystemColors.Control;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Location = new Point(12, 75);
            Grid.MultiSelect = false;
            Grid.Name = "Grid";
            Grid.ReadOnly = true;
            Grid.RowTemplate.Height = 25;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.Size = new Size(776, 286);
            Grid.TabIndex = 4;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(682, 11);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(106, 23);
            ReturnButton.TabIndex = 3;
            ReturnButton.Text = "Return Button";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Activate
            // 
            Activate.Location = new Point(263, 385);
            Activate.Name = "Activate";
            Activate.Size = new Size(83, 23);
            Activate.TabIndex = 5;
            Activate.Text = "Activate";
            Activate.UseVisualStyleBackColor = true;
            Activate.Click += Activate_Click;
            // 
            // Deativate
            // 
            Deativate.Location = new Point(430, 385);
            Deativate.Name = "Deativate";
            Deativate.Size = new Size(83, 23);
            Deativate.TabIndex = 6;
            Deativate.Text = "Deactivate";
            Deativate.UseVisualStyleBackColor = true;
            Deativate.Click += Deativate_Click;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(251, 49);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(42, 15);
            SearchLabel.TabIndex = 8;
            SearchLabel.Text = "Search";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(309, 46);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(169, 23);
            SearchBox.TabIndex = 7;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // ChangeStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchLabel);
            Controls.Add(SearchBox);
            Controls.Add(Deativate);
            Controls.Add(Activate);
            Controls.Add(Grid);
            Controls.Add(ReturnButton);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "ChangeStatus";
            Text = "Form1";
            FormClosed += ChangeStatus_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid;
        private Button ReturnButton;
        private Button Activate;
        private Button Deativate;
        private Label SearchLabel;
        private TextBox SearchBox;
    }
}