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
            this.components = new System.ComponentModel.Container();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbTransmission = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbColour = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imgBox1 = new System.Windows.Forms.TextBox();
            this.imgBox2 = new System.Windows.Forms.TextBox();
            this.imgBox3 = new System.Windows.Forms.TextBox();
            this.imgBox4 = new System.Windows.Forms.TextBox();
            this.imgBox5 = new System.Windows.Forms.TextBox();
            this.btnSavePrivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.btnAdd5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(17, 42);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(42, 16);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(17, 76);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(18, 107);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(17, 137);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(75, 16);
            this.lblMiles.TabIndex = 5;
            this.lblMiles.Text = "Kilometers:";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(18, 166);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(49, 16);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(97, 73);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(248, 23);
            this.txtModel.TabIndex = 1;
            // 
            // txtMileage
            // 
            this.txtMileage.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileage.Location = new System.Drawing.Point(97, 134);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(248, 23);
            this.txtMileage.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(64, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "List Vehicle for Sale";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(7, 199);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(88, 16);
            this.lblTransmission.TabIndex = 14;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(13, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 16);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "List Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(95, 225);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(248, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // cbTransmission
            // 
            this.cbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransmission.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransmission.FormattingEnabled = true;
            this.cbTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.cbTransmission.Location = new System.Drawing.Point(96, 194);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.Size = new System.Drawing.Size(248, 24);
            this.cbTransmission.TabIndex = 5;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbYear.Location = new System.Drawing.Point(97, 102);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(248, 24);
            this.cbYear.TabIndex = 2;
            // 
            // cbMake
            // 
            this.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMake.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbMake.Location = new System.Drawing.Point(98, 41);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(248, 24);
            this.cbMake.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cbColour
            // 
            this.cbColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColour.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColour.FormattingEnabled = true;
            this.cbColour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Green",
            "Grey",
            "Orange",
            "Red",
            "Silver",
            "Yellow",
            "White",
            "Other"});
            this.cbColour.Location = new System.Drawing.Point(97, 163);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(248, 24);
            this.cbColour.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(246, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imgBox1
            // 
            this.imgBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBox1.Location = new System.Drawing.Point(388, 48);
            this.imgBox1.Name = "imgBox1";
            this.imgBox1.ReadOnly = true;
            this.imgBox1.Size = new System.Drawing.Size(248, 23);
            this.imgBox1.TabIndex = 23;
            // 
            // imgBox2
            // 
            this.imgBox2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBox2.Location = new System.Drawing.Point(388, 76);
            this.imgBox2.Name = "imgBox2";
            this.imgBox2.ReadOnly = true;
            this.imgBox2.Size = new System.Drawing.Size(248, 23);
            this.imgBox2.TabIndex = 24;
            // 
            // imgBox3
            // 
            this.imgBox3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBox3.Location = new System.Drawing.Point(388, 101);
            this.imgBox3.Name = "imgBox3";
            this.imgBox3.ReadOnly = true;
            this.imgBox3.Size = new System.Drawing.Size(248, 23);
            this.imgBox3.TabIndex = 25;
            // 
            // imgBox4
            // 
            this.imgBox4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBox4.Location = new System.Drawing.Point(388, 128);
            this.imgBox4.Name = "imgBox4";
            this.imgBox4.ReadOnly = true;
            this.imgBox4.Size = new System.Drawing.Size(248, 23);
            this.imgBox4.TabIndex = 26;
            // 
            // imgBox5
            // 
            this.imgBox5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBox5.Location = new System.Drawing.Point(388, 156);
            this.imgBox5.Name = "imgBox5";
            this.imgBox5.ReadOnly = true;
            this.imgBox5.Size = new System.Drawing.Size(248, 23);
            this.imgBox5.TabIndex = 27;
            // 
            // btnSavePrivate
            // 
            this.btnSavePrivate.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrivate.Location = new System.Drawing.Point(111, 300);
            this.btnSavePrivate.Name = "btnSavePrivate";
            this.btnSavePrivate.Size = new System.Drawing.Size(216, 23);
            this.btnSavePrivate.TabIndex = 28;
            this.btnSavePrivate.Text = "Save Vehicle as Unlisted";
            this.btnSavePrivate.UseVisualStyleBackColor = true;
            this.btnSavePrivate.Click += new System.EventHandler(this.btnSavePrivate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add Up To Five (5) Images for Display";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.Location = new System.Drawing.Point(639, 47);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(103, 23);
            this.btnAdd1.TabIndex = 30;
            this.btnAdd1.Text = "Add Image";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(639, 75);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(103, 23);
            this.btnAdd2.TabIndex = 31;
            this.btnAdd2.Text = "Add Image";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnAdd3
            // 
            this.btnAdd3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd3.Location = new System.Drawing.Point(639, 101);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(103, 23);
            this.btnAdd3.TabIndex = 32;
            this.btnAdd3.Text = "Add Image";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // btnAdd4
            // 
            this.btnAdd4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd4.Location = new System.Drawing.Point(639, 128);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(103, 23);
            this.btnAdd4.TabIndex = 33;
            this.btnAdd4.Text = "Add Image";
            this.btnAdd4.UseVisualStyleBackColor = true;
            this.btnAdd4.Click += new System.EventHandler(this.btnAdd4_Click);
            // 
            // btnAdd5
            // 
            this.btnAdd5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd5.Location = new System.Drawing.Point(639, 156);
            this.btnAdd5.Name = "btnAdd5";
            this.btnAdd5.Size = new System.Drawing.Size(103, 23);
            this.btnAdd5.TabIndex = 34;
            this.btnAdd5.Text = "Add Image";
            this.btnAdd5.UseVisualStyleBackColor = true;
            this.btnAdd5.Click += new System.EventHandler(this.btnAdd5_Click);
            // 
            // addListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 391);
            this.Controls.Add(this.btnAdd5);
            this.Controls.Add(this.btnAdd4);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePrivate);
            this.Controls.Add(this.imgBox5);
            this.Controls.Add(this.imgBox4);
            this.Controls.Add(this.imgBox3);
            this.Controls.Add(this.imgBox2);
            this.Controls.Add(this.imgBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbColour);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbTransmission);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Name = "addListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox imgBox5;
        public System.Windows.Forms.TextBox imgBox4;
        public System.Windows.Forms.TextBox imgBox3;
        public System.Windows.Forms.TextBox imgBox2;
        public System.Windows.Forms.TextBox imgBox1;
        private System.Windows.Forms.Button btnSavePrivate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbMake;
        public System.Windows.Forms.ComboBox cbTransmission;
        public System.Windows.Forms.ComboBox cbYear;
        public System.Windows.Forms.ComboBox cbColour;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnAdd5;
        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Button btnAdd2;
    }
}