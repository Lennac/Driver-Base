using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Mockup
{
    public partial class SearchHistory : Form
    {
        string accountsDatabase = @"accounts.txt";

        public SearchHistory(string a)
        {
            InitializeComponent();
            txtUser.Text = a;

            //Parses for the account holder
            List<string> info = File.ReadAllLines(accountsDatabase).ToList();
            foreach (string line in info)
            {
                string [] account = line.Split('/');
                if (account[0]==a) //account is found
                {
                    //Adds search info if there is any
                    for (int i =3;i<account.Length;i++)
                    {
                        txtSearchInfo.Text += account[i]+"\r";
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
