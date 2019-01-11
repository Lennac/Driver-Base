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
using System.Text.RegularExpressions;

namespace Project_Mockup
{
    public partial class AccountInfo : Form
    {
        string currentUser = "";
        string b = "";
        string listingsDatabase = @"listings.txt";
        string accountsDatabase = @"accounts.txt";
        List<carListing> carList = new List<carListing>();
        List<user> userList = new List<user>();

        public AccountInfo(string a)
        {
            //Finds the Email of the user and sets it to b
            List<String> info = File.ReadAllLines(accountsDatabase).ToList();

            foreach (string line in info)
            {
                string[] account = line.Split('/');
                if (account[0]==a)
                {
                    b =account[2];
                }
            }
            InitializeComponent();
            txtUsername.Text = a;
            txtUserEmail.Text = b;
            currentUser = a;
            SetUpGrid();
        }

        private void SetUpGrid()
        {
            //Sets the grid up based on the user's accountname (only their cars in the list)
            gridCarList.Rows.Clear();
            gridCarList.Refresh();
            int row = 0;
            List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
            foreach (string line in carLines)
            {
                string[] entries = line.Split('/');
                if (entries[7] == currentUser)
                {
                    gridCarList.Rows.Add();
                    DataGridViewRow rows = gridCarList.Rows[row];

                    string preview = entries[9];
                    Image listingImage = Image.FromFile(preview);

                    listingImage = listingImage.GetThumbnailImage(200, 100, null, IntPtr.Zero);

                    rows.Height = listingImage.Height;

                    carListing allocateCars = new carListing();
                    rows.Cells[1].Value = row + 1;
                    rows.Cells[2].Value = listingImage;
                    rows.Cells[3].Value = entries[14];
                    rows.Cells[4].Value = entries[0];
                    rows.Cells[5].Value = entries[1];
                    rows.Cells[6].Value = Int32.Parse(entries[2]);
                    rows.Cells[7].Value = Int32.Parse(entries[3]);
                    rows.Cells[8].Value = entries[4];
                    rows.Cells[9].Value = entries[5];
                    rows.Cells[10].Value = Int32.Parse(entries[6]);
                    rows.Cells[11].Value = entries[8];
                    row++;
                }

            }
        }
        
        private void gridCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
            List<carListing> currentSearch = new List<carListing>();

            foreach (string line in carLines)
            {
                string[] entries = line.Split('/');

                carListing allocateCars = new carListing();

                allocateCars.make = entries[0];
                allocateCars.model = entries[1];
                allocateCars.year = Int32.Parse(entries[2]);
                allocateCars.kilometers = Int32.Parse(entries[3]);
                allocateCars.colour = entries[4];
                allocateCars.transmission = entries[5];
                allocateCars.price = Int32.Parse(entries[6]);
                allocateCars.owner = entries[7];
                allocateCars.listDate = entries[8];
                currentSearch.Add(allocateCars);
            }

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var info = senderGrid.Rows[e.RowIndex].Cells["DateTime"].Value.ToString();
                carListing click = currentSearch.Find(x => x.listDate.Contains(info)); // THIS IS THE SEARCH
                // Open form for specific row
                listInfo showCar = new listInfo(click.listDate, currentUser);
                var result = showCar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    showCar.Close();
                    SetUpGrid();
                }
                else
                {
                    showCar.Close();
                    SetUpGrid();
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            string newEmail = Microsoft.VisualBasic.Interaction.InputBox("Type in your new e-mail to change it", "Account Edit", "email@email.com", -1, -1);
            while (newEmail.Contains('/') == true)
            {
                newEmail = Microsoft.VisualBasic.Interaction.InputBox("Please enter a valid e-mail", "Account Edit", "email@email.com", -1, -1);
            }
            if (newEmail!="")
            {
                string str = File.ReadAllText(accountsDatabase);
                str = str.Replace(txtUserEmail.Text, newEmail);
                File.WriteAllText(accountsDatabase, str);
                txtUserEmail.Text = newEmail;
            }
            
        }
    }
}
