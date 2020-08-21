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

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserMapping' table. You can move, or remove it, as needed.
            this.userMappingTableAdapter.Fill(this.healthStatsDataSet.UserMapping);
            // TODO: This line of code loads data into the 'healthStatsDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.healthStatsDataSet.UserProfile);
            
            genderComboBox.SelectedItem = Male;
            userIdTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = string.Empty;
            ageNumericUpDown.Value = heightNumericUpDown.Value = weightNumericUpDown.Value = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidData())
                {
                    this.tableAdapterManager.UserProfileTableAdapter.Insert(userIdTextBox.Text, firstNameTextBox.Text,
                        lastNameTextBox.Text, (int) ageNumericUpDown.Value, (double) heightNumericUpDown.Value,
                        (double) weightNumericUpDown.Value, genderComboBox.SelectedItem.ToString()[0].ToString());
                    this.userProfileBindingSource.EndEdit();
                    this.tableAdapterManager.UserMappingTableAdapter.Insert(userIdTextBox.Text, firstNameTextBox.Text);
                    this.userMappingBindingSource.EndEdit();
                    MessageBox.Show(UserAdded, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(InvalidData, Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidData()
        {
            if(!string.IsNullOrEmpty(userIdTextBox.Text))
                if (!string.IsNullOrEmpty(firstNameTextBox.Text))
                    if (!string.IsNullOrEmpty(lastNameTextBox.Text))
                        if ((int)ageNumericUpDown.Value != 0)
                            if (Math.Abs((double)ageNumericUpDown.Value) > 0)
                                if (Math.Abs((double) weightNumericUpDown.Value) > 0)
                                    return true;
            return false;
        }
    }
}
