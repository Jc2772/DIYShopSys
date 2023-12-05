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
            InitializeComponent();
            this.main = main;
            this.Text = text;
        }
        public AddAndUpdateSuppliers(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.ManageData = update;
            this.ManageData.Hide();
            //input old values
            //figured out how to get row values from here https://stackoverflow.com/questions/6487839/reading-data-from-datagridview-in-c-sharp
            SupName.Text = Row.Cells[1].Value.ToString();
            PhoneNumber.Text = Row.Cells[2].Value.ToString();
            Email.Text = Row.Cells[3].Value.ToString();
            DeliveryFee.Text = Row.Cells[4].Value.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (CheckSupplier()) {
                MessageBox.Show(this.Text);
                if (this.Text.Equals("Add Supplier"))
                {
                    MessageBox.Show("You have Added a Supplier", "Added Supplier", MessageBoxButtons.OK);
                }
                else if (this.Text.Equals("Update Supplier Details"))
                {
                    MessageBox.Show("You have Updated Supplier Details", "Updated Supplier", MessageBoxButtons.OK);
                }
            }
        }

        // validation
        private Boolean CheckSupplier()
        {
            Boolean IsItInt,IsItDouble;
            IsItInt = int.TryParse(PhoneNumber.Text, out _);
            IsItDouble = int.TryParse(DeliveryFee.Text, out _);
            if (SupName.Text.Length > 20)
            {
                MessageBox.Show("Error1");
                return false;
            }
            else if (SupName.Text.Length < 1)
            {
                MessageBox.Show("Error2");
                return false;
            }
            else if (PhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Error3");
                return false;
            }
            else if (PhoneNumber.Text.Length < 1)
            {
                MessageBox.Show("Error4");
                return false;
            }
            else if (IsItInt == false)
            {
                MessageBox.Show("Error5");
                return false;
            }
            else if (IsItDouble == false)
            {
                MessageBox.Show("Error6");
                return false;
            }
            else if (Email.Text.Length > 30)
            {
                MessageBox.Show("Error7");
                return false;
            }
            else if (Email.Text.Length < 1)
            {
                MessageBox.Show("Error8");
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
                MessageBox.Show("Error9");
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
            if (this.Text.Equals("Update Supplier Details"))
            {
                this.ManageData.Show();
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
