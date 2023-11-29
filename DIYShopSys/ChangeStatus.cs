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
    public partial class ChangeStatus : Form
    {
        MainMenu main;
        DataSet dataset;
        public ChangeStatus()
        {
            InitializeComponent();
        }
        public ChangeStatus(MainMenu main)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            if (this.Text.Equals("Manage Supplier Status"))
            {
                this.dataset = new Sql().SupplierData();
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Manage Types Status"))
            {
                this.dataset = new Sql().typesData();
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Manage Item Status"))
            {
                this.dataset = new Sql().itemsData();
                Grid.DataSource = dataset.Tables[0];
            }
        }
        // return
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

        private void Activate_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Manage Supplier Status"))
            {
                this.dataset = new Sql().SupplierData();
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Manage Types Status"))
            {
                this.dataset = new Sql().typesData();
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Manage Item Status"))
            {
                this.dataset = new Sql().itemsData();
                Grid.DataSource = dataset.Tables[0];
            }
        }

        private void Deativate_Click(object sender, EventArgs e)
        {
            if () {
                if (this.Text.Equals("Manage Supplier Status"))
                {
                    dataset.Tables[].Rows[][3].Va
                }
                else if (this.Text.Equals("Manage Types Status"))
                {

                }
                else if (this.Text.Equals("Manage Item Status"))
                {

                }
            }
        }
    }
}
