using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            setup();
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
            setup();
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
            for (int i = 0;i < Type.Items.Count; i++)
            {
                if (Type.Items[i].Equals(Row.Cells[6].Value.ToString() + "-" + Row.Cells[5].Value.ToString()))
                {
                    Type.SelectedIndex = i;
                }
            }
        }
        //setup
        public void setup()
        {
            Supplier.Items.Add("1 - Heavenly Plants");
            Supplier.Items.Add("2 - Tims Tools");
            Supplier.Items.Add("2 - ShortGnomes");
            Type.Items.Add("1 - Bulbs");
            Type.Items.Add("2 - Tools");
            Type.Items.Add("3 - Outdoor Furniture");
            Type.Items.Add("4 - Seeds");
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
            Boolean IsPriceDouble,IsCostDouble ,IsQuantityInt;
            IsPriceDouble = double.TryParse(Price.Text, out _);
            IsCostDouble = double.TryParse(Price.Text, out _);
            //validate name
            if (ItemName.Text.Length > 20)
            {
                return false;
            }
            else if (ItemName.Text.Length < 1)
            {
                return false;
            }
            //validate price
            else if (Price.Text.Length > 8)
            {
                return false;
            }
            else if (Price.Text.Length < 1)
            {
                return false;
            }
            else if (Price.Text[Price.Text.Length - 3] != '.')
            {
                return false;
            }
            else if (IsPriceDouble == false)
            {
                return false;
            }
            //validate cost
            else if (Cost.Text.Length > 8)
            {
                return false;
            }
            else if (Price.Text.Length < 1)
            {
                return false;
            }
            else if (Price.Text[Price.Text.Length - 3] != '.')
            {
                return false;
            }
            else if (IsCostDouble == false)
            {
                return false;
            }
            //validate quantity if add
            else if (this.Text.Equals("Add Item"))
            {
                //parse int - https://code-maze.com/csharp-identify-if-a-string-is-a-number/
                IsQuantityInt = int.TryParse(Quantity.Text, out _);
                if (IsQuantityInt == false)
                {
                    return false;
                }
                else if (Quantity.Text.Length > 3)
                {
                    return false;
                }
                else if (Quantity.Text.Length < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
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
            if (this.Text.Equals("Update Item Details"))
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
