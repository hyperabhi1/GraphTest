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
        private string _userId = String.Empty;
        public DetailedChartForm()
        {
            InitializeComponent();
        }
        public DetailedChartForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void DetailedChartForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_userId))
            {
                var userMappingCollection = UserMappingData.GetById(_userId);
                if (userMappingCollection.Any())
                {
                    foreach (var userMapping in userMappingCollection)
                    {
                        var userStatsPair = Common.ConvertToUserStatsPair(DailyStatusData.GetById(userMapping.UserId));
                        if (userStatsPair != null)
                        {
                            #region DurationGraph
                            var durationSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.DurationCollection);

                            if (durationSeriesCollection != null && durationSeriesCollection.Any())
                            {
                                durationCartesianChart.Series.Clear();
                                durationCartesianChart.Series = durationSeriesCollection;
                                durationCartesianChart.AxisX.Clear();
                                durationCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                durationCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region DistanceGraph
                            var distanceSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.DistanceCollection);

                            if (distanceSeriesCollection != null && distanceSeriesCollection.Any())
                            {
                                distanceCartesianChart.Series.Clear();
                                distanceCartesianChart.Series = distanceSeriesCollection;
                                distanceCartesianChart.AxisX.Clear();
                                distanceCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                distanceCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region CaloriesGraph
                            var caloriesSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.CaloriesCollection);

                            if (caloriesSeriesCollection != null && caloriesSeriesCollection.Any())
                            {
                                caloriesCartesianChart.Series.Clear();
                                caloriesCartesianChart.Series = caloriesSeriesCollection;
                                caloriesCartesianChart.AxisX.Clear();
                                caloriesCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                caloriesCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region BMIGraph
                            var bmiSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.BmiCollection);

                            if (bmiSeriesCollection != null && bmiSeriesCollection.Any())
                            {
                                bmiCartesianChart.Series.Clear();
                                bmiCartesianChart.Series = bmiSeriesCollection;
                                bmiCartesianChart.AxisX.Clear();
                                bmiCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                bmiCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region EffortGraph
                            var effortSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.EffortCollection);

                            if (effortSeriesCollection != null && effortSeriesCollection.Any())
                            {
                                effortCartesianChart.Series.Clear();
                                effortCartesianChart.Series = effortSeriesCollection;
                                effortCartesianChart.AxisX.Clear();
                                effortCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                effortCartesianChart.Series.Clear();
                            }
                            #endregion

                        }
                    }
                }
            }
            else
            {
                var userMappingCollection = UserMappingData.Get();
                if (userMappingCollection.Any())
                {
                    foreach (var userMapping in userMappingCollection)
                    {
                        var userStatsPair = Common.ConvertToUserStatsPair(DailyStatusData.GetById(userMapping.UserId));
                        if (userStatsPair != null)
                        {
                            #region DurationGraph
                            var durationSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.DurationCollection);

                            if (durationSeriesCollection != null && durationSeriesCollection.Any())
                            {
                                durationCartesianChart.Series.Clear();
                                durationCartesianChart.Series = durationSeriesCollection;
                                durationCartesianChart.AxisX.Clear();
                                durationCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                durationCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region DistanceGraph
                            var distanceSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.DistanceCollection);

                            if (distanceSeriesCollection != null && distanceSeriesCollection.Any())
                            {
                                distanceCartesianChart.Series.Clear();
                                distanceCartesianChart.Series = distanceSeriesCollection;
                                distanceCartesianChart.AxisX.Clear();
                                distanceCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                distanceCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region CaloriesGraph
                            var caloriesSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.CaloriesCollection);

                            if (caloriesSeriesCollection != null && caloriesSeriesCollection.Any())
                            {
                                caloriesCartesianChart.Series.Clear();
                                caloriesCartesianChart.Series = caloriesSeriesCollection;
                                caloriesCartesianChart.AxisX.Clear();
                                caloriesCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                caloriesCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region BMIGraph
                            var bmiSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.BmiCollection);

                            if (bmiSeriesCollection != null && bmiSeriesCollection.Any())
                            {
                                bmiCartesianChart.Series.Clear();
                                bmiCartesianChart.Series = bmiSeriesCollection;
                                bmiCartesianChart.AxisX.Clear();
                                bmiCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                bmiCartesianChart.Series.Clear();
                            }
                            #endregion

                            #region EffortGraph
                            var effortSeriesCollection =
                                Common.GetSeriesCollection(userMapping.FullName, userStatsPair.EffortCollection);

                            if (effortSeriesCollection != null && effortSeriesCollection.Any())
                            {
                                effortCartesianChart.Series.Clear();
                                effortCartesianChart.Series = effortSeriesCollection;
                                effortCartesianChart.AxisX.Clear();
                                effortCartesianChart.AxisX.Add(Common.GetDateTimeAxis());
                            }
                            else
                            {
                                effortCartesianChart.Series.Clear();
                            }
                            #endregion

                        }
                    }
                }
            }
        }
    }
}
