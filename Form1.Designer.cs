namespace Project_Mockup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAccount = new System.Windows.Forms.ToolStripButton();
            this.btnFavourites = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnToggleAccount = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSavedSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSearchForCar = new System.Windows.Forms.Button();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.gridCarList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccount,
            this.btnFavourites,
            this.btnExit,
            this.btnToggleAccount,
            this.btnHelp,
            this.toolStripLabel1,
            this.btnSavedSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 83);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAccount
            // 
            this.btnAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(64, 80);
            this.btnAccount.Text = "Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccount.ToolTipText = "Click to display your account information.";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFavourites.AutoSize = false;
            this.btnFavourites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFavourites.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavourites.Image = ((System.Drawing.Image)(resources.GetObject("btnFavourites.Image")));
            this.btnFavourites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(80, 40);
            this.btnFavourites.Text = "Favourites";
            this.btnFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFavourites.ToolTipText = "Click to display the cars you have favourited.";
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 80);
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.ToolTipText = "Click to exit the application.";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnToggleAccount
            // 
            this.btnToggleAccount.AutoSize = false;
            this.btnToggleAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToggleAccount.Name = "btnToggleAccount";
            this.btnToggleAccount.Size = new System.Drawing.Size(48, 40);
            this.btnToggleAccount.Text = "Login";
            this.btnToggleAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToggleAccount.ToolTipText = "Click to login to a different account.";
            this.btnToggleAccount.Click += new System.EventHandler(this.btnToggleAccount_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(41, 80);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(300, 80);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnSavedSearch
            // 
            this.btnSavedSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSavedSearch.AutoSize = false;
            this.btnSavedSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSavedSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavedSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSavedSearch.Image")));
            this.btnSavedSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavedSearch.Name = "btnSavedSearch";
            this.btnSavedSearch.Size = new System.Drawing.Size(113, 40);
            this.btnSavedSearch.Text = "Search History";
            this.btnSavedSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSavedSearch.ToolTipText = "Click to view your search history.";
            this.btnSavedSearch.Click += new System.EventHandler(this.btnSavedSearch_Click);
            // 
            // btnSearchForCar
            // 
            this.btnSearchForCar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForCar.Location = new System.Drawing.Point(307, 174);
            this.btnSearchForCar.Name = "btnSearchForCar";
            this.btnSearchForCar.Size = new System.Drawing.Size(129, 40);
            this.btnSearchForCar.TabIndex = 1;
            this.btnSearchForCar.Text = "Search for a Vehicle";
            this.btnSearchForCar.UseVisualStyleBackColor = true;
            this.btnSearchForCar.Click += new System.EventHandler(this.btnSearchForCar_Click);
            // 
            // btnSellCar
            // 
            this.btnSellCar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellCar.Location = new System.Drawing.Point(533, 174);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(147, 40);
            this.btnSellCar.TabIndex = 2;
            this.btnSellCar.Text = "List a Vehicle for Sale";
            this.btnSellCar.UseVisualStyleBackColor = true;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(258, 124);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.ReadOnly = true;
            this.txtWelcome.Size = new System.Drawing.Size(324, 24);
            this.txtWelcome.TabIndex = 6;
            this.txtWelcome.Visible = false;
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
            this.gridCarList.Location = new System.Drawing.Point(7, 224);
            this.gridCarList.MultiSelect = false;
            this.gridCarList.Name = "gridCarList";
            this.gridCarList.ReadOnly = true;
            this.gridCarList.RowHeadersVisible = false;
            this.gridCarList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCarList.Size = new System.Drawing.Size(822, 506);
            this.gridCarList.TabIndex = 5;
            this.gridCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCarList_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 185);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 23);
            this.txtSearch.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(91, 162);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(139, 18);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search Parameters:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 738);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.gridCarList);
            this.Controls.Add(this.btnSellCar);
            this.Controls.Add(this.btnSearchForCar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFavourites;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Button btnSearchForCar;
        private System.Windows.Forms.Button btnSellCar;
        private System.Windows.Forms.ToolStripButton btnAccount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSavedSearch;
        private System.Windows.Forms.ToolStripButton btnToggleAccount;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.DataGridView gridCarList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnHelp;
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

