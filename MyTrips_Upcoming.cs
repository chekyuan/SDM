using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace breadpan
{
    public partial class MyTrips_Upcoming : Form
    {
        public MyTrips_Upcoming()
        {
            InitializeComponent();
        }
        //Bruce's connection string
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        static Random random = new Random();
        private void MyTrips_Upcoming_Load(object sender, EventArgs e)
        {
            RetrieveUpcomingTrips();
            RetrievePassTrips();
        }
        public void RetrieveUpcomingTrips()
        {
            string datetimeNow = DateTime.Now.ToString("yyyy/MM/dd");
            string sqlRetrieveData = "SELECT TOURTRANSACTION.TransID, TOURTRANSACTION.TourID, TOUR.TName, TOURTRANSACTION.Pax, TOURTRANSACTION.FromDate, TOURTRANSACTION.ToDate, TOURTRANSACTION.TStatus FROM TOURTRANSACTION FULL JOIN TOUR ON TOURTRANSACTION.TourID = TOUR.TourID WHERE TOURTRANSACTION.UserID = '" + ViewAll.LoginInfo.UserID + "' AND TOURTRANSACTION.ToDate > '"+ datetimeNow + "'";
            //Retrieve Up coming trips records
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            con.Open();
            foreach (DataRow item in dt1.Rows)
            {
                int n = dtGridViewUpcoming.Rows.Add();
                dtGridViewUpcoming.Rows[n].Cells[0].Value = item["TransID"].ToString();
                dtGridViewUpcoming.Rows[n].Cells[1].Value = item["TourID"].ToString();
                dtGridViewUpcoming.Rows[n].Cells[2].Value = item["TName"].ToString();
                dtGridViewUpcoming.Rows[n].Cells[3].Value = item["Pax"].ToString();
                dtGridViewUpcoming.Rows[n].Cells[4].Value = Convert.ToDateTime(item["FromDate"]).ToString("dd/MM/yyyy");
                dtGridViewUpcoming.Rows[n].Cells[5].Value = Convert.ToDateTime(item["ToDate"]).ToString("dd/MM/yyyy");
                dtGridViewUpcoming.Rows[n].Cells[6].Value = item["TStatus"].ToString();

                con.Close();
            }
        }
       
        private void RetrievePassTrips()
        {
            string datetimeNow = DateTime.Now.ToString("yyyy/MM/dd");
            //Like btn
            DataGridViewButtonColumn btnLike = new DataGridViewButtonColumn();
            btnLike.HeaderText = "Rate Tour";
            btnLike.Name = "likeTour";
            btnLike.Text = "Like";
            btnLike.UseColumnTextForButtonValue = true;
            dtGridViewPass.Columns.Add(btnLike);

            //Like btn
            DataGridViewButtonColumn btnDislike = new DataGridViewButtonColumn();
            btnDislike.HeaderText = "Rate Tour";
            btnDislike.Name = "dislikeTour";
            btnDislike.Text = "Dislike";
            btnDislike.UseColumnTextForButtonValue = true;
            dtGridViewPass.Columns.Add(btnDislike);

            string sqlRetrieveData = "SELECT TOURTRANSACTION.TransID, TOURTRANSACTION.TourID, TOUR.TName, TOURTRANSACTION.Pax, TOURTRANSACTION.FromDate, TOURTRANSACTION.ToDate, TOURTRANSACTION.ReviewID FROM TOURTRANSACTION FULL JOIN TOUR ON TOURTRANSACTION.TourID = TOUR.TourID WHERE TOURTRANSACTION.UserID = '" + ViewAll.LoginInfo.UserID + "'AND TOURTRANSACTION.ToDate < '"+ datetimeNow + "'";
            //Retrieve Up coming trips records
            SqlConnection con1 = new SqlConnection(connectionString);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlRetrieveData, con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con1.Open();
            foreach (DataRow item in dt1.Rows)
            {
                int n = dtGridViewPass.Rows.Add();
                dtGridViewPass.Rows[n].Cells[0].Value = item["TransID"].ToString();
                dtGridViewPass.Rows[n].Cells[1].Value = item["TourID"].ToString();
                dtGridViewPass.Rows[n].Cells[2].Value = item["TName"].ToString();
                dtGridViewPass.Rows[n].Cells[3].Value = item["Pax"].ToString();
                dtGridViewPass.Rows[n].Cells[4].Value = Convert.ToDateTime(item["FromDate"]).ToString("dd/MM/yyy");
                dtGridViewPass.Rows[n].Cells[5].Value = Convert.ToDateTime(item["ToDate"]).ToString("dd/MM/yyy");
        
                if(item["ReviewID"].ToString() != "")
                {
                    dtGridViewPass.Rows[n].Cells[6] = new DataGridViewTextBoxCell { Value = "Reviewed" };
                    dtGridViewPass.Rows[n].Cells[6 + 1] = new DataGridViewTextBoxCell { Value = "" };
                    dtGridViewPass.Rows[n].Cells[6].ReadOnly = true;
                    dtGridViewPass.Rows[n].Cells[6 + 1].ReadOnly = true;
                }
            }
            con1.Close();
        }

        private void dtGridViewPass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==6)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string tourID = dtGridViewPass.Rows[rowIndex].Cells[1].Value.ToString();
                string transID = dtGridViewPass.Rows[rowIndex].Cells[0].Value.ToString();
                InsertReview(1,tourID,transID);
                MessageBox.Show("Tour Reviewed. Thank You");
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex] = new DataGridViewTextBoxCell { Value = "Reviewed" };
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex + 1] = new DataGridViewTextBoxCell { Value = "" };
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex].ReadOnly = true;
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex + 1].ReadOnly = true;
                
            }
            if (e.ColumnIndex == 7)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string tourID = dtGridViewPass.Rows[rowIndex].Cells[1].Value.ToString();
                string transID = dtGridViewPass.Rows[rowIndex].Cells[0].Value.ToString();
                InsertReview(0, tourID, transID);
                MessageBox.Show("Tour Reviewed. Thank You");

                dtGridViewPass.Rows[rowIndex].Cells[columnIndex -1] = new DataGridViewTextBoxCell { Value = "Reviewed" };
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex] = new DataGridViewTextBoxCell { Value = "" };
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex].ReadOnly = true;
                dtGridViewPass.Rows[rowIndex].Cells[columnIndex - 1].ReadOnly = true;
            }
        }
        private void InsertReview(int rating, string tourid,string transid)
        {
            string reviewID = "R";
            for (int i = 0; i < 7; i++)
            {
                reviewID = reviewID + Convert.ToString(random.Next(1, 9));
            }
            SqlConnection con = new SqlConnection(connectionString);
            string sqlRetrieveCountry = "INSERT INTO REVIEW (ReviewID, TourID, UserID, Ratings) VALUES (@reviewid, @tourid, @userid, @ratings)";
            SqlCommand cm = new SqlCommand(sqlRetrieveCountry, con);
            con.Open();
            cm.Parameters.AddWithValue("@reviewid", reviewID);
            cm.Parameters.AddWithValue("@tourid", tourid);
            cm.Parameters.AddWithValue("@userid", ViewAll.LoginInfo.UserID);
            cm.Parameters.AddWithValue("@ratings", rating);
            cm.ExecuteNonQuery();
            con.Close();

            SqlConnection con1 = new SqlConnection(connectionString);
            string sqlRetrieveCountry1 = "UPDATE TOURTRANSACTION SET ReviewID = @reviewid WHERE TransID = @transid";
            SqlCommand cm1 = new SqlCommand(sqlRetrieveCountry1, con1);
            con1.Open();
            cm1.Parameters.AddWithValue("@reviewid", reviewID);
            cm1.Parameters.AddWithValue("@transid", transid);

            cm1.ExecuteNonQuery();
            con1.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewAll openViewAll = new ViewAll();
            openViewAll.Show();
        }
    }
}
