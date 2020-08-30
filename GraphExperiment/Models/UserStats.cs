using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment.Models
{
    public class UserStats
    {
        public DateTime Time { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
        public double Calories { get; set; }
        public double Bmi { get; set; }
        public double Effort { get; set; }
    }
    public class UserStatsPair
    {
        public List<KeyValuePair<DateTime, double>> DurationCollection { get; set; }
        public List<KeyValuePair<DateTime, double>> DistanceCollection { get; set; }
        public List<KeyValuePair<DateTime, double>> CaloriesCollection { get; set; }
        public List<KeyValuePair<DateTime, double>> BmiCollection { get; set; }
        public List<KeyValuePair<DateTime, double>> EffortCollection { get; set; }
    }
}
