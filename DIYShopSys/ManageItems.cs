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
    public partial class ManageItems : Form
    {
        //used to return to the main menu
        MainMenu main;
        //used to return to update supplier
        ManageData ManageData;
        Sql sql = new Sql();

        String[] ArrTypeId, ArrSupplierId;
        String SupplierId, TypeId, ItemId;
        //Unused
        public ManageItems()
        {
            InitializeComponent();
        }
        //Add Supplier
        public ManageItems(MainMenu main, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.main = main;
            main.Hide();
            setup();
        }
        //Update Supplier
        public ManageItems(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.ManageData = update;
            update.Hide();
            LabelForQuantity.Hide();
            Quantity.Hide();
            this.ManageData.Hide();
            setup();
            //input old values
            //https://stackoverflow.com/questions/6487839/reading-data-from-datagridview-in-c-sharp
            ItemName.Text = Row.Cells[1].Value.ToString();
            Price.Text = String.Format("{0:.00}",Convert.ToDouble(Row.Cells[2].Value.ToString()));
            Cost.Text = String.Format("{0:.00}", Convert.ToDouble(Row.Cells[3].Value.ToString()));
            Quantity.Text = Row.Cells[4].Value.ToString();
            for (int i = 0; i < Supplier.Items.Count; i++)
            {
                if (Supplier.Items[i].Equals(Row.Cells[5].Value.ToString() + "-" + Row.Cells[6].Value.ToString()))
                {
                    Supplier.SelectedIndex = i;
                }
            }
            for (int i = 0; i < Type.Items.Count; i++)
            {
                if (Type.Items[i].Equals(Row.Cells[8].Value.ToString() + "-" + Row.Cells[7].Value.ToString()))
                {
                    Type.SelectedIndex = i;
                }
            }
        }
        //setup
        public void setup()
        {
            DataSet dataset = sql.GetDataSet("select supplier_id, supplier_name from suppliers where supplier_status = 'a'");
            this.ArrSupplierId = new string[dataset.Tables[0].Rows.Count];
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                ArrSupplierId[i] = dataset.Tables[0].Rows[i][0].ToString();
                Supplier.Items.Add(dataset.Tables[0].Rows[i][0] + "-" + dataset.Tables[0].Rows[i][1]);
            }
            dataset = sql.GetDataSet("select type_id, type_name from item_types where type_status = 'a'");
            this.ArrTypeId = new string[dataset.Tables[0].Rows.Count];
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                ArrTypeId[i] = dataset.Tables[0].Rows[i][0].ToString();
                Type.Items.Add(dataset.Tables[0].Rows[i][0] + "-" + dataset.Tables[0].Rows[i][1]);
            }
        }
        //submit button
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Checks for form text
            if (CheckItem())
            {
                if (this.main != null)
                {
                    if (checkQuantity())
                    {
                        new Sql().AddOrUpdate("Insert Into Items (Item_Id,Item_Name,Item_Price,Item_Cost,Quantity,Supplier_Id,Type_Id,Item_Status) Values (" + new Sql().GetNextStockId() + ",'" + ItemName.Text + "'," + Price.Text + "," + Cost.Text + ","+ Quantity.Text + "," + this.SupplierId + "," + this.TypeId + ")");
                        MessageBox.Show("You have Added an Item", "Added Item", MessageBoxButtons.OK);
                        ItemName.Text = "";
                        Price.Text = "";
                        Cost.Text = "";
                        Supplier.SelectedIndex = -1;
                        Type.SelectedIndex = -1;
                        Quantity.Text = "";
                    }
                }
                else
                {
                    new Sql().AddOrUpdate("Update Items set Item_Name = '" + ItemName.Text + "',Item_Price = " + Price.Text + ",Item_Cost =" + Cost.Text + ",Supplier_Id = " + this.SupplierId + ",Type_Id = " + this.TypeId + "Where Item_Id = " + this.ItemId);
                    MessageBox.Show("You have Updated Item Details", "Updated Item", MessageBoxButtons.OK);
                    ManageData.Show();
                    this.Close();
                }
            }
        }
        private Boolean CheckItem()
        {
            // tryparse = https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
            Boolean IsPriceDouble, IsCostDouble;
            IsPriceDouble = double.TryParse(Price.Text, out _);
            IsCostDouble = double.TryParse(Price.Text, out _);
            //validate name
            if (ItemName.Text.Length > 20 || ItemName.Text.Length < 1)
            {
                MessageBox.Show("Invalid Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //validate price
            else if (Price.Text.Length > 8 || Price.Text.Length < 4)
            {
                MessageBox.Show("Invalid Price, Price is not 1-8 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Price.Text[Price.Text.Length - 3] != '.')
            {
                MessageBox.Show("Invalid Price has no decimal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsPriceDouble == false)
            {
                MessageBox.Show("Invalid Price Is Not Double", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //validate cost
            else if (Price.Text.Length > 8 || Price.Text.Length < 4)
            {
                MessageBox.Show("Invalid Cost, Cost is not 1-8 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Price.Text[Price.Text.Length - 3] != '.')
            {
                MessageBox.Show("Invalid Cost, Cost Does Not have A decimal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsCostDouble == false)
            {
                MessageBox.Show("Invalid Cost, Cost is Not Double", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Supplier.SelectedIndex > -1)
            {
                MessageBox.Show("Supplier is not Picked", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Type.SelectedIndex > -1)
            {
                MessageBox.Show("Type is not Picked", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private Boolean checkQuantity()
        {
            Boolean IsQuantityInt;
            //validate quantity if add
            //parse int - https://code-maze.com/csharp-identify-if-a-string-is-a-number/
            IsQuantityInt = int.TryParse(Quantity.Text, out _);
            if (IsQuantityInt == false)
            {
                MessageBox.Show("Invalid Quantity, Quantity is not Int", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Quantity.Text.Length > 3 && Quantity.Text.Length < 1)
            {
                MessageBox.Show("Invalid Quantity, Quantity is not 1-3 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
            if (main != null)
            {
                main.Show();
                this.Close();
            }
            else
            {
                ManageData.Show();
                this.Close();
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ArrTypeId.Length; i++)
            {
                if (Type.Text.Contains(ArrTypeId[i]))
                {
                    TypeId = ArrTypeId[i];
                }
            }
        }

        private void Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < ArrSupplierId.Length; i++)
            {
                if (Supplier.Text.Contains(ArrSupplierId[i]))
                {
                    SupplierId = ArrSupplierId[i];
                }
            }
        }
    }
}
