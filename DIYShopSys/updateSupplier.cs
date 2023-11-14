﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYShopSys
// https://www.aspsnippets.com/Articles/Get-Cell-Value-of-Selected-DataGridView-Row-in-Windows-Application-using-C-and-VBNet.aspx
{
    public partial class updateSupplier : Form
    {
        MainMenu main;
        public updateSupplier()
        {
            InitializeComponent();
        }
        public updateSupplier(MainMenu main)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            if (this.Text.Equals("Restock item"))
            {

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            /*https://stackoverflow.com/questions/56009158/how-to-check-if-a-cell-in-selected-row-in-datagridview-is-empty-null-using-c
            came up with grid Selceted rows while looking at site
             */
            if (Grid.SelectedRows.Count == 1)
            {
                DataGridViewRow row = Grid.SelectedRows[0];
                /*used this to learn how to change form name in c#
                 * first answer on page
                 * https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
                 */
                
                if(this.Text.Equals("Restock item"))
                {
                    
                }
                else
                {
                    AddAndUpdate AddAndUpdate = new AddAndUpdate(row, this);
                    if (this.Text.Equals("Update Supplier Details"))
                    {

                        AddAndUpdate.Text = "Update Supplier Details";
                        AddAndUpdate.Show();
                    }
                    else if (this.Text.Equals("Update Item Details"))
                    {
                        AddAndUpdate.Show();
                    }
                    else
                    {
                        MessageBox.Show("Form Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Row Not Selected","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void updateSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                main.Close();
            }
        }
    }
}
