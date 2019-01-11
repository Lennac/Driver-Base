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
    public partial class addListing : Form
    {
        string username = "";

        public addListing(string a)
        {
            // Get length/size of carList from file - keep all cars in list even after sale/de-listing (keep them stored for reference)
            // Use the length/size value to give each carListing a unique "ID" number that can be used as reference throughout the program
            InitializeComponent();

            username = a;
        }

        private int checkFlags()
        {
            int ctr = 0;
            if (cbMake.Text == "")
            {
                errorProvider1.SetError(cbMake, "Please select a Make from the drop down list");
                ctr++;
            }
            if (txtModel.Text == ""||txtModel.Text.Contains('/'))
            {
                errorProvider1.SetError(txtModel, "Please enter a car Model that does not have '/' in it");
                ctr++;
            }
            if (cbYear.Text == "")
            {
                errorProvider1.SetError(cbYear, "Please choose a year from the drop down list");
                ctr++;
            }
            if (cbColour.Text == "")
            {
                errorProvider1.SetError(cbColour, "Please choose a colour from the drop down list");
                ctr++;
            }
            if (txtMileage.Text == "")
            {
                ctr++;
                errorProvider1.SetError(txtMileage, "Please enter odometer reading in kilometers");
            }
            else
            {
                foreach (char c in txtMileage.Text)
                {
                    if (char.IsNumber(c) != true)
                    {
                        ctr++;
                        errorProvider1.SetError(txtMileage, "Please enter a number for the mileage");
                    }
                }
            }
            if (cbTransmission.Text == "")
            {
                errorProvider1.SetError(cbTransmission, "Please choose a transmission type from the drop down menu");
                ctr++;
            }
            if (txtPrice.Text == "")
            {
                ctr++;
                errorProvider1.SetError(txtPrice, "Please enter a price");
            }
            else
            {
                foreach (char c in txtPrice.Text)
                {
                    if (char.IsNumber(c) != true)
                    {
                        ctr++;
                        errorProvider1.SetError(txtPrice, "Please enter a number for the price");
                    }
                }
            }
            return ctr;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string listDate = DateTime.Now.ToString("h:mm:ss tt");
            errorProvider1.Clear();
            int ctr=checkFlags();
            
            if (ctr==0)
            {
                SaveCar(listDate);
            }

        }

        private void SaveCar(string a)
        {
            string listDate = a;
            string newCar = "";
            //Send this form the username of the main page so we can append it to the listing if they create one
            if (string.IsNullOrWhiteSpace(imgBox1.Text)) // No user uploaded image
            {
                newCar = cbMake.Text + "/" + txtModel.Text + "/" + cbYear.Text + "/" + txtMileage.Text + "/" + cbColour.Text + "/" + cbTransmission.Text + "/" + txtPrice.Text + "/" + username + "/" + listDate + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + "Listed";
            }
            else if (string.IsNullOrWhiteSpace(imgBox2.Text))
            {
                newCar = cbMake.Text + "/" + txtModel.Text + "/" + cbYear.Text + "/" + txtMileage.Text + "/" + cbColour.Text + "/" + cbTransmission.Text + "/" + txtPrice.Text + "/" + username + "/" + listDate + "/" + @"images\" + imgBox1.Text + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + "Listed";
            }
            else if (string.IsNullOrWhiteSpace(imgBox3.Text))
            {
                newCar = cbMake.Text + "/" + txtModel.Text + "/" + cbYear.Text + "/" + txtMileage.Text + "/" + cbColour.Text + "/" + cbTransmission.Text + "/" + txtPrice.Text + "/" + username + "/" + listDate + "/" + @"images\" + imgBox1.Text + "/" + @"images\" + imgBox2.Text + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + "Listed";
            }
            else if (string.IsNullOrWhiteSpace(imgBox4.Text))
            {
                newCar = cbMake.Text + "/" + txtModel.Text + "/" + cbYear.Text + "/" + txtMileage.Text + "/" + cbColour.Text + "/" + cbTransmission.Text + "/" + txtPrice.Text + "/" + username + "/" + listDate + "/" + @"images\" + imgBox1.Text + "/" + @"images\" + imgBox2.Text + "/" + @"images\" + imgBox3.Text + "/" + @"images\default.png" + "/" + @"images\default.png" + "/" + "Listed";
            }
            else if (string.IsNullOrWhiteSpace(imgBox5.Text))
            {
                newCar = cbMake.Text + "/" + txtModel.Text + "/" + cbYear.Text + "/" + txtMileage.Text + "/" + cbColour.Text + "/" + cbTransmission.Text + "/" + txtPrice.Text + "/" + username + "/" + listDate + "/" + @"images\" + imgBox1.Text + "/" + @"images\" + imgBox2.Text + "/" + @"images\" + imgBox3.Text + "/" + @"images\" + imgBox4.Text + "/" + @"images\default.png" + "/" + "Listed";
            }
            else
            {
                newCar = cbMake.Text + "/" + txtModel.Text + "/" + cbYear.Text + "/" + txtMileage.Text + "/" + cbColour.Text + "/" + cbTransmission.Text + "/" + txtPrice.Text + "/" + username + "/" + listDate + "/" + @"images\" + imgBox1.Text + "/" + @"images\" + imgBox2.Text + "/" + @"images\" + imgBox3.Text + "/" + @"images\" + imgBox4.Text + "/" + @"images\" + imgBox5.Text + "/" + "Listed";
            }

            File.AppendAllText(@"Listings.txt", newCar + Environment.NewLine);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSavePrivate_Click(object sender, EventArgs e)
        {
            string listDate = DateTime.Now.ToString("h:mm:ss tt");
            errorProvider1.Clear();
            int ctr = checkFlags();

            if (ctr == 0)
            {
                SaveCar(listDate);
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = "";
                fileName = openFileDialog1.FileName;
                imgBox1.Text = Path.GetFileName(fileName);
                if (!File.Exists(@"images\" + imgBox1.Text))
                {
                    File.Copy(openFileDialog1.FileName, @"images\" + imgBox1.Text, true);
                }
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = "";
                fileName = openFileDialog1.FileName;
                imgBox2.Text = Path.GetFileName(fileName);
                if (!File.Exists(@"images\" + imgBox2.Text))
                {
                    File.Copy(openFileDialog1.FileName, @"images\" + imgBox2.Text, true);
                }
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = "";
                fileName = openFileDialog1.FileName;
                imgBox3.Text = Path.GetFileName(fileName);
                if (!File.Exists(@"images\" + imgBox3.Text))
                {
                    File.Copy(openFileDialog1.FileName, @"images\" + imgBox3.Text, true);
                }
            }
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = "";
                fileName = openFileDialog1.FileName;
                imgBox4.Text = Path.GetFileName(fileName);
                if (!File.Exists(@"images\" + imgBox4.Text))
                {
                    File.Copy(openFileDialog1.FileName, @"images\" + imgBox4.Text, true);
                }
            }
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = "";
                fileName = openFileDialog1.FileName;
                imgBox5.Text = Path.GetFileName(fileName);
                if (!File.Exists(@"images\" + imgBox5.Text))
                {
                    File.Copy(openFileDialog1.FileName, @"images\" + imgBox5.Text, true);
                }
            }
        }
    }
}
