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
using GraphExperiment.DAL;
using GraphExperiment.Data;
using GraphExperiment.Models;
using static GraphExperiment.Constants;

namespace GraphExperiment
{
    public partial class Dashboard : Form
    {
        private static string UserId = String.Empty;
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
            userMappingListBox.DataSource = new BindingSource(new BindingList<string>(UserMappingData.Get().Select(x=>x.UserId).ToList()), null);
            //userProfileDataGridView.DataSource = new BindingSource(new BindingList<UserProfile>(UserProfileData.Get()), null);
            //latestProfileDataGridView.DataSource = new BindingSource(new BindingList<LatestProfile>(LatestProfileData.Get()), null);
            //dailyStatusUpdateDataGridView.DataSource = new BindingSource(new BindingList<DailyStatus>(DailyStatusData.Get()), null);
            userMappingListBox.Refresh();
            //userProfileDataGridView.Refresh();
            //latestProfileDataGridView.Refresh();
            //dailyStatusUpdateDataGridView.Refresh();
            HideDailyStatusControls();
            return;
        }

        private async void ClickEffect()
        {
            pictureBoxRefresh.BorderStyle = BorderStyle.FixedSingle;
            Thread.Sleep(50);
            pictureBoxRefresh.BorderStyle = BorderStyle.Fixed3D;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserId))
            {
                var editUserForm = new EditUser(UserId);
                editUserForm.ShowDialog();
                editUserForm.ShowIcon = true;
                editUserForm.ShowInTaskbar = true;
            }
        }

        private void userMappingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userId = userMappingListBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(userId))
            {
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
                dailyStatusUpdateButton.Visible = true;
                dailyStatusUpdateButton.Text = HiWannaUpdateTodayStatus.Replace("_", userId);
                UserId = userId;

                var latestProfile = LatestProfileData.GetById(UserId).FirstOrDefault();
                heightNumericUpDown.Value = (decimal)latestProfile.Height;
                weightNumericUpDown.Value = (decimal)latestProfile.Weight;

                distanceNumericUpDown.Value = 0;
                durationNumericUpDown.Value = 0;
                caloriesNumericUpDown.Value = 0;
            }
            else
            {
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
                dailyStatusUpdateButton.Visible = false;
                UserId = String.Empty;
                dailyStatusUpdateButton.Text = "??????????????????????????????????";


                heightNumericUpDown.Value = 0;
                weightNumericUpDown.Value = 0;
                distanceNumericUpDown.Value = 0;
                durationNumericUpDown.Value = 0;
                caloriesNumericUpDown.Value = 0;
            }
            HideDailyStatusControls();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(DeleteVerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes) &&
                (MessageBox.Show(Delete2VerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes))
            {
                if (!string.IsNullOrEmpty(UserId))
                {
                    try
                    {
                        UserProfileData.Delete(UserId);
                        UserMappingData.Delete(UserId);
                        LatestProfileData.Delete(UserId);
                        DailyStatusData.Delete(UserId);
                        MessageBox.Show(UserDeleted, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!(Math.Abs((double)distance) > 0))
                {
                    MessageBox.Show(InvalidDistance, Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LatestProfileData.Update(new LatestProfile() { UserId = UserId, Height = height, Age = 0, Weight = weight });
                DailyStatusData.Insert(new DailyStatus() { UserId = UserId, Height = height, Weight = weight, Time = DateTime.Now, Distance = distance, Duration = duration, Calories = calories });
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
        }
    }
}
