using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DIYShopSys
{
    internal class Sql
    {
        OracleConnection connection;
        public Sql()
        {
            String oradb = "Data Source = oracle/orcl; User Id = T00225039; Password = kan7_Ww3496c;";
            this.connection = new OracleConnection(oradb);
            connection.Open();
            connection.Close();
        }
        public void AddOrUpdate(string query)
        {
            this.connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public DataSet GetDataSet(string query)
        {
            this.connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            connection.Close();
            return ds;
        }
        public int GetNextSupplierId()
        {
            this.connection.Open();
            string query = "Select MAX(supplier_id) from suppliers";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            OracleDataReader data = cmd.ExecuteReader();
            this.connection.Close();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
        public int GetNextTypeId()
        {
            this.connection.Open();
            string query = "Select MAX(type_id) from item_types";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            OracleDataReader data = cmd.ExecuteReader();
            this.connection.Close();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
        public int GetNextStockId()
        {
            this.connection.Open();
            string query = "Select MAX(item_id) from items";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            OracleDataReader data = cmd.ExecuteReader();
            this.connection.Close();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
        public int GetNextOrderId()
        {
            this.connection.Open();
            string query = "Select MAX(order_id) from orders";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            OracleDataReader data = cmd.ExecuteReader();
            this.connection.Close();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
        public int GetNextSaleId()
        {
            this.connection.Open();
            string query = "Select MAX(sale_id) from sales";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            OracleDataReader data = cmd.ExecuteReader();
            this.connection.Close();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
    }
}
