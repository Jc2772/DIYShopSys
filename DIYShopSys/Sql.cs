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
                row[1] = "Tims Tools";
                row[2] = "087 546 3821";
                row[3] = "TimToolsRep@gmail";
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = 3;
                row[1] = "ShortGnomes";
                row[2] = "087 179 4392";
                row[3] = "ShortGnomes@outlook.com";
                table.Rows.Add(row);
                dataset.Tables.Add(table);
            }
            else if (text.Contains("Item"))
            {
                DataTable table = new DataTable("Item");
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
                row[2] = "Tools";
                row[3] = 1;
                row[4] = "Tims Tools";
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
                row[4] = "Tims Tools";
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
                dataset.Tables.Add(table);
            }
            else if (text.Equals("Sales"))
            {
                DataTable table = new DataTable("Item");
                DataColumn column;
                DataRow row;
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
                column.DataType = typeof(int);
                column.ColumnName = "Quantity";
                column.ReadOnly = true;
                table.Columns.Add(column);

                row = table.NewRow();
                row[0] = "Daffodil Bulbs";
                row[1] = "Bulbs";
                row[2] = 1;
                row[3] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = "Sledge Hammer";
                row[1] = "Tools";
                row[2] = 1;
                row[3] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = "Green Gnome";
                row[1] = "Outdoor Furniture";
                row[2] = 1;
                row[3] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = "Grass Seeds";
                row[1] = "Seeds";
                row[2] = 1;
                row[3] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = "Wrench Set";
                row[1] = "Tools";
                row[2] = 1;
                row[3] = 5;
                table.Rows.Add(row);

                row = table.NewRow();
                row[0] = "Green Gnome";
                row[1] = "Outdoor Furniture";
                row[2] = 1;
                row[3] = 5;
                table.Rows.Add(row);
                dataset.Tables.Add(table);
            }
            return dataset;
        }
        public void PushData()
        {

        }
    }
}
