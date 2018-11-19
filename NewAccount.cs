using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mockup
{
    public partial class NewAccount : Form
    {
        public string returnUsername { get; set; }
        public string returnPassword { get; set; }

        public NewAccount()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string account = txtNewUsername.Text + "/" + txtNewUserPassword.Text + "/" + txtNewUserEmail.Text;
            File.AppendAllText(@"accounts.txt", Environment.NewLine + account);
            this.returnUsername = txtNewUsername.Text;
            this.returnPassword = txtNewUserPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
