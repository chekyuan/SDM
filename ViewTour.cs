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
    public partial class ViewTour : Form
    {
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";
        public ViewTour()
        {
            InitializeComponent();
            
        }

        private void ViewTour_Load(object sender, EventArgs e)
        {
            //ComboBox default Value
            cbPax.SelectedIndex = 0;
            //Load Tour Details 
            SqlConnection con = new SqlConnection(connectionString);
            string sqlRetrieveCountry = "SELECT TName, TCost,TDescription, TDuration " +
                                        "FROM TOUR " +
                                        "WHERE TourID = '" + ViewAll.LoginInfo.TourID + "'";
            SqlCommand cm = new SqlCommand(sqlRetrieveCountry, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                lblTour.Text = dr["TName"].ToString();
                txtDescription.Text = dr["TDescription"].ToString();
                lblCost.Text = dr["TCost"].ToString();
                lblDuration.Text = dr["TDuration"].ToString() ;
            }
            con.Close();
            RetrieveChatID();
            RetrieveChatID();

        }

        private void calFrom_DateSelected(object sender, DateRangeEventArgs e)
        {
            int duration = int.Parse(lblDuration.Text) -1  ;
           string dateStart = calFrom.SelectionRange.Start.ToShortDateString();
            DateTime startDate = calFrom.SelectionRange.Start;
            DateTime endDate = startDate.AddDays(duration);
            lblSDate.Visible = true; 
            lblEDate.Visible = true;
            lblSDate.Text = startDate.ToShortDateString();
            lblEDate.Text = endDate.ToShortDateString();
            ViewTour.BookTour.tourStartDate = startDate.ToShortDateString();
            ViewTour.BookTour.tourEndDate = endDate.ToShortDateString();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ViewTour.BookTour.pax = int.Parse(cbPax.Text);

            this.Hide();
            Payment passPayment = new Payment();
            passPayment.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewAll.LoginInfo.TourID = "";
            ViewAll openViewAll = new ViewAll();
            openViewAll.Show();
        }
        public static class BookTour
        {
            public static int pax ;
            public static string tourStartDate = "";
            public static string tourEndDate = "";


        }
        private void RetrieveChatID()
        {
            string chatBefore = "";
            string sqlRetrieveData = "SELECT DISTINCT ChatID FROM CHAT WHERE UserID = '" + ViewAll.LoginInfo.UserID + "' AND TourID = '" + ViewAll.LoginInfo.TourID + "'";
    
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            foreach (DataRow item in dt.Rows)
            {

                chatBefore = item["ChatID"].ToString();

            }
            con.Close();
            if(chatBefore != "")
            {
                btnChat.Enabled = false;
                btnChat.Text = "You have chatted before with Tour Guide";
            }
        }
        private void btnChat_Click(object sender, EventArgs e)
        {
            this.Hide();
            string chatID = "";
            TourChat opentourGuideChat = new TourChat(ViewAll.LoginInfo.TourID, ViewAll.LoginInfo.UserID, chatID);
            opentourGuideChat.ShowDialog();
        }
    }
}
