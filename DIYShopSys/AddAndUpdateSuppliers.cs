using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYShopSys
{
    public partial class AddAndUpdateSuppliers : Form
    {

        //used to return to the main menu
        MainMenu main;
        //used to return to update supplier
        ManageData ManageData;

        public AddAndUpdateSuppliers()
        {
            InitializeComponent();
        }
        public AddAndUpdateSuppliers(MainMenu main, String text)
        {
            this.Text = text;
            InitializeComponent();
        }
        public AddAndUpdateSuppliers(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            //input old values
            //figured out how to get row values from here https://stackoverflow.com/questions/6487839/reading-data-from-datagridview-in-c-sharp
            SupName.Text = Row.Cells[1].Value.ToString();
            PhoneNumber.Text = Row.Cells[2].Value.ToString();
            Email.Text = Row.Cells[3].Value.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Add Supplier"))
            {
                if (CheckSupplier())
                {
                    MessageBox.Show("You have Added a Supplier", "Added Supplier", MessageBoxButtons.OK);
                }
            }
            if (this.Text.Equals("Update Supplier Details"))
            {
                if (CheckSupplier())
                {
                    MessageBox.Show("You have Updated Supplier Details", "Updated Supplier", MessageBoxButtons.OK);
                }
            }
        }

        // validation
        private Boolean CheckSupplier()
        {
            Boolean IsItInt;
            IsItInt = int.TryParse(PhoneNumber.Text, out _);
            if (SupName.Text.Length > 20)
            {
                return false;
            }
            else if (SupName.Text.Length < 1)
            {
                return false;
            }
            else if (PhoneNumber.Text.Length > 10)
            {
                return false;
            }
            else if (PhoneNumber.Text.Length < 1)
            {
                return false;
            }
            else if (IsItInt == false)
            {
                return false;
            }
            else if (Email.Text.Length > 20)
            {
                return false;
            }
            else if (Email.Text.Length < 1)
            {
                return false;
            }
            else
            {
                //Code snipit From SD_RE_James_Clifford line 114-122
                String[] emails = new String[] { "@gmail.com", "@outlook.com", "@yahoo.com", "@hotmail.com" };
                for (int i = 0; i < emails.Length; i++)
                {
                    int cut = Email.Text.Length - emails[i].Length;
                    if (Email.Text.Substring(cut).Contains(emails[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
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
