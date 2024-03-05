﻿using System;
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
    public partial class ManageSuppliers : Form
    {

        //used to return to the main menu
        MainMenu main;
        //used to return to update supplier
        ManageData ManageData;

        public ManageSuppliers()
        {
            InitializeComponent();
        }
        public ManageSuppliers(MainMenu main, String text)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            this.Text = text;
        }
        public ManageSuppliers(DataGridViewRow Row, ManageData update, String text)
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
            if (CheckSupplier())
            {
                if (this.Text.Equals("Add Supplier"))
                {
                    MessageBox.Show("You have Added a Supplier", "Added Supplier", MessageBoxButtons.OK);
                }
                else if (this.Text.Equals("Update Supplier Details"))
                {
                    MessageBox.Show("You have Updated Supplier Details", "Updated Supplier", MessageBoxButtons.OK);
                    ManageData.Show();
                    this.Close();
                }
            }
        }

        // validation
        private Boolean CheckSupplier()
        {
            Boolean IsItInt, IsItDouble;
            IsItInt = int.TryParse(PhoneNumber.Text, out _);
            IsItDouble = int.TryParse(DeliveryFee.Text, out _);
            if (SupName.Text.Length > 20 && SupName.Text.Length < 1)
            {
                MessageBox.Show("Invalid Name, Name Must Be 1-8 Characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (PhoneNumber.Text.Length != 10)
            {
                MessageBox.Show(PhoneNumber.Text.Length.ToString());
                MessageBox.Show("Invalid Phone Number, Phone Number Must be 10 Characters Long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (IsItInt == false)
            {
                MessageBox.Show("Invalid Phone Number, Phone Number Must Convert To Int", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (DeliveryFee.Text.Length > 7 || DeliveryFee.Text.Length < 4)
            {
                MessageBox.Show("Invalid Delivery Fee, Delivery Fee must be 4-7 characters long and must have 2 fractional digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (DeliveryFee.Text[DeliveryFee.Text.Length - 3] != '.')
            {
                MessageBox.Show("Invalid Delivery Fee, Delivery must have 2 fractional digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (IsItDouble)
            {
                MessageBox.Show("Invalid Delivery Fee, Delivery Fee is not Double", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Email.Text.Length > 30 || Email.Text.Length < 1)
            {
                MessageBox.Show("Invalid Email, Email Must be 1-30 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
