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
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "name";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Phone Number";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Email";
                column.ReadOnly = true;
                column.Unique = true;
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
            else if (this.Text.Contains("item"))
            {
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
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Phone Number";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Email";
                column.ReadOnly = true;
                column.Unique = true;
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
                //temporary code
                /*List<Item> items = new List<Item> {
                    new Item(1,"daffodil buds","Buds",1,1,5),
                    new Item(2,"Grass Seeds","Seeds",1,1,5),
                    new Item(3,"Wrench Set","Tools",1,2,5),
                    new Item(4,"Screwdriver Set","Tools",1,2,5),
                    new Item(5,"Red Gnome","Outdoor Furniture",1,3,5),
                    new Item(6,"Green Gnome","Outdoor Furniture",1,3,5)
                };*/
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
                    AddAndUpdate AddAndUpdate = new AddAndUpdate(row, this);
                    // update details
                    if (this.Text.Equals("Update Supplier Details"))
                    {
                        AddAndUpdate.Text = "Update Supplier Details";
                        AddAndUpdate.Show();
                    }
                    else if (this.Text.Equals("Update Item Details"))
                    {
                        AddAndUpdate.Show();
                    }
                    // remove function
                    else if (this.Text.Equals("Remove Supplier"))
                    {
                        AddAndUpdate.Show();
                    }
                    else if (this.Text.Equals("Remove Item"))
                    {
                        AddAndUpdate.Show();
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
