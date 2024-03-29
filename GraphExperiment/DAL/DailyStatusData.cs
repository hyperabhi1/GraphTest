﻿using GraphExperiment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment.DAL
{
    class DailyStatusData
    {
        public static string DailyStatus = "DAILYSTATUS";
        public static List<DailyStatus> Get()
        {
            List<DailyStatus> dailyStatuss = new List<DailyStatus>();
            string query = $"SELECT [UserId] ,[Time] ,[Distance] ,[Weight] ,[Calories] ,[Height] ,[Duration] FROM [dbo].[{DailyStatus}] ORDER BY [UserId], [Time] ASC;";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                dailyStatuss.Add(new DailyStatus()
                {
                    UserId = row["UserId"].ToString(),
                    Time = DateTime.Parse(row["Time"].ToString()),
                    Distance = double.Parse(row["Distance"].ToString()),
                    Height = double.Parse(row["Height"].ToString()),
                    Weight = double.Parse(row["Weight"].ToString()),
                    Calories = double.Parse(row["Calories"].ToString()),
                    Duration = int.Parse(row["Duration"].ToString())
                });
            }
            return dailyStatuss;
        }
        public static List<DailyStatus> GetById(string userId)
        {
            List<DailyStatus> dailyStatuss = new List<DailyStatus>();
            string query = $"SELECT * FROM {DailyStatus} WHERE USERID = '{userId}';";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                dailyStatuss.Add(new DailyStatus()
                {
                    UserId = row["UserId"].ToString(),
                    Time = DateTime.Parse(row["Time"].ToString()),
                    Distance = double.Parse(row["Distance"].ToString()),
                    Height = double.Parse(row["Height"].ToString()),
                    Weight = double.Parse(row["Weight"].ToString()),
                    Calories = double.Parse(row["Calories"].ToString()),
                    Duration = int.Parse(row["Duration"].ToString())
                });
            }
            return dailyStatuss;
        }
        public static bool Update(DailyStatus dailyStatus)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(dailyStatus.UserId))
                sb.Append($"UserId = '{dailyStatus.UserId}', ");
            if (dailyStatus.Time != DateTime.MinValue)
                sb.Append($"Time = '{dailyStatus.Time}', ");
            if (Math.Abs(dailyStatus.Distance) > 0)
                sb.Append($"Distance = '{dailyStatus.Distance}', ");
            if (Math.Abs(dailyStatus.Weight) > 0)
                sb.Append($"Weight = '{dailyStatus.Weight}', ");
            if (Math.Abs(dailyStatus.Height) > 0)
                sb.Append($"Height = '{dailyStatus.Height}', ");
            if (Math.Abs(dailyStatus.Calories) > 0)
                sb.Append($"Calories = '{dailyStatus.Calories}', ");
            if (dailyStatus.Duration != 0)
                sb.Append($"Duration = '{dailyStatus.Duration}', ");

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                string query = $"UPDATE {DailyStatus} SET {sb.ToString().Substring(0, sb.ToString().Length - 2)} WHERE USERID = '{dailyStatus.UserId}';";
                MySQLAdapter.Update(query);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Insert(DailyStatus dailyStatus)
        {
            StringBuilder sbColumn = new StringBuilder();
            StringBuilder sbValue = new StringBuilder();

            if (!string.IsNullOrEmpty(dailyStatus.UserId))
            {
                sbColumn.Append($"USERID,");
                sbValue.Append($"'{dailyStatus.UserId}',");
            }
            if (dailyStatus.Time != DateTime.MinValue)
            {
                sbColumn.Append($"Time,");
                sbValue.Append($"'{dailyStatus.Time}',");
            }
            if (Math.Abs(dailyStatus.Distance) > 0)
            {
                sbColumn.Append($"Distance,");
                sbValue.Append($"'{dailyStatus.Distance}',");
            }
            if (Math.Abs(dailyStatus.Weight) > 0)
            {
                sbColumn.Append($"Weight,");
                sbValue.Append($"{dailyStatus.Weight},");
            }
            if (Math.Abs(dailyStatus.Height) > 0)
            {
                sbColumn.Append($"HEIGHT,");
                sbValue.Append($"{dailyStatus.Height},");
            }
            if (Math.Abs(dailyStatus.Calories) > 0)
            {
                sbColumn.Append($"Calories,");
                sbValue.Append($"{dailyStatus.Calories},");
            }
            if (dailyStatus.Duration != 0)
            {
                sbColumn.Append($"Duration,");
                sbValue.Append($"{dailyStatus.Duration},");
            }

            if (!string.IsNullOrEmpty(sbValue.ToString()))
            {
                string query = $"INSERT INTO {DailyStatus} ({sbColumn.ToString().Substring(0, sbColumn.ToString().Length - 1)}) VALUES ({sbValue.ToString().Substring(0, sbValue.ToString().Length - 1)});";
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
            string query = $"DELETE FROM {DailyStatus} WHERE USERID = '{userId}';";
            var response = MySQLAdapter.Delete(query);
            return response;
        }
        public static bool Delete(string userId, DateTime time)
        {
            string query = $"DELETE FROM {DailyStatus} WHERE USERID = '{userId}' AND TIME BETWEEN '{time.ToString("yyyy-MM-dd HH:mm:00")}' AND '{time.ToString("yyyy-MM-dd HH:mm:59")}';";
            var response = MySQLAdapter.Delete(query);
            return response;
        }

    }


}
