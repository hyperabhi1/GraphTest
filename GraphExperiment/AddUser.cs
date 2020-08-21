using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GraphExperiment.Constants;

namespace GraphExperiment
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void userProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }

        private void userProfileBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.userProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);
            genderComboBox.SelectedItem = Male;
        }

        private void userProfileBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.userProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }

        private void userProfileBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.userProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UserProfileTableAdapter.Insert(userIdTextBox.Text, firstNameTextBox.Text,
                lastNameTextBox.Text, (int) ageNumericUpDown.Value, (double) heightNumericUpDown.Value,
                (double) weightNumericUpDown.Value, genderComboBox.SelectedText[0].ToString());
            try
            {
                this.userProfileBindingSource.EndEdit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,Error,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);
        }
    }
}
