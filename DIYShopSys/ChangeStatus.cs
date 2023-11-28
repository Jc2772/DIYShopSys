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
    public partial class ChangeStatus : Form
    {
        MainMenu main;
        public ChangeStatus()
        {
            InitializeComponent();
        }
        public ChangeStatus(MainMenu main)
        {
            InitializeComponent();
            this.main = main;
        }
        // return
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
        // stop program
        private void ChangeStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                main.Close();
            }
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            //add check for form.text when using sql

        }

        private void Deativate_Click(object sender, EventArgs e)
        {
            //add check for form.text when using sql
        }
    }
}
