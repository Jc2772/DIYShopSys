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
            column.ReadOnly = true;
            table.Columns.Add(column);
            //Quantity
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Quantity";
            column.ReadOnly = true;
            table.Columns.Add(column);
            dataset.Tables.Add(table);
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            DataRow row;

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
