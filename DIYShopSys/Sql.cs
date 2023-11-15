using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYShopSys
{
    internal class Sql
    {
        //how to create a datatable https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-7.0
        public DataSet PullData(String text) {
            DataSet dataset = new DataSet();
            if (text.Contains("Supplier")) {
                DataTable table = new DataTable("Supplier");
                DataColumn column;
                DataRow row;

                column = new DataColumn();
                column.DataType = typeof(int);
                column.ColumnName = "id";
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "name";
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Phone Number";
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Email";
                table.Columns.Add(column);

                row = table.NewRow();
                //supplier id
                row[0] = 1;
                //Supplier name
                row[1] = "Heavenly Plants";
                //phone number
                row[2] = "087 954 3423";
                //email
                row[3] = "HeavenlyPlantsRep@outlook.com";
                table.Rows.Add(row);

                row = table.NewRow();
                //supplier id
                row[0] = 2;
                //Supplier name
                row[1] = "Tims Tools";
                //phone number
                row[2] = "087 546 3821";
                //email
                row[3] = "TimToolsRep@gmail";
                table.Rows.Add(row);

                row = table.NewRow();
                //supplier id
                row[0] = 3;
                //Supplier name
                row[1] = "ShortGnomes";
                //phone number
                row[2] = "087 179 4392";
                //email
                row[3] = "ShortGnomes@outlook.com";
                table.Rows.Add(row);
                dataset.Tables.Add(table);
            }
            else if (text.Contains("Item"))
            {
                if (text.Equals("Restock Items"))
                {
                    DataTable table = new DataTable("Item");
                    DataColumn column;
                    DataRow row;
                    //name column
                    column = new DataColumn();
                    column.DataType = typeof(string);
                    column.ColumnName = "name";
                    table.Columns.Add(column);

                    //type column
                    column = new DataColumn();
                    column.DataType = typeof(string);
                    column.ColumnName = "Type";
                    table.Columns.Add(column);

                    //Price column
                    column = new DataColumn();
                    column.DataType = typeof(double);
                    column.ColumnName = "Price";
                    table.Columns.Add(column);

                    //quantity column
                    column = new DataColumn();
                    column.DataType = typeof(int);
                    column.ColumnName = "Quantity";
                    table.Columns.Add(column);
                    //id column
                    column = new DataColumn();
                    column.DataType = typeof(int);
                    column.ColumnName = "Id";
                    table.Columns.Add(column);

                    row = table.NewRow();

                    //name
                    row[0] = "Daffodil Bulbs";
                    //type
                    row[1] = "Bulbs";
                    //price
                    row[2] = 1;
                    //quantity
                    row[3] = 5;
                    row[4] = 1;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //name
                    row[0] = "Sledge Hammer";
                    //type
                    row[1] = "Tools";
                    //price
                    row[2] = 1;
                    //quantity
                    row[3] = 5;
                    row[4] = 2;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //name
                    row[0] = "Green Gnome";
                    //type
                    row[1] = "Outdoor Furniture";
                    //price
                    row[2] = 1;
                    //quantity
                    row[3] = 5;
                    //id
                    row[4] = 3;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //name
                    row[0] = "Grass Seeds";
                    //type
                    row[1] = "Seeds";
                    //price
                    row[2] = 1;
                    //quantity
                    row[3] = 5;
                    //id
                    row[4] = 4;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //name
                    row[0] = "Wrench Set";
                    //type
                    row[1] = "Tools";
                    //price
                    row[2] = 1;
                    //quantity
                    row[3] = 5;
                    //id
                    row[4] = 5;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //name
                    row[0] = "Green Gnome";
                    //price
                    row[1] = "Outdoor Furniture";
                    //type
                    row[2] = 1;
                    //quantity
                    row[3] = 5;
                    //id
                    row[4] = 6;
                    table.Rows.Add(row);
                    dataset.Tables.Add(table);
                }
                else
                {
                    DataTable table = new DataTable("Item");
                    DataColumn column;
                    DataRow row;

                    column = new DataColumn();
                    column.DataType = typeof(int);
                    column.ColumnName = "id";
                    table.Columns.Add(column);

                    column = new DataColumn();
                    column.DataType = typeof(string);
                    column.ColumnName = "name";
                    table.Columns.Add(column);

                    column = new DataColumn();
                    column.DataType = typeof(string);
                    column.ColumnName = "Type";
                    table.Columns.Add(column);

                    column = new DataColumn();
                    column.DataType = typeof(double);
                    column.ColumnName = "Price";
                    table.Columns.Add(column);

                    column = new DataColumn();
                    column.DataType = typeof(string);
                    column.ColumnName = "Supplier name";
                    table.Columns.Add(column);

                    column = new DataColumn();
                    column.DataType = typeof(int);
                    column.ColumnName = "Supplier Id";
                    table.Columns.Add(column);

                    column = new DataColumn();
                    column.DataType = typeof(int);
                    column.ColumnName = "Quantity";
                    table.Columns.Add(column);

                    row = table.NewRow();
                    //id
                    row[0] = 1;
                    //name
                    row[1] = "Daffodil Bulbs";
                    //type
                    row[2] = "Bulbs";
                    //price
                    row[3] = 1;
                    //supplier name
                    row[4] = "Heavenly Plants";
                    //supplier id
                    row[5] = 1;
                    //quantity
                    row[6] = 5;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //id
                    row[0] = 2;
                    //name
                    row[1] = "Sledge Hammer";
                    //type
                    row[2] = "Tools";
                    //price
                    row[3] = 1;
                    //supplier name
                    row[4] = "Tims Tools";
                    //supplier id
                    row[5] = 2;
                    //quantity
                    row[6] = 5;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //id
                    row[0] = 3;
                    //name
                    row[1] = "Green Gnome";
                    //type
                    row[2] = "Outdoor Furniture";
                    //price
                    row[3] = 1;
                    //supplier name
                    row[4] = "ShortGnomes";
                    //supplier id
                    row[5] = 3;
                    //quantity
                    row[6] = 5;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //id
                    row[0] = 4;
                    //name
                    row[1] = "Grass Seeds";
                    //type
                    row[2] = "Seeds";
                    //price
                    row[3] = 1;
                    //supplier name
                    row[4] = "Heavenly Plants";
                    //supplier id
                    row[5] = 1;
                    //quantity
                    row[6] = 5;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //id
                    row[0] = 5;
                    //name
                    row[1] = "Wrench Set";
                    //type
                    row[2] = "Tools";
                    //price
                    row[3] = 1;
                    //supplier name
                    row[4] = "Tims Tools";
                    //supplier id
                    row[5] = 2;
                    //quantity
                    row[6] = 5;
                    table.Rows.Add(row);

                    row = table.NewRow();
                    //id
                    row[0] = 6;
                    //name
                    row[1] = "Green Gnome";
                    //type
                    row[2] = "Outdoor Furniture";
                    //price
                    row[3] = 1;
                    //supplier
                    row[4] = "ShortGnomes";
                    //supplier id
                    row[5] = 3;
                    //quantity
                    row[6] = 5;
                    table.Rows.Add(row);
                    dataset.Tables.Add(table);
                }

            }
            
            return dataset;
        }
        public void PushData()
        {

        }
    }
}
