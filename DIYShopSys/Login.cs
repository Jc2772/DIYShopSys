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
    public partial class Login : Form
    {
        Sales sales;
        public Login()
        {
            InitializeComponent();
        }
        public Login(Sales sales)
        {
            InitializeComponent();
            this.sales = sales;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Password.Text.Equals("password"))
            {
                this.sales.Hide();
                new MainMenu(this.sales).Show();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
