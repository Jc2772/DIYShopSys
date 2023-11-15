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
        public RestockItems()
        {
            InitializeComponent();
        }
        public RestockItems(MainMenu main)
        {
            InitializeComponent();
            this.mainMenu = main;
            this.dataset = new Sql().PullData(this.Text);
            Items.DataSource = dataset.Tables[0];
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
            column.ColumnName = "Price";
            table.Columns.Add(column);
            //Quantity
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Quantity";
            table.Columns.Add(column);
            //id
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Id";
            table.Columns.Add(column);

            dataset.Tables.Add(table);
            Items.DataSource = dataset.Tables[0];
            Basket.DataSource = dataset.Tables[1];
            /*used this to hide columns
             * https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/remove-autogenerated-columns-from-a-wf-datagridview-control?view=netframeworkdesktop-4.8
                */
            Items.Columns[4].Visible = false;
            Basket.Columns[3].Visible = false;
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (Items.SelectedRows.Count == 1)
            {
                if (Basket.Rows.Count > 0)
                {
                    if (Basket.Rows[0].Cells[0].Value.ToString().Equals(Items.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        dataset.Tables[1].Rows[0][2] = Convert.ToInt32(dataset.Tables[1].Rows[Items.SelectedRows[0].Index][2]) + 1;
                        dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) - 1;
                    }
                    else
                    {
                        DataRow row = dataset.Tables[1].NewRow();
                        //name
                        row[0] = Items.SelectedRows[0].Cells[0].Value.ToString();
                        //price
                        row[1] = Items.SelectedRows[0].Cells[2].Value.ToString();
                        //quantity
                        row[2] = 1;
                        //id
                        row[3] = Items.SelectedRows[0].Cells[4].Value.ToString();
                        dataset.Tables[1].Rows.Add(row);
                        dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) - 1;
                    }
                }
                else
                {
                    DataRow row = dataset.Tables[1].NewRow();
                    //name
                    row[0] = Items.SelectedRows[0].Cells[0].Value.ToString();
                    //price
                    row[1] = Items.SelectedRows[0].Cells[2].Value.ToString();
                    //quantity
                    row[2] = 1;
                    //id
                    row[3] = Items.SelectedRows[0].Cells[4].Value.ToString();
                    dataset.Tables[1].Rows.Add(row);
                    dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) - 1;

                }
            }
        }

        private void RemoveItemFromBasket_Click(object sender, EventArgs e)
        {
            if (Basket.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(dataset.Tables[1].Rows[Basket.SelectedRows[0].Index][2]) == 1)
                {
                    dataset.Tables[1].Rows.RemoveAt(Basket.SelectedRows[0].Index);
                }
                else
                {

                    dataset.Tables[1].Rows[0][2] = Convert.ToInt32(dataset.Tables[1].Rows[Items.SelectedRows[0].Index][2]) - 1;
                    dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) + 1;
                }
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

        }

        // closing form
        private void AddAndUpdateItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainMenu.Visible == false)
            {
                mainMenu.Close();
            }
        }
        //returns to main menu
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
