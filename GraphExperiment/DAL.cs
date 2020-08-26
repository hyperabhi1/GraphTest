using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExperiment
{
    class DALs
    {
        public static void xyz()
        {

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Environment.CurrentDirectory + "\\HealthStats.mdf;Integrated Security=True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand("select * from userprofile", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    } 
}
