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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string formname = "update item";
            AddAndUpdate AddAndUpdate = new AddAndUpdate(dataSet,this,formname);
            AddAndUpdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
    }
}
