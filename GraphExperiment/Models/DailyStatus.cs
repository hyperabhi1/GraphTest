﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExperiment.Models
{
    class DailyStatus
    {
        public string UserId { get; set; }
        public DateTime Time { get; set; }
        public double Distance { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Calories { get; set; }
        public int Duration { get; set; }
    }
}
