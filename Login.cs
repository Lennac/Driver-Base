using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            NewAccount b = new NewAccount();
            if (b.ShowDialog() == DialogResult.OK)
            {
                // search list for matching username/password combination
            }
            else
            {
            }
        }
    }
}
