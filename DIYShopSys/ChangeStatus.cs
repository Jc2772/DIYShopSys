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
        public ChangeStatus(MainMenu main, String text)
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
            if (Grid.SelectedRows.Count == 1)
            {
                if (this.Text.Equals("Manage Supplier Status"))
                {
                    new Sql().AddOrUpdate("Update suppliers set supplier_status = 'a' where supplier_id = " + Grid.SelectedRows[0].Cells[0].Value.ToString());
                    resetDataset();
                }
                else if (this.Text.Equals("Manage Type Status"))
                {
                    new Sql().AddOrUpdate("Update type set type_status = 'a' where type_id = " + Grid.SelectedRows[0].Cells[0].Value.ToString());
                    resetDataset();
                }
                else if (this.Text.Equals("Manage Item Status"))
                {
                    new Sql().AddOrUpdate("Update items set item_status = 'a' where item_id = " + Grid.SelectedRows[0].Cells[0].Value.ToString());
                    resetDataset();
                }
            }
        }

        private void Deativate_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 1)
            {
                if (this.Text.Equals("Manage Supplier Status"))
                {
                    DialogResult dialogresult = MessageBox.Show("Deactivating Supplier Will Deactivate all items associated with the supplier, Are You Sure You Want to do this", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogresult == DialogResult.Yes)
                    {
                        new Sql().AddOrUpdate("Update suppliers set supplier_status = 'd' where supplier_id = " + Grid.SelectedRows[0].Cells[0].Value.ToString());
                        resetDataset();

                    }
                }
                else if (this.Text.Equals("Manage Type Status"))
                {
                    DialogResult dialogresult = MessageBox.Show("Deactivating Supplier Will Deactivate all items associated with the supplier, Are You Sure You Want to do this", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogresult == DialogResult.Yes)
                    {
                        new Sql().AddOrUpdate("Update type set type_status = 'd' where type_id = " + Grid.SelectedRows[0].Cells[0].Value.ToString());
                        resetDataset();
                    }
                }
                else if (this.Text.Equals("Manage Item Status"))
                {
                    new Sql().AddOrUpdate("Update items set item_status = 'd' where item_id = " + Grid.SelectedRows[0].Cells[0].Value.ToString());
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            String text;
            if (this.Text.Equals("Manage Supplier Status"))
            {
                text = "Supplier name = " + SearchBox.Text;
            }
            else if (this.Text.Equals("Manage Type Status"))
            {
                text = "Type name = " + SearchBox.Text;
            }
            else if (this.Text.Equals("Manage Item Status"))
            {
                text = "Item name = " + SearchBox.Text;
            }
            else
            {
                text = "";
            }
            (Grid.DataSource as DataTable).DefaultView.RowFilter = text;
        }
    }
}
