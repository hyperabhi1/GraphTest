using GraphExperiment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment.Data
{
    class UserMappingData
    {
        public static string UserMapping = "UserMapping";
        public static List<UserMapping> Get()
        {
            List<UserMapping> userMappings = new List<UserMapping>();
            string query = $"SELECT * FROM {UserMapping} ORDER BY [UserId];";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                userMappings.Add(new UserMapping()
                {
                    UserId = row["UserId"].ToString(),
                    FullName = row["FullName"].ToString()
                });
            }
            return userMappings;
        }
        public static List<UserMapping> GetById(string userId)
        {
            List<UserMapping> userMappings = new List<UserMapping>();
            string query = $"SELECT * FROM {UserMapping} WHERE USERID = '{userId}';";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                userMappings.Add(new UserMapping()
                {
                    UserId = row["UserId"].ToString(),
                    FullName = row["FullName"].ToString()
                });
            }
            return userMappings;
        }
        public static bool Update(UserMapping userMapping)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(userMapping.UserId))
                sb.Append($"UserId = '{userMapping.UserId}', ");
            if (!string.IsNullOrEmpty(userMapping.FullName))
                sb.Append($"FullName = '{userMapping.FullName}', ");
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                string query = $"UPDATE {UserMapping} SET {sb.ToString().Substring(0, sb.ToString().Length - 2)} WHERE USERID = '{userMapping.UserId}';";
                MySQLAdapter.Update(query);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Insert(UserMapping userMapping)
        {
            StringBuilder sbColumn = new StringBuilder();
            StringBuilder sbValue = new StringBuilder();

            if (!string.IsNullOrEmpty(userMapping.UserId))
            {
                sbColumn.Append($"USERID,");
                sbValue.Append($"'{userMapping.UserId}',");
            }
            if (!string.IsNullOrEmpty(userMapping.FullName))
            {
                sbColumn.Append($"FullName,");
                sbValue.Append($"'{userMapping.FullName}',");
            }

            string query = $"INSERT INTO {UserMapping} ({sbColumn.ToString().Substring(0, sbColumn.ToString().Length - 1)}) VALUES ({sbValue.ToString().Substring(0, sbValue.ToString().Length - 1)});";

            if (!string.IsNullOrEmpty(sbValue.ToString()))
            {
                MySQLAdapter.Insert(query);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(string userId)
        {
            string query = $"DELETE FROM {UserMapping} WHERE USERID = '{userId}';";
            var response = MySQLAdapter.Delete(query);
            return response;
        }
    }
}
