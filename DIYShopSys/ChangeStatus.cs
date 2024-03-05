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
        public ChangeStatus(MainMenu main,String text)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            this.Text = text;
            if (this.Text.Equals("Manage Supplier Status"))
            {
                this.dataset = new Sql().GetDataSet("select supplier_id,supplier_name,supplier_status from suppliers");
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Manage Type Status"))
            {
                this.dataset = new Sql().GetDataSet("select type_id,type_name,type_status from item_types");
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Manage Item Status"))
            {
                this.dataset = new Sql().GetDataSet("select item_id,item_name,item_status");
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
            if (Grid.SelectedRows.Count == 1) {
                if (this.Text.Equals("Manage Supplier Status"))
                {
                    dataset.Tables[0].Rows[Grid.SelectedRows[0].Index][5] = "a";
                }
                else if (this.Text.Equals("Manage Type Status"))
                {
                    dataset.Tables[0].Rows[Grid.SelectedRows[0].Index][2] = "a";
                }
                else if (this.Text.Equals("Manage Item Status"))
                {
                    dataset.Tables[0].Rows[Grid.SelectedRows[0].Index][8] = "a";
                }
            }
        }

        private void Deativate_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 1) {
                if (this.Text.Equals("Manage Supplier Status"))
                {
                    dataset.Tables[0].Rows[Grid.SelectedRows[0].Index][5] = "d";
                }
                else if (this.Text.Equals("Manage Type Status"))
                {
                    dataset.Tables[0].Rows[Grid.SelectedRows[0].Index][2] = "d";
                }
                else if (this.Text.Equals("Manage Item Status"))
                {
                    dataset.Tables[0].Rows[Grid.SelectedRows[0].Index][8] = "d";
                }
            }
        }
    }
}
