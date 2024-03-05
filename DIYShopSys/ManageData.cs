﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            if (this.Text.Equals("Update Supplier Details"))
            {
                DataSet dataset = new Sql().GetDataSet("select supplier_id,supplier_name, phone_number, email, delivery_fee, rep_name from suppliers where supplier_status = 'a'");
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Update Type Detail"))
            {
                DataSet dataset = new Sql().GetDataSet("select type_id,type_name from item_types where type_status = 'a'");
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Update Item Details"))
            {
                DataSet dataset = new Sql().GetDataSet("select item_id, item_name, item_price, item_cost from items where item_status = 'a'");
                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Equals("Query Supplier Details"))
            {
                DataSet dataset = new Sql().GetDataSet("select supplier_name, phone_number, email, delivery_fee, rep_name from suppliers where supplier_status = 'a'");
                Grid.DataSource = dataset.Tables[0];
                SubmitButton.Visible = false;
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
                    ManageSuppliers ManageSupplier = new ManageSuppliers(row, this, Text);
                    ManageSupplier.Show();
                }
                else if(this.Text.Equals("Update Type Detail"))
                {
                    String Text = "Update Type Detail";
                    ManageTypes ManageTypes = new ManageTypes(row, this, Text);
                    ManageTypes.Show();
                }
                //updates item
                else if (this.Text.Equals("Update Item Details"))
                {
                    String Text = "Update Item Details";
                    ManageItems ManageItems = new ManageItems(row, this, Text);
                    ManageItems.Show();
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
