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
    public partial class EditUser : Form
    {
        private readonly string _userId;
        private readonly HealthStatsDataSet.UserProfileRow _originalUserProfile;
        public EditUser(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _originalUserProfile = this.userProfileTableAdapter.GetData().FirstOrDefault(x => x.UserId == _userId);
        }

        private void userProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.healthStatsDataSet);

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserMapping' table. You can move, or remove it, as needed.
            this.userMappingTableAdapter.Fill(this.healthStatsDataSet.UserMapping);
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (this.IsValidData())
            {
                var firstName = firstNameTextBox.Text.ToUpper();
                var lastName = lastNameTextBox.Text.ToUpper();
                int age = (int)ageNumericUpDown.Value;
                double height = (double)Math.Round(heightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                double weight = (double)Math.Round(weightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                string gender = genderComboBox.Text[0].ToString();

                try
                {
                    this.tableAdapterManager.UserProfileTableAdapter.Update(firstName, lastName, age, height, weight, gender,
                        _originalUserProfile.UserId, _originalUserProfile.FirstName, _originalUserProfile.LastName, 
                        _originalUserProfile.Age, _originalUserProfile.Height, _originalUserProfile.Weight, _originalUserProfile.Gender);
                    this.userProfileBindingSource.EndEdit();

                    this.tableAdapterManager.UserMappingTableAdapter.Update(_userId,firstName,_originalUserProfile.UserId, _originalUserProfile.FirstName);
                    this.userMappingBindingSource.EndEdit();

                    if (MessageBox.Show(UserUpdated, Information, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(UserProfile + ColonSeparator + exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(InvalidData, Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool IsValidData()
        {
            if (!string.IsNullOrEmpty(firstNameTextBox.Text))
                if (!string.IsNullOrEmpty(lastNameTextBox.Text))
                    if ((int)ageNumericUpDown.Value != 0)
                        if (Math.Abs((double)ageNumericUpDown.Value) > 0)
                            if (Math.Abs((double)weightNumericUpDown.Value) > 0)
                                if (!string.IsNullOrEmpty(genderComboBox.Text[0].ToString())
                                   && genderComboBox.Text[0].ToString().Length == 1)
                                    return true;
            return false;
        }
    }
}
