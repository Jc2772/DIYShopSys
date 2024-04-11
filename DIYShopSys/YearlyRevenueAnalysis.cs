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
        String[] months = new string[12];
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
            GrossProfitChart.Series[0].Points.DataBindXY(months, grossammounts);
            GrossProfitChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            GrossProfitChart.Series[0].Label = "#VALY";

            GrossProfitChart.Visible = true;

            ProfitChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ProfitChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            ProfitChart.Series[0].LegendText = "YearlyIncome in €";
            ProfitChart.Series[0].Points.DataBindXY(months, ammounts);
            ProfitChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            ProfitChart.Series[0].Label = "#VALY";

            ProfitChart.Visible = true;
            DataBox.Visible = true;
        }
        private void GetData()
        {
            DataSet ds = new Sql().GetDataSet("SELECT SUM(total), to_Char(Sale_Date,'MM') FROM Sales Where To_Char(Sale_Date,'YYYY') = '" + Year.Text + "' GROUP BY to_Char(Sale_Date,'MM')");
            DataSet ds2 = new Sql().GetDataSet("SELECT SUM(total), to_Char(Order_Date,'MM') FROM Orders Where To_Char(Order_Date,'YYYY') = '" + Year.Text + "'  GROUP BY to_Char(Order_Date,'MM')");
            
            for (int i = 0; i < 12; i++)
            {
                if (ds.Tables[0].Rows.Count > i) {
                    grossammounts[i] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);
                    months[i] = GetMonths(Convert.ToInt32(ds.Tables[0].Rows[i][1]));
                    ammounts[i] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]) - Convert.ToDecimal(ds2.Tables[0].Rows[i][0]);
                }
                else
                {
                    grossammounts[i] = 0; months[i] = GetMonths(i + 1); ammounts[i] = 0;
                }
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
        private String GetMonths(int Month)
        {
            switch (Month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APL";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default:
                    {
                        return "OTH";
                    }
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
