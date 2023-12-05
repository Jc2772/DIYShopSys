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
    public partial class AddAndUpdateTypes : Form
    {
        MainMenu main;
        ManageData ManageData;
        DataGridViewRow Row;
        public AddAndUpdateTypes()
        {
            InitializeComponent();
        }
        public AddAndUpdateTypes(MainMenu main, String text)
        {
            InitializeComponent();
            this.Text = Text;
            this.main = main;
        }
        public AddAndUpdateTypes(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.ManageData = update;
            this.Row = Row;
            this.ManageData.Hide();
            TypeName.Text = Row.Cells[1].Value.ToString();
        }
        // closing form
        private void AddAndUpdateItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main != null)
            {
                if (main.Visible == false)
                {
                    main.Close();
                }
            }
            else
            {
                if (ManageData.Visible == false)
                {
                    ManageData.Close();
                }
            }
        }
        //returns to main menu
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (this.ManageData != null)
            {
                ManageData.Show();
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
