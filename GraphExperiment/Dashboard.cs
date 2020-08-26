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
            // TODO: This line of code loads data into the 'healthStatsDataSet.LatestProfile' table. You can move, or remove it, as needed.
            this.latestProfileTableAdapter.Fill(this.healthStatsDataSet.LatestProfile);
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

            var userId = userMappingListBox.SelectedValue as string;
            if (!string.IsNullOrEmpty(userId))
            {
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(DeleteVerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                 DialogResult.Yes) &&
                (MessageBox.Show(Delete2VerificationMessage, Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                 DialogResult.Yes))
            {
                var userId = userMappingListBox.SelectedValue as string;
                if (!string.IsNullOrEmpty(userId))
                {
                }
            }
        }

        private void latestProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.latestProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }
    }
}
