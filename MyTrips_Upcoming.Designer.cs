namespace breadpan
{
    partial class MyTrips_Upcoming
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUpcoming = new System.Windows.Forms.TabPage();
            this.tabPast = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUpcoming);
            this.tabControl1.Controls.Add(this.tabPast);
            this.tabControl1.Location = new System.Drawing.Point(32, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUpcoming
            // 
            this.tabUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUpcoming.Location = new System.Drawing.Point(4, 22);
            this.tabUpcoming.Name = "tabUpcoming";
            this.tabUpcoming.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpcoming.Size = new System.Drawing.Size(1079, 438);
            this.tabUpcoming.TabIndex = 0;
            this.tabUpcoming.Text = "UPCOMING TRIPS";
            this.tabUpcoming.UseVisualStyleBackColor = true;
            // 
            // tabPast
            // 
            this.tabPast.Location = new System.Drawing.Point(4, 22);
            this.tabPast.Name = "tabPast";
            this.tabPast.Padding = new System.Windows.Forms.Padding(3);
            this.tabPast.Size = new System.Drawing.Size(1079, 438);
            this.tabPast.TabIndex = 1;
            this.tabPast.Text = "PAST TRIPS";
            this.tabPast.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "©";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Carbs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "BREADPAN AND TOUR";
            // 
            // MyTrips_Upcoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 604);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MyTrips_Upcoming";
            this.Text = "MyTrips_Upcoming";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUpcoming;
        private System.Windows.Forms.TabPage tabPast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}