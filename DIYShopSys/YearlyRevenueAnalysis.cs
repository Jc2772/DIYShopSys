using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DIYShopSys
{
    public partial class YearlyRevenueAnalysis : Form
    {
        decimal[] grossammounts = new decimal[12], ammounts = new decimal[12];
        String[] months;
        MainMenu main;
        public YearlyRevenueAnalysis()
        {
            InitializeComponent();
        }
        public YearlyRevenueAnalysis(MainMenu main)
        {
            this.main = main;
            main.Hide();
            InitializeComponent();
            GetDates();
            GrossProfitChart.Titles.Add("Yearly Gross Revenue");
            ProfitChart.Titles.Add("Yearly Revenue");
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GetData();
            GrossProfitChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            GrossProfitChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            GrossProfitChart.Series[0].LegendText = "YearlyIncome in €";
            GrossProfitChart.Series[0].Points.DataBindXY(grossmonths, grossammounts);
            GrossProfitChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            GrossProfitChart.Series[0].Label = "#VALY";

            GrossProfitChart.Visible = true;

            ProfitChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ProfitChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            ProfitChart.Series[0].LegendText = "YearlyIncome in €";
            ProfitChart.Series[0].Points.DataBindXY(months, ammounts);
            ProfitChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            ProfitChart.Series[0].Label = "#VALY";
            DataBox.Visible = true;
        }
        private void GetData()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(new Sql().GetDataTable("SELECT SUM(total), to_Char(Sale_Date,'MM') FROM Sales Where To_Char(Sale_Date,'YYYY') = '" + Year.Text + "' GROUP BY to_Char(Sale_Date,'MM')"));
            ds.Tables.Add(new Sql().GetDataTable("SELECT SUM(total), to_Char(Order_Date,'MM') FROM Orders Where To_Char(Order_Date,'YYYY') = '" + Year.Text + "'  GROUP BY to_Char(Order_Date,'MM')"));
            this.months = new string[12];
            this.months = ["JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"];
            //to check if data does not exist https://stackoverflow.com/questions/2976473/how-to-test-if-a-dataset-is-empty
            if (ds.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i < 12; i++)
                {
                    this.grossammounts[i] = 0;
                    this.ammounts[i] = 0;
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    grossammounts[Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    for(int i = 0; i < ds.Tables[1].Rows.Count; i++)
                    {
                        ammounts
                    }
                }
            }
            else
            {
                MessageBox.Show("Data For " + Year.Text + "Does Not Exist");
                DataBox.Visible = false;
            }
        }
        private void GetDates()
        {
            int year = DateTime.Today.Year;

            for (int i = 0; i < 5; i++)
            {
                Year.Items.Add(year.ToString());
                year--;
            }
        }
        // stop program
        private void ChangeStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                Application.Exit();
            }
        }

        private void YearlyRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!main.Visible)
            {
                Application.Exit();
            }
        }
    }
}
