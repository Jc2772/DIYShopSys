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
        //used to return to the main menu
        MainMenu main;
        //used to return to update supplier
        ManageData ManageData;
        //dataset required for old values
        DataSet item;
        //Unused
        public AddAndUpdate()
        {
            InitializeComponent();
        }
        //Add Supplier
        public AddAndUpdate(MainMenu main)
        {
            this.main = main;
            main.Hide();
            InitializeComponent();
            LabelForInput1.Text = "Name";
            LabelForInput2.Text = "Phone number";
            LabelForInput3.Text = "Email";
            LabelForCombo.Hide();
            LabelForInput4.Hide();
            ComboBox.Hide();
            Input4.Hide();
        }
        //Update Supplier
        public AddAndUpdate(DataGridViewRow Row, ManageData update)
        {
            this.item = item;
            this.ManageData = update;
            update.Hide();
            InitializeComponent();
            LabelForInput1.Text = "Name";
            LabelForInput2.Text = "Phone number";
            LabelForInput3.Text = "Email";
            LabelForCombo.Hide();
            LabelForInput4.Hide();
            ComboBox.Hide();
            Input4.Hide();
            //input old values
            //https://stackoverflow.com/questions/6487839/reading-data-from-datagridview-in-c-sharp
            Input1.Text = Row.Cells[1].Value.ToString();
            Input2.Text = Row.Cells[2].Value.ToString();
            Input3.Text = Row.Cells[3].Value.ToString();
        }
        //submit button
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Checks for form text
            if (this.Text.Equals("Add Supplier"))
            {
                if (CheckSupplier())
                {
                    MessageBox.Show("You have Added a Supplier", "Added Supplier", MessageBoxButtons.OK);
                }
            }
            if (this.Text.Equals(""))
            {
                if (CheckSupplier())
                {
                    MessageBox.Show("You have Updated Supplier Details", "Updated Supplier", MessageBoxButtons.OK);
                }
            }
            if (this.Text.Equals(""))
            {
                if (CheckNewItem())
                {
                    MessageBox.Show("You have Added an Item", "Added Item", MessageBoxButtons.OK);
                }
            }
            if (this.Text.Equals(""))
            {
                if (CheckItemUpdate())
                {
                    MessageBox.Show("You have Updated Item Details", "Updated Item", MessageBoxButtons.OK);
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
        // validation
        private Boolean CheckSupplier()
        {
            return false;
        }
        private Boolean CheckNewItem()
        {
            return false;
        }
        private Boolean CheckItemUpdate()
        {
            return false;
        }
        // closing form
        private void AddAndUpdate_FormClosed(object sender, FormClosedEventArgs e)
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
                ManageData.Close();
            }
        }
    }
}
