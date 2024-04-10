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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ReturnButton = new Button();
            ItemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Year = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ItemChart).BeginInit();
            SuspendLayout();
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(534, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 3;
            ReturnButton.Text = "Return Button";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // ItemChart
            // 
            chartArea2.Name = "ChartArea1";
            ItemChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ItemChart.Legends.Add(legend2);
            ItemChart.Location = new Point(12, 61);
            ItemChart.Name = "ItemChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ItemChart.Series.Add(series2);
            ItemChart.Size = new Size(300, 300);
            ItemChart.TabIndex = 4;
            ItemChart.Visible = false;
            // 
            // Year
            // 
            Year.FormattingEnabled = true;
            Year.Location = new Point(12, 13);
            Year.Name = "Year";
            Year.Size = new Size(103, 23);
            Year.TabIndex = 5;
            Year.SelectedIndexChanged += Year_SelectedIndexChanged;
            // 
            // YearlyItemAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 373);
            Controls.Add(Year);
            Controls.Add(ItemChart);
            Controls.Add(ReturnButton);
            Name = "YearlyItemAnalysis";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ItemChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ItemChart;
        private ComboBox Year;
    }
}