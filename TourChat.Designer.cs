namespace breadpan
{
    partial class TourChat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtChat = new System.Windows.Forms.DataGridView();
            this.reply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.bthReply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSatisfied = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtChat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtChat
            // 
            this.dtChat.AllowUserToAddRows = false;
            this.dtChat.AllowUserToDeleteRows = false;
            this.dtChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reply,
            this.Chat});
            this.dtChat.Location = new System.Drawing.Point(42, 103);
            this.dtChat.Name = "dtChat";
            this.dtChat.ReadOnly = true;
            this.dtChat.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtChat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtChat.Size = new System.Drawing.Size(536, 286);
            this.dtChat.TabIndex = 0;
            // 
            // reply
            // 
            this.reply.HeaderText = "                  ";
            this.reply.Name = "reply";
            this.reply.ReadOnly = true;
            // 
            // Chat
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Chat.DefaultCellStyle = dataGridViewCellStyle3;
            this.Chat.HeaderText = "Chat";
            this.Chat.Name = "Chat";
            this.Chat.ReadOnly = true;
            this.Chat.ToolTipText = "By";
            this.Chat.Width = 433;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "No Carbs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "BREADPAN AND TOUR";
            // 
            // txtReply
            // 
            this.txtReply.Location = new System.Drawing.Point(42, 422);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(536, 94);
            this.txtReply.TabIndex = 7;
            // 
            // bthReply
            // 
            this.bthReply.Location = new System.Drawing.Point(223, 531);
            this.bthReply.Name = "bthReply";
            this.bthReply.Size = new System.Drawing.Size(180, 31);
            this.bthReply.TabIndex = 8;
            this.bthReply.Text = "Send";
            this.bthReply.UseVisualStyleBackColor = true;
            this.bthReply.Click += new System.EventHandler(this.txtReply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSatisfied
            // 
            this.btnSatisfied.Location = new System.Drawing.Point(42, 531);
            this.btnSatisfied.Name = "btnSatisfied";
            this.btnSatisfied.Size = new System.Drawing.Size(117, 31);
            this.btnSatisfied.TabIndex = 10;
            this.btnSatisfied.Text = "Satisfied with Answer";
            this.btnSatisfied.UseVisualStyleBackColor = true;
            this.btnSatisfied.Visible = false;
            this.btnSatisfied.Click += new System.EventHandler(this.btnSatisfied_Click);
            // 
            // TourChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 591);
            this.Controls.Add(this.btnSatisfied);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bthReply);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtChat);
            this.Name = "TourChat";
            this.Text = "TourGuideChat";
            this.Load += new System.EventHandler(this.TourGuideChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.Button bthReply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn reply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chat;
        private System.Windows.Forms.Button btnSatisfied;
    }
}