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
    public partial class AddAndUpdateItems : Form
    {
        //used to return to the main menu
        MainMenu main;
        //used to return to update supplier
        ManageData ManageData;
        //Unused
        public AddAndUpdateItems()
        {
            InitializeComponent();
        }
        //Add Supplier
        public AddAndUpdateItems(MainMenu main, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.main = main;
            main.Hide();
        }
        //Update Supplier
        public AddAndUpdateItems(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.ManageData = update;
            update.Hide();
            LabelForQuantity.Hide();
            Quantity.Hide();
            //input old values
            //https://stackoverflow.com/questions/6487839/reading-data-from-datagridview-in-c-sharp
            ItemName.Text = Row.Cells[1].Value.ToString();
            Type.Text = Row.Cells[2].Value.ToString();
            Price.Text = Row.Cells[3].Value.ToString();
                Quantity.Text = Row.Cells[4].Value.ToString();
            for (int i = 0; i < Supplier.Items.Count; i++)
            {
                if (Supplier.Items[i].Equals(Row.Cells[5].Value.ToString() + "-" + Row.Cells[4].Value.ToString()))
                {
                    Supplier.SelectedIndex = i;
                }
            }
        }
        //submit button
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Checks for form text
            if (this.Text.Equals("Add Item"))
            {
                if (CheckItem())
                {
                    MessageBox.Show("You have Added an Item", "Added Item", MessageBoxButtons.OK);
                }
            }
            if (this.Text.Equals("Update Item Details"))
            {
                if (CheckItem())
                {
                    MessageBox.Show("You have Updated Item Details", "Updated Item", MessageBoxButtons.OK);
                }
            }
        }
        private Boolean CheckItem()
        {
            if (this.Text.Equals("Update Item Details"))
            {
                return false;
            }
            return false;
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
