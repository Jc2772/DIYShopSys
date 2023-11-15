using System;
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
            DataTable table = new DataTable("Supplier");
            //creating basket table
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
            dataset.Tables.Add(table);
            Items.DataSource = dataset.Tables[0];
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (Items.SelectedRows.Count == 1)
            {
            if(Basket.Rows.Count > 0)
                {
                    if (Basket.Rows[0].Cells[0].Value.ToString().Equals("Daffodil Bulbs"))
                    {
                        dataset.Tables[1].Rows[0][2] = Convert.ToInt32(dataset.Tables[1].Rows[0][2]) + 1;
                    }
                }
            else {
                    DataRow row = dataset.Tables[1].NewRow();
                    //name
                    row[0] = "Daffodil Bulbs";
                    //price
                    row[1] = 1;
                    //quantity
                    row[2] = 5;
                    dataset.Tables[1].Rows.Add(row);
                    Basket.DataSource = dataset.Tables[1];
                }
            }
        }

        private void RemoveItemFromBasket_Click(object sender, EventArgs e)
        {

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
