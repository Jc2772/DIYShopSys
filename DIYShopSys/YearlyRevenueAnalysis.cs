using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYShopSys
{
    public partial class YearlyRevenueAnalysis : Form
    {
        decimal[] grossammounts = new decimal[12];
        String[] months = new string[12];
        decimal[] ammounts = new decimal[12];
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

            GrossProfitChart.Titles.Add("Yearly Gross Revenue");

            GrossProfitChart.Visible = true;

            ProfitChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ProfitChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            ProfitChart.Series[0].LegendText = "YearlyIncome in €";
            GrossProfitChart.Series[0].Points.DataBindXY(months, ammounts);
            ProfitChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            ProfitChart.Series[0].Label = "#VALY";

            ProfitChart.Titles.Add("Yearly Revenue");

            ProfitChart.Visible = true;
        }
        private void GetData()
        {
            DataSet ds = new Sql().GetDataSet();
            DataSet ds2 = new Sql().GetDataSet();
            for(int i = 0; i < 12; i++)
            {
                grossammounts[i] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);
                months[i] = GetMonths(Convert.ToInt32(ds.Tables[0].Rows[i][1]));
                ammounts[i] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]) - Convert.ToDecimal(ds2.Tables[0].Rows[i][0]);
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
                        return "FEB";
                    }
                case 4:
                    {
                        return "FEB";
                    }
                case 5:
                    {
                        return "FEB";
                    }
                case 6:
                    {
                        return "FEB";
                    }
                case 7:
                    {
                        return "FEB";
                    }
                case 8:
                    {
                        return "FEB";
                    }
                case 9:
                    {
                        return "FEB";
                    }
                case 10:
                    {
                        return "FEB";
                    }
                case 11:
                    {
                        return "FEB";
                    }
                case 12:
                    {
                        return "FEB";
                    }
                default: 
                    {
                        return "Oth";
                    }
            }
        }
    }
}
