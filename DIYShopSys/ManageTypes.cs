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
        String id;
        public ManageTypes()
        {
            InitializeComponent();
        }
        public ManageTypes(MainMenu main, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.main = main;
            main.Hide();
        }
        public ManageTypes(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.ManageData = update;
            this.ManageData.Hide();
            TypeName.Text = Row.Cells[1].Value.ToString();
            this.id = Row.Cells[0].Value.ToString();
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
            if(TypeName.Text.Length < 1 || TypeName.Text.Length > 20)
            {
                MessageBox.Show("Name Is Not Valid","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (this.main != null) {

                    new Sql().AddOrUpdate("Insert Into Item_Types (Type_Id,Type_Name) Values ("+ new Sql().GetNextTypeId() + ",'" + TypeName.Text + "')");
                    MessageBox.Show("Added Type");
                    TypeName.Text = "";
                }
                else
                {
                    new Sql().AddOrUpdate("Update Item_Types Set Type_Name = '" + TypeName.Text +"' Where Type_Id = " + id);
                    MessageBox.Show("Updating Type Name");
                    ManageData.Show();
                    this.Close();
                }
            }
        }
    }
}
