using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.

namespace DIYShopSys
{
    public partial class YearlyRevenueAnalysis : Form
    {
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
        // stop program
        private void ChangeStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                main.Close();
            }
        }
    }
}
