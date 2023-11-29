﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYShopSys
{
    internal class Sql
    {
        //how to create a datatable https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-7.0
        public DataSet SupplierData(){ 
            DataSet dataset = new DataSet();
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
            column.ColumnName = "PhoneNumber";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Email";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "DeliveryFee";
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
            row[4] = 5;
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
            row[4] = 7;
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
            row[4] = 3;
            table.Rows.Add(row);
            dataset.Tables.Add(table);
            return dataset;
        }
        public DataSet typesData()
        {
            DataSet dataset = new DataSet();
            DataTable table = new DataTable("Item");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "TypeName";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "TypeId";
            table.Columns.Add(column);

            row = table.NewRow();
            row[2] = "Bulbs";
            row[3] = 1;

            row = table.NewRow();
            row[0] = "Tools";
            row[1] = 2;

            row = table.NewRow();
            row[2] = "Outdoor Furniture";
            row[3] = 3;

            row = table.NewRow();
            row[2] = "Seeds";
            row[3] = 4;
            table.Rows.Add(row);
            dataset.Tables.Add(table);
            return dataset;
        }
        public DataSet itemsData()
        {
            DataSet dataset = new DataSet();
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
            column.ColumnName = "TypeName";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "TypeId";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "Price";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "SupplierName";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "SupplierId";
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
            row[3] = 1;
            //price
            row[4] = 1;
            //supplier name
            row[5] = "Heavenly Plants";
            //supplier id
            row[6] = 1;
            //quantity
            row[7] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //id
            row[0] = 2;
            //name
            row[1] = "Sledge Hammer";
            //type
            row[2] = "Tools";
            row[3] = 2;
            //price
            row[4] = 1;
            //supplier name
            row[5] = "Tims Tools";
            //supplier id
            row[6] = 2;
            //quantity
            row[7] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //id
            row[0] = 3;
            //name
            row[1] = "Green Gnome";
            //type
            row[2] = "Outdoor Furniture";
            row[3] = 3;
            //price
            row[4] = 1;
            //supplier name
            row[5] = "ShortGnomes";
            //supplier id
            row[6] = 3;
            //quantity
            row[7] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //id
            row[0] = 4;
            //name
            row[1] = "Grass Seeds";
            //type
            row[2] = "Seeds";
            row[3] = 4;
            //price
            row[4] = 1;
            //supplier name
            row[5] = "Heavenly Plants";
            //supplier id
            row[6] = 1;
            //quantity
            row[7] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //id
            row[0] = 5;
            //name
            row[1] = "Wrench Set";
            //type
            row[2] = "Tools";
            row[3] = 2;
            //price
            row[4] = 1;
            //supplier name
            row[5] = "Tims Tools";
            //supplier id
            row[6] = 2;
            //quantity
            row[7] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //id
            row[0] = 6;
            //name
            row[1] = "Green Gnome";
            //type
            row[2] = "Outdoor Furniture";
            row[3] = 3;
            //price
            row[4] = 1;
            //supplier
            row[5] = "ShortGnomes";
            //supplier id
            row[6] = 3;
            //quantity
            row[7] = 5;
            table.Rows.Add(row);
            dataset.Tables.Add(table);
            return dataset;
        }
        public DataSet restockData()
        {
            DataSet dataset = new DataSet();
            DataTable table = new DataTable("Item");
            DataColumn column;
            DataRow row;
            //name column
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "itemName";
            table.Columns.Add(column);

            //type column
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "TypeName";
            table.Columns.Add(column);

            //Cost column
            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "Cost";
            table.Columns.Add(column);

            //id column
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "SupplierId";
            table.Columns.Add(column);

            //type column
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "SupplierName";
            table.Columns.Add(column);
            row = table.NewRow();

            //Delivery Fee column
            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "DeliveryFee";
            table.Columns.Add(column);

            //name
            row[0] = "Daffodil Bulbs";
            //type
            row[1] = "Bulbs";
            //cost
            row[2] = 2;
            //supplier
            row[3] = 1;
            row[4] = "Heavenly Plants";
            row[5] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //name
            row[0] = "Rake";
            //type
            row[1] = "Tools";
            //cost
            row[2] = 5;
            //supplier
            row[3] = 2;
            row[4] = "Tims Tools";
            row[5] = 7;
            table.Rows.Add(row);

            row = table.NewRow();
            //name
            row[0] = "Red Gnome";
            //type
            row[1] = "Outdoor Furniture";
            //cost
            row[2] = 4;
            //supplier
            row[3] = 3;
            row[4] = "ShortGnomes";
            row[5] = 3;
            table.Rows.Add(row);

            row = table.NewRow();
            //name
            row[0] = "Grass Seeds";
            //type
            row[1] = "Seeds";
            //cost
            row[2] = 4;
            //supplier
            row[3] = 1;
            row[4] = "Heavenly Plants";
            row[5] = 5;
            table.Rows.Add(row);

            row = table.NewRow();
            //name
            row[0] = "Hedge Sheers";
            //type
            row[1] = "Tools";
            //cost
            row[2] = 9;
            //supplier
            row[3] = 2;
            row[4] = "Tims Tools";
            row[5] = 7;
            table.Rows.Add(row);

            row = table.NewRow();
            //name
            row[0] = "Green Gnome";
            //type
            row[1] = "Outdoor Furniture";
            //cost
            row[2] = 4;
            //supplier
            row[3] = 3;
            row[4] = "ShortGnomes";
            row[5] = 3;
            table.Rows.Add(row);
            dataset.Tables.Add(table);
            return dataset;
        }
    }
}
