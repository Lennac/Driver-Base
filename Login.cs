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
    public partial class Login : Form
    {
        public string userLogin { get; set; }
        List<user> userList = new List<user>();
        string accountsDatabase = @"accounts.txt";

        public Login()
        {
            InitializeComponent();
        }


        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (var form = new NewAccount())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string username = form.returnUsername;
                    string password = form.returnPassword;

                    if (attemptLogin(username, password))
                    {
                        userLogin = username;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    
                }
                
            }
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (attemptLogin(txtUser.Text, txtPassword.Text))
            {
                userLogin = txtUser.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("This account does not exist in our database, please check your username/password, create an account or log in as a guest.", "Invalid Login");
                txtPassword.Clear();
                txtUser.Clear();
            }
        }

        private bool attemptLogin(string a, string b)
        {
            string username = a;
            string pass = b;

            List<string> userLines = File.ReadAllLines(accountsDatabase).ToList();

            foreach (var account in userLines)
            {
                string[] entries = account.Split('/');

                if (username == entries[0] && pass == entries[1])
                {
                    return true;
                }
            }
            return false;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            userLogin = "Guest";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
