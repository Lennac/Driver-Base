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

        private void LoadCarDatabase()
        {
            List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();

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
                carList.Add(allocateCars);
            }
        }

        private void LoadUserDatabase()
        {
            List<string> userLines = File.ReadAllLines(accountsDatabase).ToList();

            foreach (string line in userLines)
            {
                string[] entries = line.Split('/');

                user allocateUser = new user();

                allocateUser.username = entries[0];
                allocateUser.password = entries[1];
                allocateUser.email = entries[2];
                userList.Add(allocateUser);
            }
        }

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnSearchForCar, "To search for a car, please enter the search criteria followed by a comma (ex: ford,manual).");
            toolTip1.SetToolTip(btnSellCar,"If you are logged in you may list a car for sale.");
            LoadCarDatabase();
            LoadUserDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            Login();
        }

        private void Login()
        {
            using (var form = new Login())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string user = form.userLogin;
                    populateApplication(user);
                    txtWelcome.Text = "Welcome to Driver-Base " + user + "!";
                    txtWelcome.Visible = true;
                    btnSellCar.Enabled = true;
                    if (activeUser.username!="Guest")
                    {
                        btnFavourites.Enabled = true;
                        btnSavedSearch.Enabled = true;
                    }
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
            DefaultListing();

            if (a == "Guest")
            {
                btnFavourites.ToolTipText ="Please log in to access favourite vehicles.";
                btnSavedSearch.ToolTipText = "Please log in to access your search history.";
                btnFavourites.Enabled = false;
                btnSavedSearch.Enabled = false;
                btnToggleAccount.Text = "Login";
            }
            else
            {
                btnFavourites.ToolTipText = "Click to display the cars you have favourited";
                btnSavedSearch.ToolTipText ="Click to display your search history";
                btnToggleAccount.Text = "Logout";
            }
        }

        private void btnSellCar_Click(object sender, EventArgs e)
        {
            if (activeUser.username != "Guest")
            {
                using (var form = new addListing(activeUser.username))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        DefaultListing();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must create an account or login to list a car for sale.");
                Login();
            }
            
        }

        private void btnSearchForCar_Click(object sender, EventArgs e)
        {
            //Determines how many search terms
            int ctr = 0;
            int ctr2 = 0;
            foreach (char c in txtSearch.Text)
            {
                if (c == ',')
                {
                    ctr++;
                }
            }
            string[] parameters = txtSearch.Text.Split(',');

            if (txtSearch.Text!="")
            {
                //If they searched for anything other than space add it to their account if they are logged in
                if (activeUser.username!="Guest")
                {
                    string g = "";
                    List<string> info = File.ReadAllLines(accountsDatabase).ToList();
                    List<string> users= new List<string>();
                    foreach (string s in info)
                    {
                        string[] account = s.Split('/');
                        if (account[0] == activeUser.username) //finds account
                        {
                            g = info[ctr2];
                            for (int i = 0; i < ctr + 1; i++) //adds search terms to info
                            {
                               g += '/' + parameters[i];
                            }
                            users.Add(g);
                        }
                        else
                        {
                            users.Add(s);
                        }
                        ctr2++;
                    }
                    File.WriteAllLines(@"accounts.txt", users);
                }
                
                

                //Shows only related cars
                gridCarList.Rows.Clear();
                gridCarList.Refresh();
                int row = 0;
                List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
                foreach (string line in carLines)
                {
                    string[] entries = line.Split('/');
                    for (int i = 0; i < ctr + 1; i++)
                    {
                        if (entries[0].ToLower()==parameters[i].ToLower() || entries[1].ToLower() == parameters[i].ToLower() || entries[2].ToLower() == parameters[i].ToLower() || entries[3].ToLower() == parameters[i].ToLower() || entries[4].ToLower() == parameters[i].ToLower() || entries[5].ToLower() == parameters[i].ToLower() || entries[6].ToLower() == parameters[i].ToLower() || entries[7].ToLower() == parameters[i].ToLower())
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
                            rows.Cells[3].Value = entries[0];
                            rows.Cells[4].Value = entries[1];
                            rows.Cells[5].Value = Int32.Parse(entries[2]);
                            rows.Cells[6].Value = Int32.Parse(entries[3]);
                            rows.Cells[7].Value = entries[4];
                            rows.Cells[8].Value = entries[5];
                            rows.Cells[9].Value = Int32.Parse(entries[6]);
                            rows.Cells[10].Value = entries[8];
                            row++;
                        }
                    }
                    
                }
                
            }
            else
            {
                DefaultListing();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (activeUser.username == "Guest")
            {
                Login();
            }
            else
            {
                using (var form = new AccountInfo(activeUser.username))
                {
                    form.ShowDialog();
                    DefaultListing();
                }
            }
        }

        private void btnToggleAccount_Click(object sender, EventArgs e)
        {
            if (btnToggleAccount.Text == "Login")
            {
                Login();
            }
            else
            {
                Application.Restart();
            }
        }

        private int GetTotalDatabaseSize()
        {
            var listCount = 0;
            using (var reader = File.OpenText(@"listings.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    listCount++;
                }
            }

            return listCount;
        }

        private void DefaultListing()
        {
            gridCarList.Rows.Clear();
            gridCarList.Refresh();
            int row = 0;
            List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
            foreach (string line in carLines)
            {
                
                string[] entries = line.Split('/');

                if (entries[14] == "Listed")
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
                    rows.Cells[3].Value = entries[0];
                    rows.Cells[4].Value = entries[1];
                    rows.Cells[5].Value = Int32.Parse(entries[2]);
                    rows.Cells[6].Value = Int32.Parse(entries[3]);
                    rows.Cells[7].Value = entries[4];
                    rows.Cells[8].Value = entries[5];
                    rows.Cells[9].Value = Int32.Parse(entries[6]);
                    rows.Cells[10].Value = entries[8];
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
                listInfo showCar = new listInfo(click.listDate, activeUser.username);
                var result = showCar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DefaultListing();
                    showCar.Close();
                }
                else
                {
                    showCar.Close();
                }
            }
        }

        private void btnSavedSearch_Click(object sender, EventArgs e)
        {
            using (var form = new SearchHistory(activeUser.username)) {
                form.ShowDialog();
            }
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {           
            if (File.Exists(activeUser.username+".txt")==true)
            {
                using (Form f = new FavsForm(activeUser.username))
                {
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please favourite some cars to show your favourites list!","No Favourites");
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchForCar.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // open help doc
            System.Diagnostics.Process.Start(@"user-manual.pdf");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DefaultListing();
        }
    }
}
