namespace breadpan
{
    partial class ShowAllChat
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
            this.dtGridViewAllChat = new System.Windows.Forms.DataGridView();
            this.chatid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAllChat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewAllChat
            // 
            this.dtGridViewAllChat.AllowUserToAddRows = false;
            this.dtGridViewAllChat.AllowUserToDeleteRows = false;
            this.dtGridViewAllChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewAllChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chatid,
            this.tourid,
            this.tourname,
            this.userid,
            this.from});
            this.dtGridViewAllChat.Location = new System.Drawing.Point(40, 123);
            this.dtGridViewAllChat.Name = "dtGridViewAllChat";
            this.dtGridViewAllChat.ReadOnly = true;
            this.dtGridViewAllChat.RowHeadersVisible = false;
            this.dtGridViewAllChat.Size = new System.Drawing.Size(691, 365);
            this.dtGridViewAllChat.TabIndex = 3;
            this.dtGridViewAllChat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewAllChat_CellClick);
            // 
            // chatid
            // 
            this.chatid.HeaderText = "ChatID";
            this.chatid.Name = "chatid";
            this.chatid.ReadOnly = true;
            // 
            // tourid
            // 
            this.tourid.HeaderText = "TourID";
            this.tourid.Name = "tourid";
            this.tourid.ReadOnly = true;
            // 
            // tourname
            // 
            this.tourname.HeaderText = "Tour Name";
            this.tourname.Name = "tourname";
            this.tourname.ReadOnly = true;
            this.tourname.Width = 150;
            // 
            // userid
            // 
            this.userid.HeaderText = "User ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Carbs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "BREADPAN AND TOUR";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ShowAllChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 558);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridViewAllChat);
            this.Name = "ShowAllChat";
            this.Text = "ShowAllChat";
            this.Load += new System.EventHandler(this.ShowAllChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAllChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewAllChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.Button btnCancel;
    }
}