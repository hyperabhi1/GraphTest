using GraphExperiment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment.DAL
{
    class LatestProfileData
    {
        public static string LatestProfile = "LATESTPROFILE";
        public static List<LatestProfile> Get()
        {
            List<LatestProfile> latestProfiles = new List<LatestProfile>();
            string query = $"SELECT * FROM {LatestProfile};";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                latestProfiles.Add(new LatestProfile()
                {
                    UserId = row["UserId"].ToString(),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Age = int.Parse(row["Distance"].ToString()),
                    Height = double.Parse(row["Height"].ToString()),
                    Weight = double.Parse(row["Weight"].ToString())
                });
            }
            return latestProfiles;
        }
        public static List<LatestProfile> GetById(string userId)
        {
            List<LatestProfile> latestProfiles = new List<LatestProfile>();
            string query = $"SELECT * FROM {LatestProfile} WHERE USERID = '{userId}';";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                latestProfiles.Add(new LatestProfile()
                {
                    UserId = row["UserId"].ToString(),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Age = int.Parse(row["Distance"].ToString()),
                    Height = double.Parse(row["Height"].ToString()),
                    Weight = double.Parse(row["Weight"].ToString())
                });
            }
            return latestProfiles;
        }
        public static bool Update(LatestProfile latestProfile)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(latestProfile.UserId))
                sb.Append($"UserId = '{latestProfile.UserId.ToUpper()}', ");
            if (!string.IsNullOrEmpty(latestProfile.FirstName))
                sb.Append($"FirstName = '{latestProfile.FirstName.ToUpper()}', ");
            if (!string.IsNullOrEmpty(latestProfile.LastName))
                sb.Append($"LastName = '{latestProfile.LastName.ToUpper()}', ");
            if (latestProfile.Age != 0)
                sb.Append($"Age = '{latestProfile.Age}', ");
            if (Math.Abs(latestProfile.Height) > 0)
                sb.Append($"Height = '{latestProfile.Height}', ");
            if (Math.Abs(latestProfile.Weight) > 0)
                sb.Append($"Weight = '{latestProfile.Weight}', ");

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                string query = $"UPDATE {LatestProfile} SET {sb.ToString().Substring(0, sb.ToString().Length - 2)} WHERE USERID = '{latestProfile.UserId}';";
                MySQLAdapter.Update(query);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Insert(LatestProfile latestProfile)
        {
            StringBuilder sbColumn = new StringBuilder();
            StringBuilder sbValue = new StringBuilder();

            if (!string.IsNullOrEmpty(latestProfile.UserId))
            {
                sbColumn.Append($"USERID,");
                sbValue.Append($"'{latestProfile.UserId.ToUpper()}',");
            }
            if (!string.IsNullOrEmpty(latestProfile.FirstName))
            {
                sbColumn.Append($"FIRSTNAME,");
                sbValue.Append($"'{latestProfile.FirstName.ToUpper()}',");
            }
            if (!string.IsNullOrEmpty(latestProfile.LastName))
            {
                sbColumn.Append($"LASTNAME,");
                sbValue.Append($"'{latestProfile.LastName.ToUpper()}',");
            }
            if (latestProfile.Age != 0)
            {
                sbColumn.Append($"AGE,");
                sbValue.Append($"{latestProfile.Age},");
            }
            if (Math.Abs(latestProfile.Height) > 0)
            {
                sbColumn.Append($"HEIGHT,");
                sbValue.Append($"{latestProfile.Height},");
            }
            if (Math.Abs(latestProfile.Weight) > 0)
            {
                sbColumn.Append($"WEIGHT,");
                sbValue.Append($"{latestProfile.Weight},");
            }

            if (!string.IsNullOrEmpty(sbColumn.ToString()))
            {
                string query = $"INSERT INTO {LatestProfile} ({sbColumn.ToString().Substring(0, sbColumn.ToString().Length - 1)}) VALUES ({sbValue.ToString().Substring(0, sbValue.ToString().Length - 1)});";
                MySQLAdapter.Insert(query);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
