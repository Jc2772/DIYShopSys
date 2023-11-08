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
    public partial class AddAndUpdate : Form
    {
        //main menu
        MainMenu main;
        //update supplier
        updateSupplier update;
        DataSet item;
        //update item

        public AddAndUpdate()
        {
            InitializeComponent();
        }
        public AddAndUpdate(MainMenu main, String forname)
        {
            this.main = main;
            main.Hide();
            InitializeComponent();
        }
        public AddAndUpdate(DataSet item, updateSupplier update, string forname)
        {
            this.item = item;
            this.update = update;
            update.Hide();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.item != null)
            {

            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.item != null)
            {
                update.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }
    }
}
