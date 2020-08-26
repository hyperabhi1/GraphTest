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
using static GraphExperiment.Constants;

namespace GraphExperiment
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserMapping' table. You can move, or remove it, as needed.
            this.userMappingTableAdapter.Fill(this.healthStatsDataSet.UserMapping);
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);

            genderComboBox.SelectedItem = M;
            userIdTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = string.Empty;
            ageNumericUpDown.Value = heightNumericUpDown.Value = weightNumericUpDown.Value = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.IsValidData())
            {
                var userId = userIdTextBox.Text.ToUpper();
                var firstName = firstNameTextBox.Text.ToUpper();
                var lastName = lastNameTextBox.Text.ToUpper();
                int age = (int)ageNumericUpDown.Value;
                double height = (double)Math.Round(heightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                double weight = (double)Math.Round(weightNumericUpDown.Value, 2, MidpointRounding.AwayFromZero);
                string gender = genderComboBox.Text[0].ToString();

                try
                {
                    UserProfileDAL.Insert(new UserProfile(){Age = age,LastName = lastName,UserId = userId, FirstName = firstName, Height = height, Weight = weight,Gender = gender});
                    
                    if (MessageBox.Show(UserAdded, Information, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(  Constants.UserProfile + ColonSeparator + exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(InvalidData, Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool IsValidData()
        {
            if (!string.IsNullOrEmpty(userIdTextBox.Text))
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
