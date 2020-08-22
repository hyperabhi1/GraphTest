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

        private void userMappingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userMappingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserMapping' table. You can move, or remove it, as needed.
            this.userMappingTableAdapter.Fill(this.healthStatsDataSet.UserMapping);

        }

        private async void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ClickEffect();
            userMappingListBox.DataSource = this.userMappingTableAdapter.GetData();
            userProfileDataGridView.DataSource = this.userProfileTableAdapter.GetData();
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
                buttonEdit.Visible = true;
        }
    }
}
