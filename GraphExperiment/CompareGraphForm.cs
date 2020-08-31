using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExperiment
{
    public partial class CompareGraphForm : Form
    {
        private List<KeyValuePair<string,string>> _userIds;
        private List<string> _selectedUsers = new List<string>();
        public CompareGraphForm(List<KeyValuePair<string, string>> userIds)
        {
            InitializeComponent();
            _userIds = userIds;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Program.Dashboard.RefreshChart(_selectedUsers,true);
            this.Close();
        }

        private void CompareGraphForm_Load(object sender, EventArgs e)
        {
            CheckBox box;
            int i = 0;
            foreach (var user in _userIds)
            {
                box = new CheckBox();
                box.AutoSize = true;
                box.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
                box.Location = new System.Drawing.Point(16, 16+(i*27));//16, 16/43/70/97/124 - 27
                box.Name = $"{user.Key}";
                box.Size = new System.Drawing.Size(99, 21);
                box.TabIndex = i;
                box.Text = $"{user.Key} --> {user.Value}";
                box.UseVisualStyleBackColor = true;
                box.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                this.Controls.Add(box);
                i++;
            }
            okButton.Location = new System.Drawing.Point(233, 12 + ((i) * 27));
            this.MinimumSize = new System.Drawing.Size(306, 89 + ((i) * 27));
            this.MaximumSize = new System.Drawing.Size(306, 89 + ((i) * 27));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox) sender;
            if (checkbox.Checked)
                _selectedUsers.Add(checkbox.Name);
            else
                _selectedUsers.Remove(checkbox.Name);
        }
    }
}
