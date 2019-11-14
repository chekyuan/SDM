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
    public partial class TourChat : Form
    {
        string tourID = "";
        string touristID = "";
        string chatID = "";
        public TourChat(string tourId, string touristUserID, string chatid)
        {
            tourID = tourId;
            touristID = touristUserID;
            chatID = chatid;
            InitializeComponent();
        }
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";
        static Random random = new Random();
        private void txtReply_Click(object sender, EventArgs e)
        {
            
            if (chatID == "")
            {
                chatID = "C";
                for (int i = 0; i < 7; i++)
                {
                    chatID = chatID + Convert.ToString(random.Next(1, 9));
                }
            }
            string reply = txtReply.Text;
            if (reply == "" )
            {
                MessageBox.Show("Type in something to Reply");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                string sqlInsertCountry = "INSERT INTO CHAT (ChatID,TourID, UserID, Reply, Role) " +
                    "VALUES (@chatID, @tourid, @userid, @reply, @role)";
                SqlCommand cm = new SqlCommand(sqlInsertCountry, con);
                con.Open();
                cm.Parameters.AddWithValue("@chatID", chatID);
                cm.Parameters.AddWithValue("@tourid", tourID);
                cm.Parameters.AddWithValue("@userid", ViewAll.LoginInfo.UserID);
                cm.Parameters.AddWithValue("@reply", reply);
                cm.Parameters.AddWithValue("@role", ViewAll.LoginInfo.UserRole);
                
                cm.ExecuteNonQuery();
                con.Close();
            }
            dtChat.Rows.Clear();
            RetrieveChat();
        }

        private void TourGuideChat_Load(object sender, EventArgs e)
        {
            if(chatID == "")
            {
                btnSatisfied.Visible = false;
            }
            else if(ViewAll.LoginInfo.UserRole == "TG")
            {
                btnSatisfied.Visible = false;
            }
            else
            {
                btnSatisfied.Visible = true;
            }
            RetrieveChat();
        }
       
        private void RetrieveChat()
        {
            string sqlRetrieveData = sqlRetrieveData = "SELECT CHAT.Role, CHAT.Reply, TUSERS.FullName FROM CHAT, TUSERS WHERE CHAT.ChatID = '"+ chatID + "' AND CHAT.UserID = TUSERS.UserID AND CHAT.TourID = '" + tourID +"'";
           
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            foreach (DataRow item in dt.Rows)
            {
                string role = "";
                int n = dtChat.Rows.Add();
                if(ViewAll.LoginInfo.UserRole == "TG" && item["Role"].ToString() == "TG")
                {
                    role = "You";
                }
                else if (ViewAll.LoginInfo.UserRole == "T" && item["Role"].ToString() == "T")
                {
                    role = "You";
                }
                else
                {
                    role = item["FullName"].ToString();
                }
                dtChat.Rows[n].Cells[0].Value = role;
                dtChat.Rows[n].Cells[1].Value = item["Reply"].ToString();

            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (ViewAll.LoginInfo.UserRole == "T")
            {
                if(ViewAll.LoginInfo.TourID != "")
                {
                    this.Close();
                    ViewTour openViewTour = new ViewTour();
                    openViewTour.Show();
                }
                else
                {
                    this.Close();
                    ShowAllChat openAllChat = new ShowAllChat();
                    openAllChat.Show();
                }
                
            }
            else if (ViewAll.LoginInfo.UserRole == "TG")
            {
                ShowAllChat openAllChat = new ShowAllChat();
                openAllChat.Show();
                this.Close();
            }
          
        }

        private void btnSatisfied_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chat history will be cleared.","Alert!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con1 = new SqlConnection(connectionString);
                string sql1 = "DELETE FROM CHAT WHERE ChatID = @chatid";
                SqlCommand cm1 = new SqlCommand(sql1, con1);
                con1.Open();
                cm1.Parameters.AddWithValue("@chatid", chatID);

                cm1.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Chat as been deleted");
                this.Close();
                ShowAllChat openShowAllChat = new ShowAllChat();
                openShowAllChat.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
       
    }
}
