namespace breadpan
{
    partial class TourGuide_ManageCreateTour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabManageTour = new System.Windows.Forms.TabPage();
            this.dtGridViewManageTour = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dislike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCreateTour = new System.Windows.Forms.TabPage();
            this.btnCreateTour = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabManageRequest = new System.Windows.Forms.TabPage();
            this.dtManageTourRequest = new System.Windows.Forms.DataGridView();
            this.transID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabManageTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewManageTour)).BeginInit();
            this.tabCreateTour.SuspendLayout();
            this.tabManageRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtManageTourRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "No Carbs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "BREADPAN AND TOUR";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabManageTour);
            this.tabControl1.Controls.Add(this.tabCreateTour);
            this.tabControl1.Controls.Add(this.tabManageRequest);
            this.tabControl1.Location = new System.Drawing.Point(32, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 401);
            this.tabControl1.TabIndex = 9;
            // 
            // tabManageTour
            // 
            this.tabManageTour.Controls.Add(this.dtGridViewManageTour);
            this.tabManageTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManageTour.Location = new System.Drawing.Point(4, 22);
            this.tabManageTour.Name = "tabManageTour";
            this.tabManageTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageTour.Size = new System.Drawing.Size(991, 375);
            this.tabManageTour.TabIndex = 0;
            this.tabManageTour.Text = "Manage Tours";
            this.tabManageTour.UseVisualStyleBackColor = true;
            // 
            // dtGridViewManageTour
            // 
            this.dtGridViewManageTour.AllowUserToAddRows = false;
            this.dtGridViewManageTour.AllowUserToDeleteRows = false;
            this.dtGridViewManageTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewManageTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.country,
            this.cost,
            this.duration,
            this.likes,
            this.dislike});
            this.dtGridViewManageTour.Location = new System.Drawing.Point(3, 6);
            this.dtGridViewManageTour.Name = "dtGridViewManageTour";
            this.dtGridViewManageTour.ReadOnly = true;
            this.dtGridViewManageTour.RowHeadersVisible = false;
            this.dtGridViewManageTour.Size = new System.Drawing.Size(982, 365);
            this.dtGridViewManageTour.TabIndex = 2;
            this.dtGridViewManageTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewManageTour_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tour ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tour Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost/PAX";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration (Days)";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 140;
            // 
            // likes
            // 
            this.likes.HeaderText = "LIKES";
            this.likes.Name = "likes";
            this.likes.ReadOnly = true;
            // 
            // dislike
            // 
            this.dislike.HeaderText = "DISLIKES";
            this.dislike.Name = "dislike";
            this.dislike.ReadOnly = true;
            // 
            // tabCreateTour
            // 
            this.tabCreateTour.Controls.Add(this.btnCreateTour);
            this.tabCreateTour.Controls.Add(this.txtDescription);
            this.tabCreateTour.Controls.Add(this.txtCost);
            this.tabCreateTour.Controls.Add(this.txtDuration);
            this.tabCreateTour.Controls.Add(this.txtCountry);
            this.tabCreateTour.Controls.Add(this.label8);
            this.tabCreateTour.Controls.Add(this.label6);
            this.tabCreateTour.Controls.Add(this.label5);
            this.tabCreateTour.Controls.Add(this.label4);
            this.tabCreateTour.Controls.Add(this.label3);
            this.tabCreateTour.Controls.Add(this.txtName);
            this.tabCreateTour.Location = new System.Drawing.Point(4, 22);
            this.tabCreateTour.Name = "tabCreateTour";
            this.tabCreateTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateTour.Size = new System.Drawing.Size(991, 375);
            this.tabCreateTour.TabIndex = 1;
            this.tabCreateTour.Text = "Create Tour";
            this.tabCreateTour.UseVisualStyleBackColor = true;
            // 
            // btnCreateTour
            // 
            this.btnCreateTour.Location = new System.Drawing.Point(134, 332);
            this.btnCreateTour.Name = "btnCreateTour";
            this.btnCreateTour.Size = new System.Drawing.Size(259, 23);
            this.btnCreateTour.TabIndex = 12;
            this.btnCreateTour.Text = "CREATE TOUR";
            this.btnCreateTour.UseVisualStyleBackColor = true;
            this.btnCreateTour.Click += new System.EventHandler(this.btnCreateTour_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 196);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(588, 113);
            this.txtDescription.TabIndex = 11;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(134, 154);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(138, 20);
            this.txtCost.TabIndex = 9;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(134, 115);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(138, 20);
            this.txtDuration.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(134, 76);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(138, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tour Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tour Cost $ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tour Duration (Days) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tour Country :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tour Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 0;
            // 
            // tabManageRequest
            // 
            this.tabManageRequest.Controls.Add(this.dtManageTourRequest);
            this.tabManageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabManageRequest.Name = "tabManageRequest";
            this.tabManageRequest.Size = new System.Drawing.Size(991, 375);
            this.tabManageRequest.TabIndex = 2;
            this.tabManageRequest.Text = "Manage Tour Request";
            this.tabManageRequest.UseVisualStyleBackColor = true;
            // 
            // dtManageTourRequest
            // 
            this.dtManageTourRequest.AllowUserToAddRows = false;
            this.dtManageTourRequest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtManageTourRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtManageTourRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtManageTourRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transID,
            this.tourName,
            this.requestor,
            this.emailAdd,
            this.pax,
            this.tourDate});
            this.dtManageTourRequest.Location = new System.Drawing.Point(5, 6);
            this.dtManageTourRequest.Name = "dtManageTourRequest";
            this.dtManageTourRequest.ReadOnly = true;
            this.dtManageTourRequest.RowHeadersVisible = false;
            this.dtManageTourRequest.Size = new System.Drawing.Size(983, 365);
            this.dtManageTourRequest.TabIndex = 3;
            this.dtManageTourRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtManageTourRequest_CellContentClick);
            // 
            // transID
            // 
            this.transID.HeaderText = "Transaction ID";
            this.transID.Name = "transID";
            this.transID.ReadOnly = true;
            this.transID.Width = 130;
            // 
            // tourName
            // 
            this.tourName.HeaderText = "Tour Name";
            this.tourName.Name = "tourName";
            this.tourName.ReadOnly = true;
            // 
            // requestor
            // 
            this.requestor.HeaderText = "Requestor";
            this.requestor.Name = "requestor";
            this.requestor.ReadOnly = true;
            // 
            // emailAdd
            // 
            this.emailAdd.HeaderText = "Email";
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.ReadOnly = true;
            // 
            // pax
            // 
            this.pax.HeaderText = "PAX";
            this.pax.Name = "pax";
            this.pax.ReadOnly = true;
            // 
            // tourDate
            // 
            this.tourDate.HeaderText = "Tour Date";
            this.tourDate.Name = "tourDate";
            this.tourDate.ReadOnly = true;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(756, 34);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(135, 29);
            this.btnChat.TabIndex = 10;
            this.btnChat.Text = "Chats";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(921, 34);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 29);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TourGuide_ManageCreateTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 537);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TourGuide_ManageCreateTour";
            this.Text = "TourGuide_ManageCreateTour";
            this.Load += new System.EventHandler(this.TourGuide_ManageCreateTour_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabManageTour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewManageTour)).EndInit();
            this.tabCreateTour.ResumeLayout(false);
            this.tabCreateTour.PerformLayout();
            this.tabManageRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtManageTourRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManageTour;
        private System.Windows.Forms.DataGridView dtGridViewManageTour;
        private System.Windows.Forms.TabPage tabCreateTour;
        private System.Windows.Forms.TabPage tabManageRequest;
        private System.Windows.Forms.DataGridView dtManageTourRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn transID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pax;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCreateTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn likes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dislike;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnLogout;
    }
}