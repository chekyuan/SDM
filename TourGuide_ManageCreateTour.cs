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
    public partial class TourGuide_ManageCreateTour : Form
    {
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        public TourGuide_ManageCreateTour()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        private void TourGuide_ManageCreateTour_Load(object sender, EventArgs e)
        {
            //edit btn
            DataGridViewButtonColumn btnModify = new DataGridViewButtonColumn();
            btnModify.HeaderText = "";
            btnModify.Name = "modifyTour";
            btnModify.Text = "Modify";
            btnModify.UseColumnTextForButtonValue = true;
            dtGridViewManageTour.Columns.Add(btnModify);

            //delete btn
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "deleteTour";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dtGridViewManageTour.Columns.Add(btnDelete);
            RetrieveTours();

            DataGridViewButtonColumn btnAccept = new DataGridViewButtonColumn();
            btnAccept.HeaderText = "";
            btnAccept.Name = "acceptRequest";
            btnAccept.Text = "Accept";
            btnAccept.UseColumnTextForButtonValue = true;
            dtManageTourRequest.Columns.Add(btnAccept);

            //delete btn
            DataGridViewButtonColumn btnReject = new DataGridViewButtonColumn();
            btnReject.HeaderText = "";
            btnReject.Name = "rejectRequest";
            btnReject.Text = "Reject";
            btnReject.UseColumnTextForButtonValue = true;
            dtManageTourRequest.Columns.Add(btnReject);
            RetrieveRquest();
        }
        private void RetrieveTours()
        {
            string likes = "";
            string dislike = "";
            string sqlRetrieveData = "SELECT t1.TourID, t1.TCountry , t1.TName, t1.TCost, t1.TDuration, t2.LIKES ,t3.DISLIKE " +
                "FROM (SELECT TourID, TName, TCost,TDuration, TCountry FROM TOUR WHERE UserID = '" + ViewAll.LoginInfo.UserID +"') t1 " +
                "FULL JOIN " +
                "(SELECT REVIEW.TourID, COUNT(Ratings) AS LIKES FROM REVIEW INNER JOIN TOUR ON REVIEW.TourID = TOUR.TourID WHERE Ratings = 1 AND TOUR.UserID = '" + ViewAll.LoginInfo.UserID + "' GROUP BY REVIEW.TourID) t2 " +
                "ON t1.TourID = t2.TourID " +
                "FULL JOIN " +
                "(SELECT REVIEW.TourID, COUNT(Ratings) AS DISLIKE FROM REVIEW INNER JOIN TOUR ON REVIEW.TourID = TOUR.TourID WHERE Ratings = 0 AND TOUR.UserID = '" + ViewAll.LoginInfo.UserID + "' GROUP BY REVIEW.TourID) t3 " +
                "ON t1.TourID = t3.TourID";
            //Retrieve Up coming trips records
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            foreach (DataRow item in dt.Rows)
            {
                int n = dtGridViewManageTour.Rows.Add();
                dtGridViewManageTour.Rows[n].Cells[0].Value = item["TourID"].ToString();
                dtGridViewManageTour.Rows[n].Cells[1].Value = item["TName"].ToString();
                dtGridViewManageTour.Rows[n].Cells[2].Value = item["TCountry"].ToString();
                dtGridViewManageTour.Rows[n].Cells[3].Value = "$"+item["TCost"].ToString();
                dtGridViewManageTour.Rows[n].Cells[4].Value = item["TDuration"].ToString();
                dtGridViewManageTour.Rows[n].Cells[5].Value = item["LIKES"].ToString();
                dtGridViewManageTour.Rows[n].Cells[6].Value = item["DISLIKE"].ToString();
               


            }
            con.Close();
        }

        private void dtGridViewManageTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string tourID = dtGridViewManageTour.Rows[rowIndex].Cells[0].Value.ToString();
                TourGuide_ModifyTour openModifyTour = new TourGuide_ModifyTour(tourID);
                openModifyTour.ShowDialog();
                dtGridViewManageTour.Rows.Clear();
                RetrieveTours();

            }
            if (e.ColumnIndex == 8)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string tourID = dtGridViewManageTour.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Tour.", "Alert!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   DeleteTour(tourID);
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                
            }
        }
       
        
        private void RetrieveRquest()
        {
            string sqlRetrieveData = "SELECT TOURTRANSACTION.TransID, TOUR.TName, TUSERS.FullName, TUSERS.Email, TOURTRANSACTION.Pax, TOURTRANSACTION.FromDate " +
                "FROM TOUR,TUSERS,TOURTRANSACTION " +
                "WHERE TOURTRANSACTION.TourID = TOUR.TourID AND TOURTRANSACTION.UserID = TUSERS.UserID AND TOURTRANSACTION.TStatus = 'Pending' AND TOUR.UserID = '"+ ViewAll.LoginInfo.UserID+"' ";
            //Retrieve Up coming trips records
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            foreach (DataRow item in dt.Rows)
            {
                int n = dtManageTourRequest.Rows.Add();
                dtManageTourRequest.Rows[n].Cells[0].Value = item["TransID"].ToString();
                dtManageTourRequest.Rows[n].Cells[1].Value = item["TName"].ToString();
                dtManageTourRequest.Rows[n].Cells[2].Value = item["FullName"].ToString();
                dtManageTourRequest.Rows[n].Cells[3].Value = item["Email"].ToString();
                dtManageTourRequest.Rows[n].Cells[4].Value = item["Pax"].ToString();
                dtManageTourRequest.Rows[n].Cells[5].Value = Convert.ToDateTime(item["FromDate"]).ToString("dd/MM/yyy");

            }
            con.Close();
        }
        private void DeleteTour(string tourid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "DELETE FROM TOUR WHERE TourID = @tourid";
            SqlCommand cm = new SqlCommand(sql, con);
            con.Open();
            cm.Parameters.AddWithValue("@tourid", tourid);
            cm.ExecuteNonQuery();
            con.Close();

            SqlConnection con1 = new SqlConnection(connectionString);
            string sql1 = "DELETE FROM REVIEW WHERE TourID = @tourid";
            SqlCommand cm1 = new SqlCommand(sql1, con1);
            con1.Open();
            cm1.Parameters.AddWithValue("@tourid", tourid);

            cm1.ExecuteNonQuery();
            con1.Close();
            dtGridViewManageTour.Rows.Clear();
            RetrieveTours();
           
        }

        private void dtManageTourRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string transID = dtManageTourRequest.Rows[rowIndex].Cells[0].Value.ToString();

                UpdateRequest(transID, "Accept" );
                MessageBox.Show("Tour Accepted.");
                dtManageTourRequest.Rows.Clear();
                RetrieveRquest();
            }
            if (e.ColumnIndex == 7)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string transID = dtManageTourRequest.Rows[rowIndex].Cells[0].Value.ToString();
                UpdateRequest(transID, "Reject");
                MessageBox.Show("Tour Rejected.");
                dtManageTourRequest.Rows.Clear();
                RetrieveRquest();

            }
        }
        private void UpdateRequest(string transid, string status)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "UPDATE TOURTRANSACTION SET TStatus = @status WHERE TransID = @transid";
            SqlCommand cm = new SqlCommand(sql, con);
            con.Open();
            cm.Parameters.AddWithValue("@status", status);
            cm.Parameters.AddWithValue("@transid", transid);

            cm.ExecuteNonQuery();

            con.Close();
        }

        private void btnCreateTour_Click(object sender, EventArgs e)
        {
            string tName = txtName.Text;
            string tcountry = txtCountry.Text;
            string tDuration = txtDuration.Text;
            string tCost = txtCost.Text;
            string tDescription = txtDescription.Text;
            int intDuration;
            int intCost;
            bool checkDuration = int.TryParse(tDuration, out intDuration);
            bool checkcost = int.TryParse(tCost, out intCost);
            if (tName== "" || tcountry == "" || tDuration == "" || tCost == "" || tDescription == "")
            {
                MessageBox.Show("Please fill in the relevant fields");
            }
            else if (checkcost == false)
            {
                MessageBox.Show("Cost must be in numeric");
            }
            else if (checkDuration == false)
            {
                MessageBox.Show("Duration must be in numeric");
            }
            else
            {
                string tourID = "G";
                for (int i = 0; i < 7; i++)
                {
                    tourID = tourID + Convert.ToString(random.Next(1, 9));
                }

                SqlConnection con = new SqlConnection(connectionString);
                string sqlInsertCountry = "INSERT INTO TOUR (TourID, UserID, TCost, TDescription, TName, TCountry, TDuration) " +
                    "VALUES (@tourid, @userid, @tcost, @tdescription, @tname, @tcountry, @tduration)";
                SqlCommand cm = new SqlCommand(sqlInsertCountry, con);
                con.Open();
                cm.Parameters.AddWithValue("@tourid", tourID);
                cm.Parameters.AddWithValue("@userid", ViewAll.LoginInfo.UserID);
                cm.Parameters.AddWithValue("@tcost", intCost);
                cm.Parameters.AddWithValue("@tdescription", tDescription);
                cm.Parameters.AddWithValue("@tname", tName);
                cm.Parameters.AddWithValue("@tcountry", tcountry);
                cm.Parameters.AddWithValue("@tduration", intDuration);

                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Tour Created!");
                dtGridViewManageTour.Rows.Clear();
                RetrieveTours();
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllChat showAllchat = new ShowAllChat();
            showAllchat.ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ViewAll.LoginInfo.UserID = "";
            ViewAll.LoginInfo.TourID = "";
            ViewAll.LoginInfo.UserRole = "";
            ViewAll.LoginInfo.FullName = "";
            this.Close();
            ViewAll openViewAll = new ViewAll();
            openViewAll.Show();
        }
    }
}
