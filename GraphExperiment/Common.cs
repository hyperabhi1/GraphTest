using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphExperiment.DAL;
using GraphExperiment.Models;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

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
                    Time = dailyStatus.Time,
                    Distance = dailyStatus.Distance,
                    Duration = dailyStatus.Duration,
                    Calories = dailyStatus.Calories,
                    Bmi = ((dailyStatus.Weight) / (dailyStatus.Height * dailyStatus.Height)),
                    Effort = (dailyStatus.Distance / dailyStatus.Duration)
                };
                userStatsCollection.Add(userStats);
            }
            return userStatsCollection;
        }
        public static UserStatsPair ConvertToUserStatsPair (List<DailyStatus> dailyStatuses)
        {
            var userStatsPair = new UserStatsPair();
            var durationCollection = new List<KeyValuePair<DateTime, double>>();
            var distanceCollection = new List<KeyValuePair<DateTime, double>>();
            var caloriesCollection = new List<KeyValuePair<DateTime, double>>();
            var bmiCollection = new List<KeyValuePair<DateTime, double>>();
            var effortCollection = new List<KeyValuePair<DateTime, double>>();
            foreach (var dailyStatus in dailyStatuses)
            {
                var time = dailyStatus.Time;
                var distance = dailyStatus.Distance;
                var duration = dailyStatus.Duration;
                var calories = dailyStatus.Calories;
                var bmi = ((dailyStatus.Weight) / (dailyStatus.Height * dailyStatus.Height));
                var effort = (dailyStatus.Distance / dailyStatus.Duration);
                durationCollection.Add(new KeyValuePair<DateTime, double>(time, duration));
                distanceCollection.Add(new KeyValuePair<DateTime, double>(time, distance));
                caloriesCollection.Add(new KeyValuePair<DateTime, double>(time, calories));
                bmiCollection.Add(new KeyValuePair<DateTime, double>(time, bmi));
                effortCollection.Add(new KeyValuePair<DateTime, double>(time, effort));
            }

            userStatsPair.DurationCollection = durationCollection;
            userStatsPair.DistanceCollection = distanceCollection;
            userStatsPair.CaloriesCollection = caloriesCollection;
            userStatsPair.BmiCollection = bmiCollection;
            userStatsPair.EffortCollection = effortCollection;

            return userStatsPair;
        }
        public static ChartValues<DateModel> GetChartValues(List<KeyValuePair<DateTime, double>> list)
        {
            var chartValues = new ChartValues<DateModel>();
            if (list != null && list.Any())
            {
                list.ForEach(x => chartValues.Add(new DateModel()
                {
                    Time = x.Key,
                    Value = x.Value
                }));
            }
            return chartValues;
        }

        public static LineSeries GetLineSeries(string fullName, ChartValues<DateModel> chartValues)
        {
            return new LineSeries()
            {
                Title = fullName,
                PointGeometrySize = 5,
                Values = chartValues,
                ScalesYAt = 0
            };
        }
        public static SeriesCollection GetSeriesCollection()
        {
            var dayConfig = Mappers.Xy<DateModel>()
                .X(dateModel => dateModel.Time.Ticks / TimeSpan.FromSeconds(1).Ticks)
                .Y(dateModel => dateModel.Value);
            return new LiveCharts.SeriesCollection(dayConfig);
        }

        public static Axis GetDateTimeAxis()
        {
            return new LiveCharts.Wpf.Axis
            {
                LabelFormatter = value =>
                    new DateTime((long) (value * TimeSpan.FromSeconds(1).Ticks)).ToString("dd/MM/yy")
            };
        }
    }
}
