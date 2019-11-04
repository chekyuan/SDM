namespace breadpan
{
    partial class ViewTour
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTour = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cbPax = new System.Windows.Forms.ComboBox();
            this.calFrom = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSDate = new System.Windows.Forms.Label();
            this.lblEDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "No Carbs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "BREADPAN AND TOUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "©";
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTour.Location = new System.Drawing.Point(28, 128);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(171, 31);
            this.lblTour.TabIndex = 6;
            this.lblTour.Text = "*Tour Name*";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(33, 174);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(511, 368);
            this.txtDescription.TabIndex = 8;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(613, 175);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(472, 241);
            this.picBox.TabIndex = 9;
            this.picBox.TabStop = false;
            // 
            // cbPax
            // 
            this.cbPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPax.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbPax.FormattingEnabled = true;
            this.cbPax.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPax.Location = new System.Drawing.Point(613, 448);
            this.cbPax.Name = "cbPax";
            this.cbPax.Size = new System.Drawing.Size(214, 24);
            this.cbPax.TabIndex = 10;
            // 
            // calFrom
            // 
            this.calFrom.Location = new System.Drawing.Point(613, 521);
            this.calFrom.Name = "calFrom";
            this.calFrom.TabIndex = 11;
            this.calFrom.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calFrom_DateSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "From :";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(1004, 701);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(81, 32);
            this.btnBook.TabIndex = 15;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Per PAX : $";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(140, 566);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(69, 25);
            this.lblCost.TabIndex = 21;
            this.lblCost.Text = "*Cost*";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(164, 620);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(42, 25);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "*D*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tour Duration :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(854, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "End Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(852, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Start Date :";
            // 
            // lblSDate
            // 
            this.lblSDate.AutoSize = true;
            this.lblSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDate.Location = new System.Drawing.Point(962, 531);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(115, 25);
            this.lblSDate.TabIndex = 26;
            this.lblSDate.Text = "*Start Date*";
            this.lblSDate.Visible = false;
            // 
            // lblEDate
            // 
            this.lblEDate.AutoSize = true;
            this.lblEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDate.Location = new System.Drawing.Point(962, 585);
            this.lblEDate.Name = "lblEDate";
            this.lblEDate.Size = new System.Drawing.Size(109, 25);
            this.lblEDate.TabIndex = 27;
            this.lblEDate.Text = "*End Date*";
            this.lblEDate.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Day(s)";
            // 
            // ViewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 756);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblEDate);
            this.Controls.Add(this.lblSDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calFrom);
            this.Controls.Add(this.cbPax);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewTour";
            this.Text = "ViewTour";
            this.Load += new System.EventHandler(this.ViewTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox cbPax;
        private System.Windows.Forms.MonthCalendar calFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSDate;
        private System.Windows.Forms.Label lblEDate;
        private System.Windows.Forms.Label label11;
    }
}