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
        bool flag1=true;
        bool flag2=true;
        bool flag3 = true;
        bool flag4 = true;
        public NewAccount()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string account = txtNewUsername.Text + "/" + txtNewUserPassword.Text + "/" + txtNewUserEmail.Text;
            File.AppendAllText(@"accounts.txt", Environment.NewLine + account);
            File.Create(txtNewUsername.Text + ".txt");
            this.returnUsername = txtNewUsername.Text;
            this.returnPassword = txtNewUserPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        

        private void txtNewUsername_Leave(object sender, EventArgs e)
        {
            // check accounts.txt for matching username
            btnSubmit.Enabled = false;
            errorProvider1.Clear();
            flag1 = false;
            List<string> userLines = File.ReadAllLines(@"accounts.txt").ToList();
            foreach (string line in userLines)
            {
                string[] entries = line.Split('/');
                if (txtNewUsername.Text==entries[0])
                {
                    errorProvider1.SetError(txtNewUsername, "You have the same username as another user");
                    flag1 = true;
                }
            }
            
            if (txtNewUsername.Text=="")
            {
                errorProvider1.SetError(txtNewUsername, "Usernames can't be blank");
                flag1 = true;
            }
            else if (txtNewUsername.Text.Contains('/')==true)
            {
                errorProvider1.SetError(txtNewUsername, "Please do not include '/' in your username");
                flag1 = true;
            }
            else if (flag1==false)
            {
                isValidated();
            }
        }

        private void txtNewUserEmail_Leave(object sender, EventArgs e)
        {
            // check accounts.txt for matching e-mail in file
            errorProvider2.Clear();
            btnSubmit.Enabled = false;
            flag2 = false;
            List<string> userLines = File.ReadAllLines(@"accounts.txt").ToList();
            foreach (string line in userLines)
            {
                string[] entries = line.Split('/');
                if (txtNewUserEmail.Text == entries[2])
                {
                    errorProvider2.SetError(txtNewUserEmail, "You have the same email as another user");
                    flag2 = true;
                }
            }

            if (txtNewUserEmail.Text == "")
            {
                errorProvider2.SetError(txtNewUserEmail, "Emails can't be blank");
                flag2 = true;
            }
            else if (txtNewUserEmail.Text.Contains('/')==true)
            {
                errorProvider2.SetError(txtNewUserEmail, "Please don't include '/' in your email");
                flag2 = true;
            }
            else if (flag2 == false)
            {
                isValidated();
            }
        }

        private void txtNewUserConfirmPass_Leave(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            errorProvider4.Clear();
            flag4 = false;
            if (txtNewUserPassword.Text != txtNewUserConfirmPass.Text)
            {
                flag4 = true;
                errorProvider4.SetError(txtNewUserConfirmPass, "The Passwords don't match");
            }
            else
            {
                isValidated();
            }
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtNewUsername.Text=="")
            {
                btnSubmit.Enabled = false;
            }   
        }

        private void txtNewUserPassword_Leave(object sender, EventArgs e)
        {
            errorProvider3.Clear();
            flag3 = false;

            if (txtNewUserPassword.Text == "")
            {
                errorProvider3.SetError(txtNewUserPassword, "Passwords can't be blank");
                flag3 = true;
            }
            else if (txtNewUserPassword.Text!="")
            {
                foreach (char c in txtNewUserPassword.Text)
                {
                    if (char.IsNumber(c)!=true&&char.IsLetter(c)!=true)
                    {
                        errorProvider3.SetError(txtNewUserPassword,"Passwords may not contain special characters");
                        flag3 = true;
                    }
                }
            }
            else if (flag3 == false)
            {
                isValidated();
            }
        }

        private void isValidated()
        {
            if (flag1==false&&flag2==false&&flag3==false&&flag4==false)
            {
                btnSubmit.Enabled = true;
            }
        }

        private void txtNewUserConfirmPass_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            errorProvider4.Clear();
            flag4 = false;
            if (txtNewUserPassword.Text != txtNewUserConfirmPass.Text)
            {
                flag4 = true;
                errorProvider4.SetError(txtNewUserConfirmPass, "The Passwords don't match");
            }
            else
            {
                isValidated();
            }
        }

        private void txtNewUserPassword_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        private void txtNewUserEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtNewUsername.Text=="")
            {
                btnSubmit.Enabled = false;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }
    }
}
