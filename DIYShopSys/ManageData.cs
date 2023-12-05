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
    public partial class ManageData : Form
    {
        MainMenu main;
        public ManageData()
        {
            InitializeComponent();
        }
        public ManageData(MainMenu main, String Text)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            this.Text = Text;
            //populate dataset
            //got grid.datasource code from 
            if (this.Text.Equals("Update Supplier Details"))
            {
                DataSet dataset = new Sql().SupplierData();
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Update Type Detail"))
            {
                DataSet dataset = new Sql().typesData();
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Contains("Item"))
            {
                DataSet dataset = new Sql().itemsData();
                Grid.DataSource = dataset.Tables[0];
                if (this.Text.Equals("Query Items"))
                {
                    SubmitButton.Visible = false;
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // checks if row is selected
            if (Grid.SelectedRows.Count == 1)
            {
                /*https://stackoverflow.com/questions/56009158/how-to-check-if-a-cell-in-selected-row-in-datagridview-is-empty-null-using-c
                    came up with grid Selceted rows while looking at site
                */
                DataGridViewRow row = Grid.SelectedRows[0];
                /*used this to learn how to change form name in c#
                 * first answer on page
                 * https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
                 */

                //updates Supplier
                if (this.Text.Equals("Update Supplier Details"))
                {
                    String Text = "Update Supplier Details";
                    AddAndUpdateSuppliers AddAndUpdateSupplier = new AddAndUpdateSuppliers(row, this, Text);
                    AddAndUpdateSupplier.Show();
                }
                else if(this.Text.Equals("Update Type Detail"))
                {
                    String Text = "Update Type Detail";
                    AddAndUpdateTypes AddAndUpdateTypes = new AddAndUpdateTypes(row, this, Text);
                    AddAndUpdateTypes.Show();
                }
                //updates item
                else if (this.Text.Equals("Update Item Details"))
                {
                    String Text = "Update Item Details";
                    AddAndUpdateItems AddAndUpdateItems = new AddAndUpdateItems(row, this, Text);
                    AddAndUpdateItems.Show();
                } 
            }
            else
            {
                MessageBox.Show("Row Not Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // return
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
        // stop program
        private void ManageData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                main.Close();
            }
        }
    }
}
