using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphExperiment.Models;

namespace GraphExperiment
{
    class Common
    {
        public static List<UserStats> ConvertToUserStats (List<DailyStatus> dailyStatuses)
        {
            var userStatsCollection = new List<UserStats>();
            foreach (var dailyStatus in dailyStatuses)
            {
                UserStats userStats = new UserStats()
                {
                    Distance = dailyStatus.Distance,
                    Duration = dailyStatus.Duration,
                    Calories = dailyStatus.Calories,
                    Bmi = ((dailyStatus.Height) / (dailyStatus.Weight * dailyStatus.Weight)),
                    EnergyLevel = (dailyStatus.Distance / dailyStatus.Duration)
                };
                userStatsCollection.Add(userStats);
            }
            return userStatsCollection;
        }
    }
}
