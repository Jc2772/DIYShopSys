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
    }
}
