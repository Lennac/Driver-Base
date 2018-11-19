namespace Project_Mockup
{
    partial class addListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbTransmission = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 71);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 100);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 126);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(12, 152);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(47, 13);
            this.lblMiles.TabIndex = 5;
            this.lblMiles.Text = "Mileage:";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(12, 178);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(40, 13);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(97, 97);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(248, 20);
            this.txtModel.TabIndex = 8;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(97, 149);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(248, 20);
            this.txtMileage.TabIndex = 10;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(97, 175);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(248, 20);
            this.txtColour.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 281);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "List Vehicle";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(457, 80);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 13;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(12, 211);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(71, 13);
            this.lblTransmission.TabIndex = 14;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 237);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "List Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 230);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(248, 20);
            this.txtPrice.TabIndex = 17;
            // 
            // cbTransmission
            // 
            this.cbTransmission.FormattingEnabled = true;
            this.cbTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.cbTransmission.Location = new System.Drawing.Point(97, 203);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.Size = new System.Drawing.Size(248, 21);
            this.cbTransmission.TabIndex = 18;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.cbYear.Location = new System.Drawing.Point(97, 122);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(248, 21);
            this.cbYear.TabIndex = 19;
            // 
            // cbMake
            // 
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Items.AddRange(new object[] {
            "Acura",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "GM",
            "GMC",
            "Honda",
            "Hyundai",
            "Infiniti",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Maserati",
            "Mazda",
            "Mercedes-Benz",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Ram",
            "Rolls Royce",
            "Saab",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cbMake.Location = new System.Drawing.Point(97, 71);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(248, 21);
            this.cbMake.TabIndex = 20;
            // 
            // addListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 392);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbTransmission);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Name = "addListing";
            this.Text = "Add a Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblColour;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtMileage;
        public System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbTransmission;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMake;
    }
}