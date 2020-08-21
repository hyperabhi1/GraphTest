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
    }
}
