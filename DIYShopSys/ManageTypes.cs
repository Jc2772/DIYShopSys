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
    public partial class ManageTypes : Form
    {
        MainMenu main;
        ManageData ManageData;
        DataGridViewRow Row;
        public ManageTypes()
        {
            InitializeComponent();
        }
        public ManageTypes(MainMenu main, String text)
        {
            InitializeComponent();
            this.Text = Text;
            this.main = main;
            main.Hide();
        }
        public ManageTypes(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.ManageData = update;
            this.Row = Row;
            this.ManageData.Hide();
            TypeName.Text = Row.Cells[0].Value.ToString();
        }
        // closing form
        private void ManageItems_FormClosed(object sender, FormClosedEventArgs e)
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(TypeName.Text.Length >= 1 && TypeName.Text.Length <= 20)
            {
                MessageBox.Show("Name Is Not Valid","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (this.Text.Equals("Update Type")) {

                    MessageBox.Show("Updating Type");
                    ManageData.Show();
                    this.Close();
                }
                else{
                    MessageBox.Show("Adding Type");
                }
            }
        }
    }
}
