using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphExperiment.Data;
using GraphExperiment.Models;
using static GraphExperiment.Constants;

namespace GraphExperiment
{
    public partial class EditUser : Form
    {
        private readonly string _userId;
        private readonly UserProfile _originalUserProfile;
        public EditUser(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _originalUserProfile = UserProfileData.Get().FirstOrDefault(x => x.UserId == _userId);
            if (_originalUserProfile != null)
            {
                firstNameTextBox.Text = _originalUserProfile.FirstName;
                lastNameTextBox.Text = _originalUserProfile.LastName;
                ageNumericUpDown.Value = _originalUserProfile.Age; 
                heightNumericUpDown.Value = (decimal)_originalUserProfile.Height;
                weightNumericUpDown.Value = (decimal)_originalUserProfile.Weight;
            }
            else
            {
                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (this.IsValidData())
            {
                var firstName = char.ToUpper(firstNameTextBox.Text[0]) + firstNameTextBox.Text.Substring(1).ToLower();
                var lastName = char.ToUpper(lastNameTextBox.Text[0]) + lastNameTextBox.Text.Substring(1).ToLower();
                int age = (int)_originalUserProfile.Age;
                double height = (double)Math.Round(heightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                double weight = (double)Math.Round(weightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);

                try
                {
                    UserProfileData.Update(new UserProfile() { Age = age, LastName = lastName, UserId = _originalUserProfile.UserId, FirstName = firstName, Height = height, Weight = weight });
                    UserMappingData.Update(new UserMapping() { UserId = _originalUserProfile.UserId, FullName = $"{firstName} {lastName}" });
                    LatestProfileData.Update(new LatestProfile() { UserId = _originalUserProfile.UserId, LastName = lastName, Age = age, FirstName = firstName, Height = height, Weight = weight });

                    if (MessageBox.Show(UserUpdated, Information, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Constants.UserProfile + ColonSeparator + exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    return true;
            return false;
        }
    }
}
