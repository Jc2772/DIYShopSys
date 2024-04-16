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
    public partial class YearlyItemAnalysis : Form
    {
        MainMenu main;
        int[] ammounts;
        string[] item_types;
        public YearlyItemAnalysis(MainMenu main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Got Code From Here https://stackoverflow.com/questions/34104484/how-to-build-a-pie-chart-based-on-int-values
            ItemChart.Series.Clear();
            ItemChart.Legends.Clear();
            ItemChart.Legends.Add("MyLegend");
            ItemChart.Legends[0].LegendStyle = LegendStyle.Table;
            ItemChart.Legends[0].Docking = Docking.Bottom;
            ItemChart.Legends[0].Alignment = StringAlignment.Center;
            ItemChart.Legends[0].Title = "MyTitle";
            ItemChart.Legends[0].BorderColor = Color.Black;

            string seriesname = "Yearly Item Analysis";
            ItemChart.Series.Add(seriesname);

            GetData();
            ItemChart.Series[0].Points.DataBindXY(item_types, ammounts);
        }
        private void GetData()
        {
            DataSet ds = new Sql().GetDataSet("Select Sum(quantity_sold),Type_Name from (items inner join item_types on items.type_id = type.type_id) inner join basket on items.item_id = basket.item_id group by type_name");
            this.item_types = new string[ds.Tables[0].Rows.Count];
            this.ammounts = new int[ds.Tables[0].Rows.Count];
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                this.ammounts[i] = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                this.item_types[i] = ds.Tables[0].Rows[i][1].ToString();
            }
        }
        public void GetDate()
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
    }
}
