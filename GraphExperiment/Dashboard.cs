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
        }

        private async void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ClickEffect();
            userMappingListBox.DataSource = new BindingSource(new BindingList<UserMapping>(UserMappingData.Get()), null);
            userProfileDataGridView.DataSource = new BindingSource(new BindingList<UserProfile>(UserProfileData.Get()), null);
            latestProfileDataGridView.DataSource = new BindingSource(new BindingList<LatestProfile>(LatestProfileData.Get()), null);
            userMappingListBox.Refresh();
            userProfileDataGridView.Refresh();
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
            var userId = userMappingListBox.SelectedValue as string;
            if (!string.IsNullOrEmpty(userId))
            {
                var editUserForm = new EditUser(userId);
                editUserForm.ShowDialog();
                editUserForm.ShowIcon = true;
                editUserForm.ShowInTaskbar = true;
            }
        }

        private void userMappingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userMapping = userMappingListBox.SelectedItems[0] as UserMapping;
            if (userMapping != null && !string.IsNullOrEmpty(userMapping.UserId))
            {
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(DeleteVerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes) &&
                (MessageBox.Show(Delete2VerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes))
            {
                var userMapping = userMappingListBox.SelectedItems[0] as UserMapping;
                if (userMapping != null && !string.IsNullOrEmpty(userMapping.UserId))
                {
                    try
                    {
                        UserProfileData.Delete(userMapping.UserId);
                        UserMappingData.Delete(userMapping.UserId);
                        LatestProfileData.Delete(userMapping.UserId);
                        DailyStatusData.Delete(userMapping.UserId);
                        MessageBox.Show(UserDeleted, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(Constants.UserProfile + ColonSeparator + exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
