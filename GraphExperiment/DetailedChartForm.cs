using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphExperiment.DAL;
using GraphExperiment.Data;
using GraphExperiment.Models;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace GraphExperiment
{
    public partial class DetailedChartForm : Form
    {
        private List<string> _users = new List<string>();
        public DetailedChartForm()
        {
            InitializeComponent();
        }
        public DetailedChartForm(string userId)
        {
            InitializeComponent();
            _users.Add(userId);
        }
        public DetailedChartForm(List<string> users)
        {
            InitializeComponent();
            _users = users;
        }

        private void DetailedChartForm_Load(object sender, EventArgs e)
        {
            if (_users.Count > 0)
            {
                var userMappingCollection = UserMappingData.Get(_users);
                if (userMappingCollection.Any())
                {
                    var durationSeriesCollection = Common.GetSeriesCollection();
                    var distanceSeriesCollection = Common.GetSeriesCollection();
                    var caloriesSeriesCollection = Common.GetSeriesCollection();
                    var bmiSeriesCollection = Common.GetSeriesCollection();
                    var effortSeriesCollection = Common.GetSeriesCollection();

                    foreach (var userMapping in userMappingCollection)
                    {
                        var userStatsPair = Common.ConvertToUserStatsPair(DailyStatusData.GetById(userMapping.UserId));

                        if (userStatsPair != null)
                        {
                            durationSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName, Common.GetChartValues(userStatsPair.DurationCollection)));
                            distanceSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName, Common.GetChartValues(userStatsPair.DistanceCollection)));
                            caloriesSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName, Common.GetChartValues(userStatsPair.CaloriesCollection)));
                            bmiSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName, Common.GetChartValues(userStatsPair.BmiCollection)));
                            effortSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName, Common.GetChartValues(userStatsPair.EffortCollection)));
                        }
                    }
                    if(durationSeriesCollection.Count > 0)
                    {
                        durationCartesianChart.Zoom = ZoomingOptions.Xy;
                        durationCartesianChart.Series.Clear();
                        durationCartesianChart.Series = durationSeriesCollection;
                        durationCartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis { MinValue = 0 });
                        durationCartesianChart.AxisX.Clear();
                        durationCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }

                    if (distanceSeriesCollection.Count > 0)
                    {
                        distanceCartesianChart.Zoom = ZoomingOptions.Xy;
                        distanceCartesianChart.Series.Clear();
                        distanceCartesianChart.Series = distanceSeriesCollection;
                        distanceCartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis { MinValue = 0 });
                        distanceCartesianChart.AxisX.Clear();
                        distanceCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }
                    if(caloriesSeriesCollection.Count > 0)
                    {
                        caloriesCartesianChart.Zoom = ZoomingOptions.Xy;
                        caloriesCartesianChart.Series.Clear();
                        caloriesCartesianChart.Series = caloriesSeriesCollection;
                        caloriesCartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis { MinValue = 0 });
                        caloriesCartesianChart.AxisX.Clear();
                        caloriesCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }
                    if(bmiSeriesCollection.Count > 0)
                    {
                        bmiCartesianChart.Zoom = ZoomingOptions.Xy;
                        bmiCartesianChart.Series.Clear();
                        bmiCartesianChart.Series = bmiSeriesCollection;
                        bmiCartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis { MinValue = 0 });
                        bmiCartesianChart.AxisX.Clear();
                        bmiCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }

                    if (effortSeriesCollection.Count > 0)
                    {
                        effortCartesianChart.Zoom = ZoomingOptions.Xy;
                        effortCartesianChart.Series.Clear();
                        effortCartesianChart.Series = effortSeriesCollection;
                        effortCartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis { MinValue = 0 });
                        effortCartesianChart.AxisX.Clear();
                        effortCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }
                }
            }
            else
            {
                var userMappingCollection = UserMappingData.Get();
                if (userMappingCollection.Any())
                {
                    var durationSeriesCollection = Common.GetSeriesCollection();
                    var distanceSeriesCollection = Common.GetSeriesCollection();
                    var caloriesSeriesCollection = Common.GetSeriesCollection();
                    var bmiSeriesCollection = Common.GetSeriesCollection();
                    var effortSeriesCollection = Common.GetSeriesCollection();

                    foreach (var userMapping in userMappingCollection)
                    {
                        var userStatsPair = Common.ConvertToUserStatsPair(DailyStatusData.GetById(userMapping.UserId));

                        if (userStatsPair != null)
                        {
                            durationSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName,
                                Common.GetChartValues(userStatsPair.DurationCollection)));
                            distanceSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName,
                                Common.GetChartValues(userStatsPair.DistanceCollection)));
                            caloriesSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName,
                                Common.GetChartValues(userStatsPair.CaloriesCollection)));
                            bmiSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName,
                                Common.GetChartValues(userStatsPair.BmiCollection)));
                            effortSeriesCollection.Add(Common.GetLineSeries(userMapping.FullName,
                                Common.GetChartValues(userStatsPair.EffortCollection)));
                        }
                    }

                    if (durationSeriesCollection.Count > 0)
                    {
                        durationCartesianChart.Series.Clear();
                        durationCartesianChart.Series = durationSeriesCollection;
                        durationCartesianChart.AxisX.Clear();
                        durationCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }

                    if (distanceSeriesCollection.Count > 0)
                    {
                        distanceCartesianChart.Series.Clear();
                        distanceCartesianChart.Series = distanceSeriesCollection;
                        distanceCartesianChart.AxisX.Clear();
                        distanceCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }

                    if (caloriesSeriesCollection.Count > 0)
                    {
                        caloriesCartesianChart.Series.Clear();
                        caloriesCartesianChart.Series = caloriesSeriesCollection;
                        caloriesCartesianChart.AxisX.Clear();
                        caloriesCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }

                    if (bmiSeriesCollection.Count > 0)
                    {
                        bmiCartesianChart.Series.Clear();
                        bmiCartesianChart.Series = bmiSeriesCollection;
                        bmiCartesianChart.AxisX.Clear();
                        bmiCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }

                    if (effortSeriesCollection.Count > 0)
                    {
                        effortCartesianChart.Series.Clear();
                        effortCartesianChart.Series = effortSeriesCollection;
                        effortCartesianChart.AxisX.Clear();
                        effortCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                    }
                }
            }
        }
    }
}
