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

namespace breadpan
{
    public partial class SysAdmin_ManageUserTour : Form
    {
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        public SysAdmin_ManageUserTour()
        {
            InitializeComponent();
        }

        private void SysAdmin_ManageUserTour_Load(object sender, EventArgs e)
        {
            //edit btn
            DataGridViewButtonColumn btnDeleteTour = new DataGridViewButtonColumn();
            btnDeleteTour.HeaderText = "";
            btnDeleteTour.Name = "deleteTour";
            btnDeleteTour.Text = "Delete";
            btnDeleteTour.UseColumnTextForButtonValue = true;
            dtGridViewManageTour.Columns.Add(btnDeleteTour);
            RetrieveTour();

            DataGridViewButtonColumn btnModify = new DataGridViewButtonColumn();
            btnModify.HeaderText = "";
            btnModify.Name = "modifyUser";
            btnModify.Text = "Modify";
            btnModify.UseColumnTextForButtonValue = true;
            dtManageUser.Columns.Add(btnModify);

            DataGridViewButtonColumn btnDeleteUser = new DataGridViewButtonColumn();
            btnDeleteUser.HeaderText = "";
            btnDeleteUser.Name = "deleteUser";
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseColumnTextForButtonValue = true;
            dtManageUser.Columns.Add(btnDeleteUser);
            RetrieveUsers();
        }
        private void RetrieveUsers()
        {
            string userRoleFull ="";
            string sqlRetrieveUser = "SELECT UserID, FullName, UserRole FROM TUSERS WHERE UserRole = 'TG' OR UserRole = 'T'";
            //Retrieve Up coming trips records
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveUser, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            foreach (DataRow item in dt.Rows)
            {
                int n = dtManageUser.Rows.Add();
                dtManageUser.Rows[n].Cells[0].Value = item["UserID"].ToString();
                dtManageUser.Rows[n].Cells[1].Value = item["FullName"].ToString();
                if(item["UserRole"].ToString() == "T")
                {
                    userRoleFull = "Tourist";
                }
                else if (item["UserRole"].ToString() == "TG")
                {
                    userRoleFull = "Tour Guide";
                }
                dtManageUser.Rows[n].Cells[2].Value = userRoleFull.ToString();
            }
            con.Close();
        }
        private void RetrieveTour()
        {
            string sqlRetrieveTour = "SELECT TOUR.TourID, TOUR.TName, TUSERS.FullName FROM TOUR, TUSERS WHERE TOUR.UserID = TUSERS.UserID";
            //Retrieve Up coming trips records
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveTour, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                int n = dtGridViewManageTour.Rows.Add();
                dtGridViewManageTour.Rows[n].Cells[0].Value = dr["TourID"].ToString();
                dtGridViewManageTour.Rows[n].Cells[1].Value = dr["TName"].ToString();
                dtGridViewManageTour.Rows[n].Cells[2].Value = dr["FullName"].ToString();
            }
            con.Close();
         }
        private void DeleteUser(string userid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "DELETE FROM TUSERS WHERE UserID = @userid";
            SqlCommand cm = new SqlCommand(sql, con);
            con.Open();
            cm.Parameters.AddWithValue("@userid", userid);
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User "+userid + " Deleted");
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
            MessageBox.Show("Tour "+tourid + " deleted!");
        }

        private void dtGridViewManageTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string tourID = dtGridViewManageTour.Rows[rowIndex].Cells[0].Value.ToString();
                DeleteTour(tourID);
                dtGridViewManageTour.Rows.Clear();
                RetrieveTour();

            }
        }

        private void dtManageUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string userID = dtManageUser.Rows[rowIndex].Cells[0].Value.ToString();
                SysAdmin_EditUser openSysadminRemoveUser = new SysAdmin_EditUser(userID);
                openSysadminRemoveUser.ShowDialog();
                dtManageUser.Rows.Clear();
                RetrieveUsers();

            }
            if (e.ColumnIndex == 4)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string userID = dtManageUser.Rows[rowIndex].Cells[0].Value.ToString();
                DeleteUser(userID);
                dtManageUser.Rows.Clear();
                RetrieveUsers();

            }
        }
    }
}
