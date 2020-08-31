using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GraphExperiment.DAL;
using GraphExperiment.Data;
using GraphExperiment.Models;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using static GraphExperiment.Constants;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace GraphExperiment
{
    public partial class Dashboard : Form
    {
        private static string SelectedUserId = String.Empty;
        private static List<string> SelectedUsers = null;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser();
            addUserForm.ShowDialog();
            addUserForm.ShowIcon = true;
            addUserForm.ShowInTaskbar = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBoxRefresh_Click(null, null);
        }

        private async void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ClickEffect();
            DataTable dt = new DataTable();
            UserProfileData.Get().Select(x => x.UserId).ToList().ForEach(x => dt.Columns.Add(x));
            userProfilesDataGridView.DataSource = dt;
            userProfilesDataGridView.Refresh();
            SelectedUsers = UserProfileData.Get().Select(x => x.UserId).ToList();
            HideDailyStatusControls();
            dailyStatusUpdateButton.Text = HiWannaUpdateTodayStatus;
            RefreshChart();
            return;
        }

        private async void ClickEffect()
        {
            pictureBoxRefresh.BorderStyle = BorderStyle.FixedSingle;
            Thread.Sleep(50);
            pictureBoxRefresh.BorderStyle = BorderStyle.Fixed3D;
        }

        private async void DBClickEffect()
        {
            databasePictureBox.BorderStyle = BorderStyle.FixedSingle;
            Thread.Sleep(50);
            databasePictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedUserId))
            {
                var editUserForm = new EditUser(SelectedUserId);
                editUserForm.ShowDialog();
                editUserForm.ShowIcon = true;
                editUserForm.ShowInTaskbar = true;
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(DeleteVerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes) &&
                (MessageBox.Show(Delete2VerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes))
            {
                if (!string.IsNullOrEmpty(SelectedUserId))
                {
                    try
                    {
                        UserProfileData.Delete(SelectedUserId);
                        UserMappingData.Delete(SelectedUserId);
                        LatestProfileData.Delete(SelectedUserId);
                        DailyStatusData.Delete(SelectedUserId);
                        MessageBox.Show(UserDeleted, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SelectedUserId = string.Empty;
                        pictureBoxRefresh_Click(null, null);
                        SelectedIndexChangeEvent(SelectedUserId);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(Constants.UserProfile + ColonSeparator + exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dailyStatusUpdateButton_Click(object sender, EventArgs e)
        {
            UnHideDailyStatusControls();
            dailyStatusUpdateButton.Visible = false;
            detailGraphButton.Visible = false;
            cumulativeDetailGraphButton.Visible = false;
            compareGraphButton.Visible = false;
        }
        private void HideDailyStatusControls()
        {
            distanceLabel.Visible = false;
            distanceNumericUpDown.Visible = false;
            heightLabel.Visible = false;
            heightNumericUpDown.Visible = false;
            weightLabel.Visible = false;
            weightNumericUpDown.Visible = false;
            durationLabel.Visible = false;
            durationNumericUpDown.Visible = false;
            caloriesLabel.Visible = false;
            caloriesNumericUpDown.Visible = false;
            cancelButton.Visible = false;
            saveButton.Visible = false;
            setTimeButton.Visible = false;
            specifyTimeDateTimePicker.Visible = false;
        }
        private void UnHideDailyStatusControls()
        {
            distanceLabel.Visible = true;
            distanceNumericUpDown.Visible = true;
            heightLabel.Visible = true;
            heightNumericUpDown.Visible = true;
            weightLabel.Visible = true;
            weightNumericUpDown.Visible = true;
            durationLabel.Visible = true;
            durationNumericUpDown.Visible = true;
            caloriesLabel.Visible = true;
            caloriesNumericUpDown.Visible = true;
            cancelButton.Visible = true;
            saveButton.Visible = true;
            setTimeButton.Visible = true;
            specifyTimeDateTimePicker.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                double distance = (double)Math.Round(distanceNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                double height = (double)Math.Round(heightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                double weight = (double)Math.Round(weightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                int duration = (int)Math.Round(durationNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                double calories = (double)Math.Round(caloriesNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                DateTime time = specifyTimeDateTimePicker.Visible ? specifyTimeDateTimePicker.Value : DateTime.Now;
                if (!(Math.Abs((double)distance) > 0))
                {
                    MessageBox.Show(InvalidDistance, Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DailyStatusData.Insert(new DailyStatus() { UserId = SelectedUserId, Height = height, Weight = weight, Time = time, Distance = distance, Duration = duration, Calories = calories });
                LatestProfileData.Update(new LatestProfile() { UserId = SelectedUserId, Height = height, Age = 0, Weight = weight });
                MessageBox.Show(StatusUpdated, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Constants.UserProfile + ColonSeparator + exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.Visible = false;
            saveButton.Visible = false;
            HideDailyStatusControls();
            dailyStatusUpdateButton.Visible = true;
            detailGraphButton.Visible = true;
            cumulativeDetailGraphButton.Visible = true;
            compareGraphButton.Visible = true;
        }

        public void RefreshChart(List<string> userIds = null, bool isMoreThanOneUser = false)
        {
            if (isMoreThanOneUser && userIds != null && userIds.Count > 1)
            {
                SelectedUsers = userIds;
            }
            else if(isMoreThanOneUser)
            {
                SelectedUsers = UserProfileData.Get().Select(x => x.UserId).ToList();
                MessageBox.Show("Please select more than 1 user", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            var userMappingCollection = UserMappingData.Get(SelectedUsers);
            if (userMappingCollection.Any())
            {
                var dayConfig = Mappers.Xy<DateModel>()
                    .X(dateModel => dateModel.Time.Ticks / TimeSpan.FromSeconds(1).Ticks)
                    .Y(dateModel => dateModel.Value);
                var seriesCollection = new LiveCharts.SeriesCollection(dayConfig);
                foreach (var userMapping in userMappingCollection)
                {
                    var dailyStatusData = DailyStatusData.GetById(userMapping.UserId);
                    if (dailyStatusData.Any())
                    {
                        var chartValues = new ChartValues<DateModel>();
                        dailyStatusData.ForEach(x => chartValues.Add(new DateModel()
                        {
                            Time = x.Time,
                            Value = x.Weight
                        }));
                        LineSeries ls = new LineSeries()
                        {
                            Title = userMapping.FullName,
                            PointGeometrySize = 10,
                            Values = chartValues
                        };
                        seriesCollection.Add(ls);

                    }
                }
                if (seriesCollection.Any())
                {
                    weightCartesianChart.Series.Clear();
                    weightCartesianChart.Series = seriesCollection;
                    weightCartesianChart.AxisX.Clear();
                    weightCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("yyyy-MMM-dd")
                    });
                }
            }
        }

        private void databasePictureBox_Click(object sender, EventArgs e)
        {
            DBClickEffect();
            DatabaseForm dbForm = new DatabaseForm();
            dbForm.Show();
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            specifyTimeDateTimePicker.Visible = true;
            setTimeButton.Visible = false;
        }
        private void userProfilesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedIndexChangeEvent(userProfilesDataGridView.Columns[userProfilesDataGridView.SortedColumn.Index].HeaderText);
        }

        private void SelectedIndexChangeEvent(string userId)
        {
            try
            {
                if (!string.IsNullOrEmpty(userId))
                {
                    buttonEdit.Visible = true;
                    buttonDelete.Visible = true;
                    dailyStatusUpdateButton.Visible = true;
                    detailGraphButton.Visible = true;
                    cumulativeDetailGraphButton.Visible = true;
                    compareGraphButton.Visible = true;
                    dailyStatusUpdateButton.Text = HiWannaUpdateTodayStatus.Replace("_", userId.ToUpper());
                    SelectedUserId = userId;

                    var latestProfile = LatestProfileData.GetById(SelectedUserId).FirstOrDefault();
                    heightNumericUpDown.Value = (decimal)latestProfile.Height;
                    weightNumericUpDown.Value = (decimal)latestProfile.Weight;

                    distanceNumericUpDown.Value = 1;
                    durationNumericUpDown.Value = 1;
                    caloriesNumericUpDown.Value = 1;
                }
                else
                {
                    buttonEdit.Visible = false;
                    buttonDelete.Visible = false;
                    dailyStatusUpdateButton.Visible = false;
                    detailGraphButton.Visible = false;
                    cumulativeDetailGraphButton.Visible = false;
                    compareGraphButton.Visible = false;
                    SelectedUserId = String.Empty;
                    dailyStatusUpdateButton.Text = "";


                    heightNumericUpDown.Value = (decimal)0.01;
                    weightNumericUpDown.Value = 1;
                    distanceNumericUpDown.Value = 1;
                    durationNumericUpDown.Value = 1;
                    caloriesNumericUpDown.Value = 1;
                }
                HideDailyStatusControls();
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.UserProfile + ColonSeparator + e.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detailedGraphButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedUserId))
            {
                DetailedChartForm detailedChart = new DetailedChartForm(SelectedUserId);
                detailedChart.Show();
            }
        }

        private void cumulativeDetailGraphButton_Click(object sender, EventArgs e)
        {
            DetailedChartForm detailedChart = new DetailedChartForm(SelectedUsers);
            detailedChart.Show();
        }

        private void compareGraphButton_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string,string>> userMappings = new List<KeyValuePair<string, string>>();
            UserMappingData.Get(SelectedUsers).ForEach(x=>userMappings.Add(new KeyValuePair<string, string>(x.UserId,x.FullName)));
            if (userMappings.Count > 0)
            {
                CompareGraphForm userCheckListBox = new CompareGraphForm(userMappings);
                userCheckListBox.Show();
            }
        }
    }
}
