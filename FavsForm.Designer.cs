namespace Project_Mockup
{
    partial class FavsForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridCarList = new System.Windows.Forms.DataGridView();
            this.viewCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listingNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carImage = new System.Windows.Forms.DataGridViewImageColumn();
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
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(30, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Favourites for:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(110, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(236, 20);
            this.txtUser.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(566, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
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
            this.gridCarList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCarList.BackgroundColor = System.Drawing.Color.White;
            this.gridCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viewCar,
            this.listingNum,
            this.carImage,
            this.carMake,
            this.carModel,
            this.carYear,
            this.carMileage,
            this.carColour,
            this.carTransmission,
            this.carPrice,
            this.DateTime});
            this.gridCarList.Location = new System.Drawing.Point(12, 61);
            this.gridCarList.MultiSelect = false;
            this.gridCarList.Name = "gridCarList";
            this.gridCarList.ReadOnly = true;
            this.gridCarList.RowHeadersVisible = false;
            this.gridCarList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCarList.Size = new System.Drawing.Size(1156, 358);
            this.gridCarList.TabIndex = 6;
            this.gridCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCarList_CellContentClick);
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
            // FavsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.gridCarList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Name = "FavsForm";
            this.Text = "FavsForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gridCarList;
        private System.Windows.Forms.DataGridViewButtonColumn viewCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn listingNum;
        private System.Windows.Forms.DataGridViewImageColumn carImage;
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