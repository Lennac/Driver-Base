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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAccount = new System.Windows.Forms.ToolStripButton();
            this.btnFavourites = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSavedSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSearchForCar = new System.Windows.Forms.Button();
            this.brnSellCar = new System.Windows.Forms.Button();
            this.lstCarObjects = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccount,
            this.btnFavourites,
            this.btnExit,
            this.toolStripLabel1,
            this.btnSavedSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 103);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAccount
            // 
            this.btnAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(72, 100);
            this.btnAccount.Text = "Account";
            // 
            // btnFavourites
            // 
            this.btnFavourites.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFavourites.Image = ((System.Drawing.Image)(resources.GetObject("btnFavourites.Image")));
            this.btnFavourites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(81, 100);
            this.btnFavourites.Text = "Favourites";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 100);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(300, 100);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // btnSavedSearch
            // 
            this.btnSavedSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSavedSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSavedSearch.Image")));
            this.btnSavedSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavedSearch.Name = "btnSavedSearch";
            this.btnSavedSearch.Size = new System.Drawing.Size(107, 100);
            this.btnSavedSearch.Text = "Saved Searches";
            // 
            // btnSearchForCar
            // 
            this.btnSearchForCar.Location = new System.Drawing.Point(193, 126);
            this.btnSearchForCar.Name = "btnSearchForCar";
            this.btnSearchForCar.Size = new System.Drawing.Size(129, 40);
            this.btnSearchForCar.TabIndex = 1;
            this.btnSearchForCar.Text = "Search for a Car";
            this.btnSearchForCar.UseVisualStyleBackColor = true;
            // 
            // brnSellCar
            // 
            this.brnSellCar.Location = new System.Drawing.Point(574, 126);
            this.brnSellCar.Name = "brnSellCar";
            this.brnSellCar.Size = new System.Drawing.Size(120, 40);
            this.brnSellCar.TabIndex = 2;
            this.brnSellCar.Text = "List a Car for Sale";
            this.brnSellCar.UseVisualStyleBackColor = true;
            // 
            // lstCarObjects
            // 
            this.lstCarObjects.Location = new System.Drawing.Point(12, 187);
            this.lstCarObjects.Name = "lstCarObjects";
            this.lstCarObjects.Size = new System.Drawing.Size(813, 409);
            this.lstCarObjects.TabIndex = 4;
            this.lstCarObjects.UseCompatibleStateImageBehavior = false;
            this.lstCarObjects.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 700);
            this.Controls.Add(this.lstCarObjects);
            this.Controls.Add(this.brnSellCar);
            this.Controls.Add(this.btnSearchForCar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFavourites;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Button btnSearchForCar;
        private System.Windows.Forms.Button brnSellCar;
        private System.Windows.Forms.ListView lstCarObjects;
        private System.Windows.Forms.ToolStripButton btnAccount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSavedSearch;
    }
}

