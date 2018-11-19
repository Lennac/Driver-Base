using System;
using System.IO;
using System.Net.Mail;
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
    public partial class Form1 : Form
    {
        user activeUser = new user();
        List<user> userList = new List<user>();
        List<carListing> carList = new List<carListing>();

        string accountsDatabase = @"accounts.txt";
        string listingsDatabase = @"listings.txt";

        public Form1()
        {
            InitializeComponent();

            List<string> userLines = File.ReadAllLines(accountsDatabase).ToList(); // do we need this?

            foreach (string line in userLines)
            {
                string[] entries = line.Split('/');

                user allocateUser = new user();

                allocateUser.username = entries[0];
                allocateUser.password = entries[1];
                allocateUser.email = entries[2];
                userList.Add(allocateUser);
            }

            List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();

            foreach (string line in carLines)
            {
                string[] entries = line.Split('/');

                carListing allocateCars = new carListing();

                allocateCars.make = entries[0];
                allocateCars.model = entries[1];
                allocateCars.year = Int32.Parse(entries[2]);
                allocateCars.mileage = Int32.Parse(entries[3]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            using (var form = new Login())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string user = form.userLogin;
                    populateApplication(user);
                }
                else
                {
                    this.Dispose();
                    this.Close();
                }
            }
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populateApplication(string a)
        {
            activeUser.username = a;
            btnAccount.Text = a;
            lstCarObjects.Visible = false;

        }

        private void btnSellCar_Click(object sender, EventArgs e)
        {
            using (var form = new addListing())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                }
                else
                {
                    this.Dispose();
                    this.Close();
                }
            }
        }
    }
}
