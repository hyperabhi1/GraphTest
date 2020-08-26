using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment
{
    class MySQLAdapter
    {
        private static readonly string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        
        public static DataTable Get(string query)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, ConnectionString);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public static bool Insert(string sqlQuery)
        {
            bool returnVal = false;
            SqlConnection SqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(sqlQuery, SqlConnection);

            try
            {
                SqlConnection.Open();
                command.ExecuteScalar();
                returnVal = true;
                command.Dispose();
                SqlConnection.Close();
                SqlConnection.Dispose();
                return returnVal;
            }
            catch (Exception e)
            {
                command.Dispose();
                SqlConnection.Close();
                SqlConnection.Dispose();
                throw;
            }
        }
        public static bool Update(string updateQuery)
        {
            bool returnVal = false;

            SqlCommand command = null;
            SqlConnection SqlConnection = new SqlConnection(ConnectionString);
            command = new SqlCommand(updateQuery, SqlConnection);

            try
            {

                SqlConnection.Open();
                var commandResult = command.ExecuteScalar();
                returnVal = true;
                command.Dispose();
                SqlConnection.Close();
                SqlConnection.Dispose();
                return returnVal;
            }
            catch (Exception e)
            {
                command.Dispose();
                SqlConnection.Close();
                SqlConnection.Dispose();
                throw;
            }
        }
        public static bool Delete(string sqlQuery)
        {
            bool result = false;
            SqlConnection SqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(sqlQuery, SqlConnection);

            try
            {

                SqlConnection.Open();
                int rowsDeletedCount = command.ExecuteNonQuery();
                if (rowsDeletedCount != 0)
                    result = true;

                command.Dispose();
                SqlConnection.Close();
                SqlConnection.Dispose();
                return result;
            }
            catch (Exception e)
            {

                command.Dispose();
                SqlConnection.Close();
                SqlConnection.Dispose();
                throw;
            }
        }
    }
}
