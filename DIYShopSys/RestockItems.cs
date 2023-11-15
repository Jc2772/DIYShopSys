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
    public partial class RestockItems : Form
    {
        MainMenu mainMenu;
        public RestockItems()
        {
            InitializeComponent();
        }
        public RestockItems(MainMenu main)
        {
            InitializeComponent();
            this.mainMenu = main;
            DataSet dataset = new Sql().PullData(this.Text);
            Items.DataSource = dataset.Tables[0];
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {

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
