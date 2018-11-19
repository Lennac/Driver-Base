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
    public partial class Form1 : Form
    {
        // create list of car objects
        // create list of user objects
        public Form1()
        {
            // load users from file - store in list
            // load cars stored from file - store in list

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            Login a = new Login();
            if (a.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
