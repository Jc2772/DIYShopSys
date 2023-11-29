﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYShopSys
{
    public partial class RestockItems : Form
    {
        MainMenu mainMenu;
        DataSet dataset;
        Double total;
        public RestockItems()
        {
            InitializeComponent();
        }
        public RestockItems(MainMenu main)
        {
            InitializeComponent();
            this.mainMenu = main;
            main.Hide();
            resetDataset();
            /*used this to hide columns
             * https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/remove-autogenerated-columns-from-a-wf-datagridview-control?view=netframeworkdesktop-4.8
                */
            Items.Columns[3].Visible = false;
            Items.Columns[4].Visible = false;
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                if (!Supplier.Items.Contains(dataset.Tables[0].Rows[i][3].ToString() + "-" + dataset.Tables[0].Rows[i][4].ToString()))
                {
                    Supplier.Items.Add(dataset.Tables[0].Rows[i][3].ToString() + "-" + dataset.Tables[0].Rows[i][4].ToString());
                }
            }
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (Items.SelectedRows.Count == 1)
            {
                if (Basket.Rows.Count > 0)
                {
                    for (int i = 0; i < Basket.Rows.Count; i++)
                    {
                        if (Basket.Rows[i].Cells[0].Value.ToString().Equals(Items.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            dataset.Tables[1].Rows[0][2] = Convert.ToInt32(dataset.Tables[1].Rows[Items.SelectedRows[0].Index][2]) + 1;
                            //dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][4]) - 1;
                            total += Convert.ToDouble(Items.SelectedRows[0].Cells[2].Value.ToString());
                            TotalLabel.Text = "total = " + total;
                            return;
                        }
                    }
                    addToBasket();
                }
                else
                {
                    addToBasket();
                }
                total += Convert.ToDouble(Items.SelectedRows[0].Cells[2].Value.ToString());
                TotalLabel.Text = "total = " + total;
            }
        }

        private void RemoveItemFromBasket_Click(object sender, EventArgs e)
        {
            if (Basket.SelectedRows.Count == 1)
            {
                total -= Convert.ToDouble(Basket.SelectedRows[0].Cells[1].Value.ToString());
                TotalLabel.Text = "total = " + total;
                if (Convert.ToInt32(dataset.Tables[1].Rows[Basket.SelectedRows[0].Index][2]) == 1)
                {
                    dataset.Tables[1].Rows.RemoveAt(Basket.SelectedRows[0].Index);
                }
                else
                {
                    dataset.Tables[1].Rows[0][2] = Convert.ToInt32(dataset.Tables[1].Rows[Items.SelectedRows[0].Index][2]) - 1;
                    //dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) + 1;
                }
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //messagebox yes no from https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            MessageBox.Show("Are You Sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Items Ordered", "Items Ordered", MessageBoxButtons.OK);
            }
        }

        // closing form
        private void AddAndUpdateItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainMenu.Visible == false)
            {
                mainMenu.Close();
            }
        }
        private void addToBasket()
        {
            DataRow row = dataset.Tables[1].NewRow();
            //name
            row[0] = Items.SelectedRows[0].Cells[0].Value.ToString();
            //price
            row[1] = Items.SelectedRows[0].Cells[2].Value.ToString();
            //quantity
            row[2] = 1;
            dataset.Tables[1].Rows.Add(row);
            //dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][4]) - 1;
        }
        //returns to main menu
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataset();
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                if (!Supplier.SelectedItem.Equals(dataset.Tables[0].Rows[i][3] + "-" + dataset.Tables[0].Rows[i][4]))
                {
                    dataset.Tables[0].Rows.RemoveAt(i--);
                }
            }
            total = Convert.ToDouble(dataset.Tables[0].Rows[0][5]);
            TotalLabel.Text = "total = " + total;
            GroupBox.Visible = true;
        }
        private void resetDataset()
        {
            this.dataset = new Sql().restockData();
            //creating basket table
            DataTable table = new DataTable("Basket");
            DataColumn column;

            //name
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Name";
            column.ReadOnly = true;
            table.Columns.Add(column);
            //price
            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "Cost";
            table.Columns.Add(column);
            //Quantity
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Quantity";
            table.Columns.Add(column);

            dataset.Tables.Add(table);

            Items.DataSource = dataset.Tables[0];
            Basket.DataSource = dataset.Tables[1];
        }
    }
}
