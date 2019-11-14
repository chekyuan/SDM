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
    public partial class ShowAllChat : Form
    {
        public ShowAllChat()
        {
            InitializeComponent();
        }
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        private void ShowAllChat_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnShowChat = new DataGridViewButtonColumn();
            btnShowChat.HeaderText = "";
            btnShowChat.Name = "ShowChat";
            btnShowChat.Text = "Chat";
            btnShowChat.UseColumnTextForButtonValue = true;
            dtGridViewAllChat.Columns.Add(btnShowChat);
            RetrieveChat();
        }
        private void RetrieveChat()
        {
            string sqlRetrieveData = ""; 
           // dtGridViewAllChat.Columns[4].HeaderText = "asdasdasd";
           if (ViewAll.LoginInfo.UserRole == "TG")
            {
                 sqlRetrieveData = "SELECT TUSERS.UserID,  TUSERS.FullName, CHAT.ChatID,  CHAT.TourID, TOUR.TName FROM CHAT, TOUR, TUSERS WHERE CHAT.TourID = TOUR.TourID AND Chat.UserID = TUSERS.UserID AND CHAT.Role = 'T' AND TOUR.UserID = '" + ViewAll.LoginInfo.UserID + "' GROUP BY CHAT.TourID, TOUR.TName,TUSERS.UserID, TUSERS.FullName, CHAT.ChatID";
                //Retrieve Up coming trips records
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Open();
                foreach (DataRow item in dt.Rows)
                {
                   
                    int n = dtGridViewAllChat.Rows.Add();
                    dtGridViewAllChat.Rows[n].Cells[0].Value = item["ChatID"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[1].Value = item["TourID"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[2].Value = item["TName"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[3].Value = item["UserID"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[4].Value = item["FullName"].ToString();
                }
                con.Close();
            }
            else
            {
                dtGridViewAllChat.Columns[3].HeaderText = "TourGuide ID";
                dtGridViewAllChat.Columns[4].HeaderText = "";
                sqlRetrieveData = "SELECT TOUR.UserID, CHAT.ChatID,  CHAT.TourID, TOUR.TName FROM CHAT, TOUR, TUSERS WHERE CHAT.TourID = TOUR.TourID AND CHAT.UserID = TUSERS.UserID AND CHAT.Role = 'T' AND TUSERS.UserID = '" + ViewAll.LoginInfo.UserID + "' GROUP BY CHAT.TourID, TOUR.TName,TOUR.UserID, CHAT.ChatID";
                //Retrieve Up coming trips records
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Open();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dtGridViewAllChat.Rows.Add();
                    dtGridViewAllChat.Rows[n].Cells[0].Value = item["ChatID"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[1].Value = item["TourID"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[2].Value = item["TName"].ToString();
                    dtGridViewAllChat.Rows[n].Cells[3].Value = item["UserID"].ToString();

                }
                con.Close();
            }
            
        }

        private void dtGridViewAllChat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                    int columnIndex = e.ColumnIndex;
                    int rowIndex = e.RowIndex;
                    string tourid = dtGridViewAllChat.Rows[rowIndex].Cells[1].Value.ToString();
                    string touristID = dtGridViewAllChat.Rows[rowIndex].Cells[3].Value.ToString();
                    string chatid = dtGridViewAllChat.Rows[rowIndex].Cells[0].Value.ToString();
                     
                    TourChat openTourChat = new TourChat(tourid, touristID, chatid);
                    openTourChat.Show();
                   this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(ViewAll.LoginInfo.UserRole == "T") 
            {
                this.Close();
                ViewAll openViewAll = new ViewAll();
                openViewAll.Show();
            }
            else if(ViewAll.LoginInfo.UserRole == "TG")
            {
                this.Close();
                TourGuide_ManageCreateTour openManageTour = new TourGuide_ManageCreateTour();
                openManageTour.Show();
            }


        }
    }
   
    
}
