namespace breadpan
{
    partial class ViewAll
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnMyTrips = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lstAllTour = new System.Windows.Forms.ListView();
            this.TourID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TourName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TourCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TourCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TourGuideName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BREADPAN AND TOUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "No Carbs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "©";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(818, 565);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(712, 59);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(74, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(818, 59);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(74, 23);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnMyTrips
            // 
            this.btnMyTrips.Location = new System.Drawing.Point(818, 12);
            this.btnMyTrips.Name = "btnMyTrips";
            this.btnMyTrips.Size = new System.Drawing.Size(75, 23);
            this.btnMyTrips.TabIndex = 12;
            this.btnMyTrips.Text = "My Trips";
            this.btnMyTrips.UseVisualStyleBackColor = true;
            this.btnMyTrips.Visible = false;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(672, 119);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(225, 21);
            this.cbCountry.TabIndex = 14;
            // 
            // lstAllTour
            // 
            this.lstAllTour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TourID,
            this.TourName,
            this.TourCountry,
            this.TourCost,
            this.TourGuideName});
            this.lstAllTour.FullRowSelect = true;
            this.lstAllTour.HideSelection = false;
            this.lstAllTour.Location = new System.Drawing.Point(30, 100);
            this.lstAllTour.Name = "lstAllTour";
            this.lstAllTour.Size = new System.Drawing.Size(617, 412);
            this.lstAllTour.TabIndex = 15;
            this.lstAllTour.UseCompatibleStateImageBehavior = false;
            this.lstAllTour.View = System.Windows.Forms.View.Details;
            this.lstAllTour.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAllTour_MouseDoubleClick);
            // 
            // TourID
            // 
            this.TourID.Text = "TourID";
            // 
            // TourName
            // 
            this.TourName.Text = "Tour Name";
            this.TourName.Width = 168;
            // 
            // TourCountry
            // 
            this.TourCountry.Text = "Country";
            this.TourCountry.Width = 156;
            // 
            // TourCost
            // 
            this.TourCost.Text = "Tour Cost";
            this.TourCost.Width = 84;
            // 
            // TourGuideName
            // 
            this.TourGuideName.Text = "Tour Guide Name";
            this.TourGuideName.Width = 139;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(574, 519);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(669, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(105, 13);
            this.lblWelcome.TabIndex = 19;
            this.lblWelcome.Text = "*Welcome message*";
            this.lblWelcome.Visible = false;
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 621);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstAllTour);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btnMyTrips);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewAll";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnMyTrips;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ListView lstAllTour;
        private System.Windows.Forms.ColumnHeader TourID;
        private System.Windows.Forms.ColumnHeader TourName;
        private System.Windows.Forms.ColumnHeader TourCountry;
        private System.Windows.Forms.ColumnHeader TourCost;
        private System.Windows.Forms.ColumnHeader TourGuideName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWelcome;
    }
}

