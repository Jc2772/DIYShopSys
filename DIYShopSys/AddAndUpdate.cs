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
        updateSupplier updateSupplier;
        //dataset required for old values
        DataSet item;

        public AddAndUpdate()
        {
            InitializeComponent();
        }
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
        public AddAndUpdate(DataGridViewRow Row, updateSupplier update)
        {
            this.item = item;
            this.updateSupplier = update;
            update.Hide();
            InitializeComponent();
            LabelForInput1.Text = "Name";
            LabelForInput2.Text = "Phone number";
            LabelForInput3.Text = "Email";
            LabelForCombo.Hide();
            LabelForInput4.Hide();
            ComboBox.Hide();
            Input4.Hide();
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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (this.updateSupplier != null)
            {
                updateSupplier.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }
        }
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

        private void AddAndUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main != null)
            {
                if (main.Visible == false)
                {
                    main.Close();
                }
            }
        }
    }
}
