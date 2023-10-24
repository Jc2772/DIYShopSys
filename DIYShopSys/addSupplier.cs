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
    public partial class addSupplier : Form
    {
        MainMenu main;
        updateSupplier update;
        String item;
        public addSupplier()
        {
            InitializeComponent();
        }
        public addSupplier(MainMenu main)
        {
            this.main = main;
            main.Hide();
            InitializeComponent();
        }
        public addSupplier(String item,updateSupplier update)
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
            if(this.item != null) {
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
