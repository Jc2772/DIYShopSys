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
            resetDataset();
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
                    new Sql().AddOrUpdate();
                    resetDataset();
                }
                else if (this.Text.Equals("Manage Type Status"))
                {
                    new Sql().AddOrUpdate();
                    resetDataset();
                }
                else if (this.Text.Equals("Manage Item Status"))
                {
                    new Sql().AddOrUpdate();
                    resetDataset();
                }
            }
        }

        private void Deativate_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 1) {
                if (this.Text.Equals("Manage Supplier Status"))
                {
                    new Sql().AddOrUpdate();
                    resetDataset();
                }
                else if (this.Text.Equals("Manage Type Status"))
                {
                    new Sql().AddOrUpdate();
                    resetDataset();
                }
                else if (this.Text.Equals("Manage Item Status"))
                {
                    new Sql().AddOrUpdate();
                    resetDataset();
                }
            }
        }
        private void resetDataset()
        {
            if (this.Text.Equals("Manage Supplier Status"))
            {
                this.dataset = new Sql().GetDataSet("select supplier_id,supplier_name,supplier_status from suppliers");
                Grid.DataSource = dataset.Tables[0];
                Grid.Columns[0].Visible = false;
                Grid.Columns[1].HeaderText = "Supplier";
                Grid.Columns[2].HeaderText = "Status";
            }
            else if (this.Text.Equals("Manage Type Status"))
            {
                this.dataset = new Sql().GetDataSet("select type_id,type_name,type_status from item_types");
                Grid.DataSource = dataset.Tables[0];
                Grid.Columns[0].Visible = false;
                Grid.Columns[1].HeaderText = "Type";
                Grid.Columns[2].HeaderText = "Status";
            }
            else if (this.Text.Equals("Manage Item Status"))
            {
                this.dataset = new Sql().GetDataSet("select item_id,item_name,item_status from items");
                Grid.DataSource = dataset.Tables[0];
                Grid.Columns[0].Visible = false;
                Grid.Columns[1].HeaderText = "Item";
                Grid.Columns[2].HeaderText = "Status";
            }
        }
    }
}
