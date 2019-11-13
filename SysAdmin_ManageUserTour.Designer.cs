namespace breadpan
{
    partial class SysAdmin_ManageUserTour
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
            this.tabManageUsers = new System.Windows.Forms.TabPage();
            this.tabManageTours = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbManageUsers = new System.Windows.Forms.TabPage();
            this.dtGridViewManageTour = new System.Windows.Forms.DataGridView();
            this.tourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManageTour = new System.Windows.Forms.TabPage();
            this.dtManageUser = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tbManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewManageTour)).BeginInit();
            this.tbManageTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtManageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.Location = new System.Drawing.Point(0, 0);
            this.tabManageUsers.Name = "tabManageUsers";
            this.tabManageUsers.Size = new System.Drawing.Size(200, 100);
            this.tabManageUsers.TabIndex = 0;
            // 
            // tabManageTours
            // 
            this.tabManageTours.Location = new System.Drawing.Point(0, 0);
            this.tabManageTours.Name = "tabManageTours";
            this.tabManageTours.Size = new System.Drawing.Size(200, 100);
            this.tabManageTours.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbManageUsers);
            this.tabControl2.Controls.Add(this.tbManageTour);
            this.tabControl2.Location = new System.Drawing.Point(33, 116);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(966, 469);
            this.tabControl2.TabIndex = 10;
            // 
            // tbManageUsers
            // 
            this.tbManageUsers.Controls.Add(this.dtGridViewManageTour);
            this.tbManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManageUsers.Location = new System.Drawing.Point(4, 22);
            this.tbManageUsers.Name = "tbManageUsers";
            this.tbManageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbManageUsers.Size = new System.Drawing.Size(958, 443);
            this.tbManageUsers.TabIndex = 0;
            this.tbManageUsers.Text = "Manage Tour";
            this.tbManageUsers.UseVisualStyleBackColor = true;
            // 
            // dtGridViewManageTour
            // 
            this.dtGridViewManageTour.AllowUserToAddRows = false;
            this.dtGridViewManageTour.AllowUserToDeleteRows = false;
            this.dtGridViewManageTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewManageTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourID,
            this.tName,
            this.tUser});
            this.dtGridViewManageTour.Location = new System.Drawing.Point(3, 6);
            this.dtGridViewManageTour.Name = "dtGridViewManageTour";
            this.dtGridViewManageTour.ReadOnly = true;
            this.dtGridViewManageTour.Size = new System.Drawing.Size(949, 365);
            this.dtGridViewManageTour.TabIndex = 2;
            this.dtGridViewManageTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewManageTour_CellClick);
            // 
            // tourID
            // 
            this.tourID.HeaderText = "TourID";
            this.tourID.Name = "tourID";
            this.tourID.ReadOnly = true;
            // 
            // tName
            // 
            this.tName.HeaderText = "Tour Name";
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Width = 150;
            // 
            // tUser
            // 
            this.tUser.HeaderText = "Tour Guide";
            this.tUser.Name = "tUser";
            this.tUser.ReadOnly = true;
            this.tUser.Width = 150;
            // 
            // tbManageTour
            // 
            this.tbManageTour.Controls.Add(this.dtManageUser);
            this.tbManageTour.Location = new System.Drawing.Point(4, 22);
            this.tbManageTour.Name = "tbManageTour";
            this.tbManageTour.Size = new System.Drawing.Size(958, 443);
            this.tbManageTour.TabIndex = 2;
            this.tbManageTour.Text = "Manage User";
            this.tbManageTour.UseVisualStyleBackColor = true;
            // 
            // dtManageUser
            // 
            this.dtManageUser.AllowUserToAddRows = false;
            this.dtManageUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtManageUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtManageUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.user,
            this.role});
            this.dtManageUser.Location = new System.Drawing.Point(5, 6);
            this.dtManageUser.Name = "dtManageUser";
            this.dtManageUser.ReadOnly = true;
            this.dtManageUser.Size = new System.Drawing.Size(882, 365);
            this.dtManageUser.TabIndex = 3;
            this.dtManageUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtManageUser_CellClick);
            // 
            // userid
            // 
            this.userid.HeaderText = "User ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "Full Name";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 150;
            // 
            // role
            // 
            this.role.HeaderText = "User Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "No Carbs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 39);
            this.label9.TabIndex = 11;
            this.label9.Text = "BREADPAN AND TOUR";
            // 
            // SysAdmin_ManageUserTour
            // 
            this.ClientSize = new System.Drawing.Size(1089, 605);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl2);
            this.Name = "SysAdmin_ManageUserTour";
            this.Load += new System.EventHandler(this.SysAdmin_ManageUserTour_Load);
            this.tabControl2.ResumeLayout(false);
            this.tbManageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewManageTour)).EndInit();
            this.tbManageTour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtManageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManageUsers;
        private System.Windows.Forms.TabPage tabManageTours;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbManageUsers;
        private System.Windows.Forms.TabPage tbManageTour;
        private System.Windows.Forms.DataGridView dtManageUser;
        private System.Windows.Forms.DataGridView dtGridViewManageTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
    }
}