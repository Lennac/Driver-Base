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
    public partial class listInfo : Form
    {
        public string listReference { get; set; }
        string listingsDatabase = @"listings.txt";
        string contactInfo = "";
        string activeUser = "";
        string img1 = "", img2 = "", img3 = "", img4 = "", img5 = "";
        int imageCount = 1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageCount == 1)
            {
                placeImage(img2);
                imageCount++;
                txtImageCount.Text = "Image " + imageCount + "/5";
                btnPrev.Enabled = true;
            }
            else if (imageCount == 2)
            {
                placeImage(img3);
                imageCount++;
                txtImageCount.Text = "Image " + imageCount + "/5";
            }
            else if (imageCount == 3)
            {
                placeImage(img4);
                imageCount++;
                txtImageCount.Text = "Image " + imageCount + "/5";
            }
            else if (imageCount == 4)
            {
                placeImage(img5);
                imageCount++;
                txtImageCount.Text = "Image " + imageCount + "/5";
                btnNext.Enabled = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (imageCount == 5)
            {
                placeImage(img4);
                imageCount--;
                txtImageCount.Text = "Image " + imageCount + "/5";
                btnNext.Enabled = true;
            }
            else if (imageCount == 4)
            {
                placeImage(img3);
                imageCount--;
                txtImageCount.Text = "Image " + imageCount + "/5";
            }
            else if (imageCount == 3)
            {
                placeImage(img2);
                imageCount--;
                txtImageCount.Text = "Image " + imageCount + "/5";
            }
            else if (imageCount == 2)
            {
                placeImage(img1);
                imageCount--;
                txtImageCount.Text = "Image " + imageCount + "/5";
                btnPrev.Enabled = false;
            }
        }

        private void btnEditListing_Click(object sender, EventArgs e)
        {
            using (var form = new addListing(txtAccOwner.Text))
            {
                form.txtMileage.Text = txtViewMileage.Text;
                form.txtModel.Text = txtViewModel.Text;
                form.txtPrice.Text = txtViewPrice.Text;
                form.cbMake.Text = txtViewMake.Text;
                form.cbTransmission.Text = txtViewTrans.Text;
                form.cbColour.Text = txtViewColour.Text;
                form.cbYear.Text = txtViewYear.Text;
                if (form.ShowDialog()==DialogResult.OK)
                {
                    //Feeds the info back into the info form
                    txtViewMileage.Text = form.txtMileage.Text;
                    txtViewMake.Text = form.cbMake.Text;
                    txtViewModel.Text = form.txtModel.Text;
                    txtViewPrice.Text = form.txtPrice.Text;
                    txtViewTrans.Text = form.cbTransmission.Text;
                    txtViewColour.Text = form.cbColour.Text;
                    txtViewYear.Text = form.cbYear.Text;
                    //Parses the car list for the current listing and deletes it due to there being a new listing (info is different supposidly)
                    List<string> carLines = File.ReadLines(listingsDatabase).ToList();
                    int toDelete = 0;
                    int ctr = 0;
                    foreach (string line in carLines)
                    {
                        string[] entries = line.Split('/');
                        if (entries[8]==listReference)
                        {
                            toDelete = ctr;
                        }
                        ctr++;
                    }
                    carLines.Remove(carLines[toDelete]);
                    File.WriteAllLines(@"listings.txt",carLines);
                    this.Close();
                }
            }
        }

        private void cbFavourite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFavourite.Checked == true)
            {
                if (CheckFavourites())
                {
                    // If the favourite already appears on file, do not write again.
                }
                else // If not does appear in file, write to favourites.
                {
                    //Parse listings for the car and Write it to their favourites
                    List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
                    string thisCar = "";
                    int ctr = 0;
                    foreach (string line in carLines)
                    {
                        string[] entries = line.Split('/');
                        if (entries[8] == listReference)
                        {
                            thisCar = carLines[ctr];
                        }
                        ctr++;
                    }
                    File.AppendAllText(activeUser + ".txt", thisCar + Environment.NewLine);
                }
            }
            else
            {
                //Delete it off their favourites
                List<string> carLines = File.ReadAllLines(activeUser + ".txt").ToList();
                int toDel = 0;
                int ctr = 0;
                foreach (string line in carLines)
                {
                    if (line != "")
                    {
                        string[] entries = line.Split('/');
                        if (entries[8] == listReference)
                        {
                            toDel = ctr;
                        }
                    }
                    ctr++;
                }
                //Same with this
                carLines.Remove(carLines[toDel]);
                File.WriteAllLines(activeUser + ".txt", carLines);
            }
        }

        public listInfo(string a, string b) // a gets car, b gets active user
        {
            InitializeComponent();
            listReference = a;
            activeUser = b;

            List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
            carListing listedCar = new carListing();

            foreach (string line in carLines)
            {
                string[] entries = line.Split('/');

                if (entries[8] == listReference)
                {
                    listedCar.make = entries[0];
                    listedCar.model = entries[1];
                    listedCar.year = Int32.Parse(entries[2]);
                    listedCar.kilometers = Int32.Parse(entries[3]);
                    listedCar.colour = entries[4];
                    listedCar.transmission = entries[5];
                    listedCar.price = Int32.Parse(entries[6]);
                    listedCar.owner = entries[7];
                    listedCar.listDate = entries[8];
                    img1 = entries[9];
                    img2 = entries[10];
                    img3 = entries[11];
                    img4 = entries[12];
                    img5 = entries[13];
                    break;
                }
            }
            txtAccOwner.Text = listedCar.owner;
            contactInfo = listedCar.owner;
            txtViewMake.Text = listedCar.make;
            txtViewModel.Text = listedCar.model;
            txtViewYear.Text = listedCar.year.ToString();
            txtViewMileage.Text = listedCar.kilometers.ToString();
            txtViewColour.Text = listedCar.colour;
            txtViewTrans.Text = listedCar.transmission;
            txtViewPrice.Text = listedCar.price.ToString();

            placeImage(img1);
            txtImageCount.Text = "Image " + imageCount + "/5";

            if (b == txtAccOwner.Text)
            {
                // show edit/modify buttons here
                btnEditListing.Visible = true;
                btnContact.Visible = false;
                cbFavourite.Visible = false;
                cbSold.Visible = true;
                cbDelete.Visible = true;
            }
            if (b == "Guest")
            {
                cbFavourite.Visible = false;
            }
            else
            {
                cbFavourite.Checked = CheckFavourites();
            }

        }

        private void listInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbSold.Checked == true || cbDelete.Checked == true)
            {
                List<string> carLines = File.ReadAllLines(listingsDatabase).ToList();
                List<string> updateList = new List<string>();

                foreach (string line in carLines)
                {
                    string[] entries = line.Split('/');
                    if (entries[8] != listReference)
                    {
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
                        allocateCars.img1 = entries[9];
                        allocateCars.img2 = entries[10];
                        allocateCars.img3 = entries[11];
                        allocateCars.img4 = entries[12];
                        allocateCars.img5 = entries[13];
                        allocateCars.visible = entries[14];
                        updateList.Add($"{ allocateCars.make }/{ allocateCars.model }/{ allocateCars.year }/{allocateCars.kilometers}/{allocateCars.colour}/" +
                            $"{allocateCars.transmission}/{allocateCars.price}/{allocateCars.owner}/{allocateCars.listDate}/{allocateCars.img1}/{allocateCars.img2}/" +
                            $"{allocateCars.img3}/{allocateCars.img4}/{allocateCars.img5}/{allocateCars.visible}");
                    }
                }

                File.WriteAllLines(listingsDatabase, updateList);
            }
        }

        private bool CheckFavourites()
        {
            bool favourite = false;
            List<string> carLines = File.ReadAllLines(activeUser + ".txt").ToList();
            carListing listedCar = new carListing();

            foreach (string line in carLines)
            {
                string[] entries = line.Split('/');

                if (entries[8] == listReference)
                {
                    favourite = true;
                }
                else
                {
                    favourite = false;
                }
            }

            return favourite;
        }

        private void placeImage(string a)
        {
            imgView.Image = null;
            imgView.Update();
            if (a == "")
            {
                return;
            }
            else
            {
                Image listingImage = Image.FromFile(a);
                imgView.Image = listingImage;
                imgView.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            string contacter = "";
            string contactee = "";
            string password = "";
            List<string> accounts = File.ReadAllLines(@"accounts.txt").ToList();
            foreach (string line in accounts)
            {
                string[] entries = line.Split('/');
                if (entries[0]==activeUser)
                {
                    contacter = entries[2];
                    password = entries[1];
                }
                else if (entries[0]==txtAccOwner.Text)
                {
                    contactee = entries[2];
                }
            }
            using (Form c = new Contact(contacter, contactee, password))
            {
                c.ShowDialog();
            }
        }
    }
}
