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
        OracleConnection connection = new OracleConnection("Data Source = oracle/orcl; User Id = T00225039; Password = kan7_Ww3496c;");
        public void AddOrUpdate(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public DataSet GetDataSet(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            connection.Close();
            return ds;
        }
        public int GetNextSupplierId()
        {
            connection.Open();
            string query = "Select MAX(SupplierId) from Suppliers";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
            connection.Open();
            string query = "Select MAX(TypeId) from ItemTypes";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
            connection.Open();
            string query = "Select MAX(StockId) from Stock";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
            connection.Open();
            string query = "Select MAX(OrderId) from Orders";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
            connection.Open();
            string query = "Select MAX(SaleId) from Sales";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
