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

namespace GraphExperiment
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            pictureBoxRefresh.BorderStyle = BorderStyle.FixedSingle;
            Thread.Sleep(50);
            pictureBoxRefresh.BorderStyle = BorderStyle.Fixed3D;
            ReloadData();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            userMappingDataGridView.DataSource = new BindingSource(new BindingList<UserMapping>(UserMappingData.Get()), null);
            userProfilesDataGridView.DataSource = new BindingSource(new BindingList<UserProfile>(UserProfileData.Get()), null);
            latestProfileDataGridView.DataSource = new BindingSource(new BindingList<LatestProfile>(LatestProfileData.Get()), null);
            dailyStatusDataGridView.DataSource = new BindingSource(new BindingList<DailyStatus>(DailyStatusData.Get()), null);
            userMappingDataGridView.Refresh();
            userProfilesDataGridView.Refresh();
            latestProfileDataGridView.Refresh();
            dailyStatusDataGridView.Refresh();
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            UnHideDeleteControls();
            deleteRecordButton.Visible = false;
        }

        private void HideDeleteControls()
        {
            userIdTextBox.Visible = false;
            specifyTimeDateTimePicker.Visible = false;
            cancelButton.Visible = false;
            deleteButton.Visible = false;
        }
        private void UnHideDeleteControls()
        {
            userIdTextBox.Visible = true;
            specifyTimeDateTimePicker.Visible = true;
            cancelButton.Visible = true;
            deleteButton.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            HideDeleteControls();
            deleteRecordButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DailyStatusData.Delete(userIdTextBox.Text, specifyTimeDateTimePicker.Value);
                MessageBox.Show(Constants.RecordDeleted,  Constants.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Constants.DailyStatus + Constants.ColonSeparator + exception.Message, Constants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
