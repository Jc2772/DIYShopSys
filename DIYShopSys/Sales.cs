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
{
    public partial class Sales : Form
    {
        MainMenu mainMenu;
        DataSet dataset;
        Double total;
        public Sales()
        {
            InitializeComponent();
            resetDataset();
            Items.Columns[0].Visible = false;
            Basket.Columns[0].Visible = false;
            /*used this to hide columns
             * https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/remove-autogenerated-columns-from-a-wf-datagridview-control?view=netframeworkdesktop-4.8
                */
        }
        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (Items.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(Items.SelectedRows[0].Cells[3].Value) == 0)
                {
                    MessageBox.Show("Maximum" + Items.SelectedRows[0].Cells[1].Value.ToString() + "Reached", "Error", MessageBoxButtons.OK);
                }
                else if (Basket.Rows.Count > 0)
                {
                    for (int i = 0; i < Basket.Rows.Count; i++)
                    {
                        //source for selectectedRows.index[2] second answer :https://stackoverflow.com/questions/3578144/index-of-currently-selected-row-in-datagridview
                        if (Basket.Rows[i].Cells[1].Value.ToString().Equals(Items.SelectedRows[0].Cells[1].Value.ToString()))
                        {
                            dataset.Tables[1].Rows[i][3] = Convert.ToInt32(dataset.Tables[1].Rows[i][3]) + 1;
                            dataset.Tables[1].Rows[i][4] = Convert.ToInt32(dataset.Tables[1].Rows[i][4]) + 1;
                            dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) - 1;
                            return;
                        }
                    }
                    addToBasket();
                }
                else
                {
                    addToBasket();
                }
                total += Convert.ToDouble(Items.SelectedRows[0].Cells[3].Value.ToString());
                TotalLabel.Text = "total = " + total;
            }
        }

        private void RemoveFromBasket_Click(object sender, EventArgs e)
        {
            if (Basket.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(dataset.Tables[1].Rows[Basket.SelectedRows[0].Index][2]) == 1)
                {
                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        MessageBox.Show(Basket.SelectedRows[0].Cells[1].Value.ToString());
                        MessageBox.Show(dataset.Tables[0].Rows[i][1].ToString());
                        if (dataset.Tables[0].Rows[i][1].ToString().Equals(Basket.SelectedRows[0].Cells[1].Value.ToString()))
                        {
                            //removes row in basket
                            dataset.Tables[1].Rows.RemoveAt(Basket.SelectedRows[0].Index);
                            dataset.Tables[0].Rows[i][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) + 1;
                        }
                    }
                }
                else
                {
                    dataset.Tables[1].Rows[0][3] = Convert.ToInt32(dataset.Tables[1].Rows[Basket.SelectedRows[0].Index][3]) - 1;
                    dataset.Tables[1].Rows[0][4] = Convert.ToInt32(dataset.Tables[1].Rows[Basket.SelectedRows[0].Index][4]) - 1;
                    dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) + 1;
                }
                total -= Convert.ToDouble(Basket.SelectedRows[0].Cells[2].Value);
                TotalLabel.Text = "total = " + total;
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //messagebox yes no from https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            MessageBox.Show("Are You Sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                new Sql().AddOrUpdate("");
                for(int i = 0; i < Basket.Rows.Count; i++)
                {
                    new Sql().AddOrUpdate("");
                }
                MessageBox.Show("Items Ordered", "Items Ordered", MessageBoxButtons.OK);
            }
        }
        private void addToBasket()
        {
                DataRow row = dataset.Tables[1].NewRow();
                //id
                row[0] = Items.SelectedRows[0].Cells[0].Value.ToString();
                //name
                row[1] = Items.SelectedRows[0].Cells[1].Value.ToString();
                //price
                row[2] = Items.SelectedRows[0].Cells[2].Value.ToString();
                //Total price
                row[3] = Items.SelectedRows[0].Cells[2].Value.ToString();
                //quantity
                row[4] = 1;
                dataset.Tables[1].Rows.Add(row);
                dataset.Tables[0].Rows[0][3] = Convert.ToInt32(dataset.Tables[0].Rows[Items.SelectedRows[0].Index][3]) - 1;
        }
        private void resetDataset()
        {
            //how to create a datatable https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-7.0
            this.dataset = new Sql().GetDataSet("select item_id, item_name, item_price, quantity from items where item_status = 'a' and quantity >= 1");
            //creating basket table
            DataTable table = new DataTable("Basket");
            DataColumn column;
            //id
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "item Id";
            table.Columns.Add(column);
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
            //total price
            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "Total Cost";
            table.Columns.Add(column);
            //Quantity
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Quantity";
            table.Columns.Add(column);

            dataset.Tables.Add(table);

            Items.DataSource = dataset.Tables[0];
            Basket.DataSource = dataset.Tables[1];
            total = 0;
        }
        //returns to main menu
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            new Login(this).Show();
        }
    }
}
