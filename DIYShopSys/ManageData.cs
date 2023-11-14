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
    public partial class ManageData : Form
    {
        MainMenu main;
        public ManageData()
        {
            InitializeComponent();
        }
        public ManageData(MainMenu main, String Text)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            this.Text = Text;
            //populate dataset
            if (this.Text.Contains("Supplier"))
            {
                //temporary code
                DataTable table = new DataTable("Supplier");
                DataColumn column;
                DataRow row;

                column = new DataColumn();
                column.DataType = typeof(int);
                column.ColumnName = "id";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "name";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Phone Number";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Email";
                column.ReadOnly = true;
                table.Columns.Add(column);

                DataColumn[] PrimaryKeyColumns = new DataColumn[1];
                PrimaryKeyColumns[0] = table.Columns[0];
                table.PrimaryKey = PrimaryKeyColumns;

                row = table.NewRow();
                row[0] = 1;
                row[1] = "Heavenly Plants";
                row[2] = "087 954 3423";
                row[3] = "HeavenlyPlantsRep@outlook.com";
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 2;
                row[1] = "Tims Toolset";
                row[2] = "087 546 3821";
                row[3] = "TimToolsRep@gmail";
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 3;
                row[1] = "ShortGnomes";
                row[2] = "087 179 4392";
                row[3] = "ShortGnomes@outlook.com";
                table.Rows.Add(row);

                DataSet dataset = new DataSet();
                dataset.Tables.Add(table);


                Grid.DataSource = dataset.Tables[0];
            }
            else if (this.Text.Contains("Item"))
            {
                //temporary code
                DataTable table = new DataTable("Supplier");
                DataColumn column;
                DataRow row;

                column = new DataColumn();
                column.DataType = typeof(int);
                column.ColumnName = "id";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "name";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Type";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(double);
                column.ColumnName = "Price";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Supplier name";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(int);
                column.ColumnName = "Supplier Id";
                column.ReadOnly = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(int);
                column.ColumnName = "Quantity";
                column.ReadOnly = true;
                table.Columns.Add(column);

                DataColumn[] PrimaryKeyColumns = new DataColumn[1];
                PrimaryKeyColumns[0] = table.Columns[0];
                table.PrimaryKey = PrimaryKeyColumns;

                row = table.NewRow();
                row[0] = 1;
                row[1] = "Daffodil Bulbs";
                row[2] = "Bulbs";
                row[3] = 1;
                row[4] = "Heavenly Plants";
                row[5] = 1;
                row[6] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 2;
                row[1] = "Sledge Hammer";
                row[2] = "Too1";
                row[3] = 1;
                row[4] = "Tims Toolset";
                row[5] = 2;
                row[6] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 3;
                row[1] = "Green Gnome";
                row[2] = "Outdoor Furniture";
                row[3] = 1;
                row[4] = "ShortGnomes";
                row[5] = 3;
                row[6] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 4;
                row[1] = "Grass Seeds";
                row[2] = "Seeds";
                row[3] = 1;
                row[4] = "Heavenly Plants";
                row[5] = 1;
                row[6] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 5;
                row[1] = "Wrench Set";
                row[2] = "Tools";
                row[3] = 1;
                row[4] = "Tims Toolset";
                row[5] = 2;
                row[6] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 6;
                row[1] = "Green Gnome";
                row[2] = "Outdoor Furniture";
                row[3] = 1;
                row[4] = "ShortGnomes";
                row[5] = 3;
                row[6] = 5;
                table.Rows.Add(row);

                DataSet dataset = new DataSet();
                dataset.Tables.Add(table);


                Grid.DataSource = dataset.Tables[0];
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            /*https://stackoverflow.com/questions/56009158/how-to-check-if-a-cell-in-selected-row-in-datagridview-is-empty-null-using-c
            came up with grid Selceted rows while looking at site
             */

            // checks if row is selected
            if (Grid.SelectedRows.Count == 1)
            {
                DataGridViewRow row = Grid.SelectedRows[0];
                /*used this to learn how to change form name in c#
                 * first answer on page
                 * https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
                 */

                if (this.Text.Equals("Restock item"))
                {
                    MessageBox.Show("You have Added Stock", "Added Stock", MessageBoxButtons.OK);
                }
                else
                {
                    // update details
                    if (this.Text.Equals("Update Supplier Details"))
                    {

                        String Text = "Update Supplier Details";
                        AddAndUpdate AddAndUpdate = new AddAndUpdate(row, this,Text);
                        AddAndUpdate.Show();
                    }
                    else if (this.Text.Equals("Update Item Details"))
                    {
                        String Text = "Update Item Details";
                        AddAndUpdate AddAndUpdate = new AddAndUpdate(row, this, Text);
                        AddAndUpdate.Show();
                    }
                    // remove function
                    else if (this.Text.Equals("Remove Supplier"))
                    {
                        
                    }
                    else if (this.Text.Equals("Remove Item"))
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Form Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Row Not Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // return
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
        // stop program
        private void ManageData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                main.Close();
            }
        }
    }
}
