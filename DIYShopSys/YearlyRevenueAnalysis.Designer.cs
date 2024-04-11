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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ReturnButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Year = new ComboBox();
            DataBox = new GroupBox();
            ProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            GrossProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfitChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrossProfitChart).BeginInit();
            SuspendLayout();
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(707, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Return Button";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Year
            // 
            Year.FormattingEnabled = true;
            Year.Location = new Point(12, 12);
            Year.Name = "Year";
            Year.Size = new Size(121, 23);
            Year.TabIndex = 3;
            Year.SelectedIndexChanged += Year_SelectedIndexChanged;
            // 
            // DataBox
            // 
            DataBox.Controls.Add(ProfitChart);
            DataBox.Controls.Add(GrossProfitChart);
            DataBox.Location = new Point(-1, 41);
            DataBox.Name = "DataBox";
            DataBox.Size = new Size(783, 532);
            DataBox.TabIndex = 4;
            DataBox.TabStop = false;
            DataBox.Visible = false;
            // 
            // ProfitChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            ProfitChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ProfitChart.Legends.Add(legend1);
            ProfitChart.Location = new Point(409, 31);
            ProfitChart.Name = "ProfitChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 1;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ProfitChart.Series.Add(series1);
            ProfitChart.Size = new Size(374, 495);
            ProfitChart.TabIndex = 1;
            ProfitChart.Text = "chart2";
            ProfitChart.Visible = false;
            // 
            // GrossProfitChart
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            GrossProfitChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            GrossProfitChart.Legends.Add(legend2);
            GrossProfitChart.Location = new Point(13, 31);
            GrossProfitChart.Name = "GrossProfitChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.EmptyPointStyle.IsValueShownAsLabel = true;
            series2.EmptyPointStyle.LabelAngle = 1;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            GrossProfitChart.Series.Add(series2);
            GrossProfitChart.Size = new Size(384, 495);
            GrossProfitChart.TabIndex = 0;
            GrossProfitChart.Text = "chart1";
            GrossProfitChart.Visible = false;
            // 
            // YearlyRevenueAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 760);
            Controls.Add(DataBox);
            Controls.Add(Year);
            Controls.Add(ReturnButton);
            Name = "YearlyRevenueAnalysis";
            Text = "Yearly Revenue Analysis";
            FormClosed += YearlyRevenueAnalysis_FormClosed;
            DataBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProfitChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrossProfitChart).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ReturnButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox Year;
        private GroupBox DataBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProfitChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrossProfitChart;
    }
}