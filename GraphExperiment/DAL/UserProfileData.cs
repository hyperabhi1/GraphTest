using GraphExperiment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment.Data
{
    class UserProfileData
    {
        public static string UserProfile = "USERPROFILE";
        public static List<UserProfile> Get()
        {
            List<UserProfile> userProfiles = new List<UserProfile>();
            string query = $"SELECT * FROM {UserProfile};";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                userProfiles.Add(new UserProfile()
                {
                    UserId = row["UserId"].ToString(),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Age = int.Parse(row["Age"].ToString()),
                    Height = double.Parse(row["Height"].ToString()),
                    Weight = double.Parse(row["Weight"].ToString()),
                    Gender = row["Age"].ToString()
                });
            }
            return userProfiles;
        }
        public static List<UserProfile> GetById(string userId)
        {
            List<UserProfile> userProfiles = new List<UserProfile>();
            string query = $"SELECT * FROM {UserProfile} WHERE USERID = '{userId}';";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                userProfiles.Add(new UserProfile()
                {
                    UserId = row["UserId"].ToString(),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Age = int.Parse(row["Age"].ToString()),
                    Height = double.Parse(row["Height"].ToString()),
                    Weight = double.Parse(row["Weight"].ToString()),
                    Gender = row["Age"].ToString()
                });
            }
            return userProfiles;
        }
        public static bool Update(UserProfile userProfile)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(userProfile.UserId))
                sb.Append($"UserId = '{userProfile.UserId.ToUpper()}', ");
            if (!string.IsNullOrEmpty(userProfile.FirstName))
                sb.Append($"FirstName = '{userProfile.FirstName.ToUpper()}', ");
            if (!string.IsNullOrEmpty(userProfile.LastName))
                sb.Append($"LastName = '{userProfile.LastName.ToUpper()}', ");
            if (userProfile.Age != 0)
                sb.Append($"Age = '{userProfile.Age}', ");
            if (Math.Abs(userProfile.Height) > 0)
                sb.Append($"Height = '{userProfile.Height}', ");
            if (Math.Abs(userProfile.Weight) > 0)
                sb.Append($"Weight = '{userProfile.Weight}', ");
            if (!string.IsNullOrEmpty(userProfile.Gender))
                sb.Append($"Gender = '{userProfile.Gender[0].ToString().ToUpper()}', ");
            if(!string.IsNullOrEmpty(sb.ToString()))
            {
                string query = $"UPDATE {UserProfile} SET {sb.ToString().Substring(0, sb.ToString().Length - 2)} WHERE USERID = '{userProfile.UserId}';";
                MySQLAdapter.Update(query);
                return true;
            }
            else
                return false;
        }
        public static bool Insert(UserProfile userProfile)
        {
            StringBuilder sbColumn = new StringBuilder();
            StringBuilder sbValue = new StringBuilder();

            if (!string.IsNullOrEmpty(userProfile.UserId))
            {
                sbColumn.Append($"USERID,");
                sbValue.Append($"'{userProfile.UserId.ToUpper()}',");
            }
            if (!string.IsNullOrEmpty(userProfile.FirstName))
            {
                sbColumn.Append($"FIRSTNAME,");
                sbValue.Append($"'{userProfile.FirstName.ToUpper()}',");
            }
            if (!string.IsNullOrEmpty(userProfile.LastName))
            {
                sbColumn.Append($"LASTNAME,");
                sbValue.Append($"'{userProfile.LastName.ToUpper()}',");
            }
            if (userProfile.Age != 0)
            {
                sbColumn.Append($"AGE,");
                sbValue.Append($"{userProfile.Age},");
            }
            if (Math.Abs(userProfile.Height) > 0)
            {
                sbColumn.Append($"HEIGHT,");
                sbValue.Append($"{userProfile.Height},");
            }
            if (Math.Abs(userProfile.Weight) > 0)
            {
                sbColumn.Append($"WEIGHT,");
                sbValue.Append($"{userProfile.Weight},");
            }
            if (!string.IsNullOrEmpty(userProfile.Gender))
            {
                sbColumn.Append($"GENDER,");
                sbValue.Append($"'{userProfile.Gender[0].ToString().ToUpper()}',");
            }

            if (string.IsNullOrEmpty(sbColumn.ToString()))
            {
                string query = $"INSERT INTO {UserProfile} ({sbColumn.ToString().Substring(0, sbColumn.ToString().Length - 1)}) VALUES ({sbValue.ToString().Substring(0, sbValue.ToString().Length - 1)});";
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
