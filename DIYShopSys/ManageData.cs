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
            if (this.Text.Contains("Supplier"))
            {
                DataSet dataset = new Sql().PullData(this.Text);
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Contains("Item"))
            {
                DataSet dataset = new Sql().PullData(this.Text);
                Grid.DataSource = dataset.Tables[0];
                if (this.Text.Equals("Restock Items"))
                {
                    QuantityBox.Visible = true;
                    QuantityLabel.Visible = true;
                }
                else if (this.Text.Equals("Query Items"))
                {
                    SubmitButton.Visible = false;
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            /*https://stackoverflow.com/questions/56009158/how-to-check-if-a-cell-in-selected-row-in-datagridview-is-empty-null-using-c
            came up with grid Selceted rows while looking at site
             */

            // checks if row is selected
            if (Grid.SelectedRows.Count == 1)
            {
                DataGridViewRow row = Grid.SelectedRows[0];
                /*used this to learn how to change form name in c#
                 * first answer on page
                 * https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
                 */
                //restock
                if (this.Text.Contains("Restock"))
                {
                    MessageBox.Show("You have Added Stock", "Added Stock", MessageBoxButtons.OK);
                }

                // update details
                else if (this.Text.Contains("Update"))
                {
                    //updates Supplier
                    if (this.Text.Equals("Update Supplier Details"))
                    {
                        String Text = "Update Supplier Details";
                        AddAndUpdateSuppliers AddAndUpdateSupplier = new AddAndUpdateSuppliers(row, this, Text);
                        AddAndUpdateSupplier.Show();
                    }
                    //updates item
                    else if (this.Text.Equals("Update Item Details"))
                        {
                            String Text = "Update Item Details";
                            AddAndUpdateItems AddAndUpdateItems = new AddAndUpdateItems(row, this, Text);
                            AddAndUpdateItems.Show();
                        }
                }

                // remove function
                else if (this.Text.Contains("Remove")) 
                {
                    if (this.Text.Equals("Remove Suppliers"))
                    {
                        MessageBox.Show("Supplier Still Supplies Item", "Can't Remove Supplier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (this.Text.Equals("Remove Items"))
                    {
                        MessageBox.Show("Item Has Been Removed","Item Removed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                //error for devs
                else
                    {
                        MessageBox.Show("Form Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
