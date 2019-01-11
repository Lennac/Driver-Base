namespace Project_Mockup
{
    partial class AccountInfo
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lblCarsListed = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridCarList = new System.Windows.Forms.DataGridView();
            this.btnEditEmail = new System.Windows.Forms.Button();
            this.viewCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listingNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTransmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(131, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(284, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(19, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(131, 70);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.ReadOnly = true;
            this.txtUserEmail.Size = new System.Drawing.Size(284, 23);
            this.txtUserEmail.TabIndex = 8;
            // 
            // lblCarsListed
            // 
            this.lblCarsListed.AutoSize = true;
            this.lblCarsListed.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsListed.Location = new System.Drawing.Point(23, 118);
            this.lblCarsListed.Name = "lblCarsListed";
            this.lblCarsListed.Size = new System.Drawing.Size(96, 16);
            this.lblCarsListed.TabIndex = 9;
            this.lblCarsListed.Text = "Vehicles Listed:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(565, 583);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridCarList
            // 
            this.gridCarList.AllowUserToAddRows = false;
            this.gridCarList.AllowUserToDeleteRows = false;
            this.gridCarList.AllowUserToResizeColumns = false;
            this.gridCarList.AllowUserToResizeRows = false;
            this.gridCarList.BackgroundColor = System.Drawing.Color.White;
            this.gridCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viewCar,
            this.listingNum,
            this.carImage,
            this.Status,
            this.carMake,
            this.carModel,
            this.carYear,
            this.carMileage,
            this.carColour,
            this.carTransmission,
            this.carPrice,
            this.DateTime});
            this.gridCarList.Location = new System.Drawing.Point(21, 140);
            this.gridCarList.MultiSelect = false;
            this.gridCarList.Name = "gridCarList";
            this.gridCarList.ReadOnly = true;
            this.gridCarList.RowHeadersVisible = false;
            this.gridCarList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCarList.Size = new System.Drawing.Size(1154, 422);
            this.gridCarList.TabIndex = 11;
            this.gridCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCarList_CellContentClick);
            // 
            // btnEditEmail
            // 
            this.btnEditEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmail.Location = new System.Drawing.Point(442, 70);
            this.btnEditEmail.Name = "btnEditEmail";
            this.btnEditEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmail.TabIndex = 12;
            this.btnEditEmail.Text = "Edit Email";
            this.btnEditEmail.UseVisualStyleBackColor = true;
            this.btnEditEmail.Click += new System.EventHandler(this.btnEditEmail_Click);
            // 
            // viewCar
            // 
            this.viewCar.HeaderText = "";
            this.viewCar.Name = "viewCar";
            this.viewCar.ReadOnly = true;
            this.viewCar.Text = "View Vehicle";
            this.viewCar.UseColumnTextForButtonValue = true;
            // 
            // listingNum
            // 
            this.listingNum.HeaderText = "Listing";
            this.listingNum.Name = "listingNum";
            this.listingNum.ReadOnly = true;
            this.listingNum.Width = 50;
            // 
            // carImage
            // 
            this.carImage.HeaderText = "Preview";
            this.carImage.Name = "carImage";
            this.carImage.ReadOnly = true;
            this.carImage.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // carMake
            // 
            this.carMake.HeaderText = "Make";
            this.carMake.Name = "carMake";
            this.carMake.ReadOnly = true;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Model";
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            // 
            // carYear
            // 
            this.carYear.HeaderText = "Year";
            this.carYear.Name = "carYear";
            this.carYear.ReadOnly = true;
            // 
            // carMileage
            // 
            this.carMileage.HeaderText = "Kilometers";
            this.carMileage.Name = "carMileage";
            this.carMileage.ReadOnly = true;
            // 
            // carColour
            // 
            this.carColour.HeaderText = "Colour";
            this.carColour.Name = "carColour";
            this.carColour.ReadOnly = true;
            // 
            // carTransmission
            // 
            this.carTransmission.HeaderText = "Transmission";
            this.carTransmission.Name = "carTransmission";
            this.carTransmission.ReadOnly = true;
            // 
            // carPrice
            // 
            this.carPrice.HeaderText = "Price";
            this.carPrice.Name = "carPrice";
            this.carPrice.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Listing Date";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 618);
            this.Controls.Add(this.btnEditEmail);
            this.Controls.Add(this.gridCarList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCarsListed);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "AccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInfo";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lblCarsListed;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gridCarList;
        private System.Windows.Forms.Button btnEditEmail;
        private System.Windows.Forms.DataGridViewButtonColumn viewCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn listingNum;
        private System.Windows.Forms.DataGridViewImageColumn carImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn carMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn carMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColour;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTransmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn carPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
    }
}