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
    public partial class ViewAll : Form
    {
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";


        public ViewAll()
        {
            InitializeComponent();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            //Populate ListView
            string sqlListAllTour = "SELECT TourID,TCost,TName,TCountry,FullName FROM TOUR FULL JOIN TUSERS ON TOUR.UserID = TUSERS.UserID";
            PopulateDataList(sqlListAllTour);
            FillCountryComboBox();
            if(LoginInfo.UserID != "")
            {
                btnLogin.Visible = false;
                btnSignUp.Visible = false;
                btnMyTrips.Visible = true;
                lblWelcome.Visible = true;
                lblWelcome.Text = "Welcome " + LoginInfo.FullName;
                
            }
            
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCountry = cbCountry.Text;
            if (searchCountry != ""  )
            {
                string sqlSearch = "SELECT TourID,TCost,TName,TCountry,FullName " +
                                "FROM TOUR FULL JOIN TUSERS ON TOUR.UserID = TUSERS.UserID WHERE TOUR.TCountry = \'" + searchCountry + "\'";
                PopulateDataList(sqlSearch);
            }
        }
        public void PopulateDataList(string sqlRetrieveData)
        {
            lstAllTour.Items.Clear();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

            
                DataRow dr = dt.Rows[i];
                ListViewItem itm = new ListViewItem(dr["TourID"].ToString());
                itm.SubItems.Add(dr["TName"].ToString());
                itm.SubItems.Add(dr["TCountry"].ToString());
               // itm.SubItems.Add(Convert.ToDateTime(dr["TDate"]).ToString("dd/MM/yyy"));
                itm.SubItems.Add("$"+dr["TCost"].ToString());
                itm.SubItems.Add(dr["FullName"].ToString());
   
                lstAllTour.Items.Add(itm);
            }
            con.Close();
        }
        public void FillCountryComboBox()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sqlRetrieveCountry = "SELECT DISTINCT TCountry FROM TOUR";
            SqlCommand cm = new SqlCommand(sqlRetrieveCountry, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while(dr.Read())
            {
                cbCountry.Items.Add(dr["TCountry"]);

            }
            con.Close();
            //Combobox default value
            cbCountry.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sqlListAllTour = "SELECT TourID,TCost,TName,TCountry,FullName FROM TOUR FULL JOIN TUSERS ON TOUR.UserID = TUSERS.UserID";
            PopulateDataList(sqlListAllTour);
           
        }

        private void lstAllTour_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string passtourID = lstAllTour.SelectedItems[0].SubItems[0].Text;
            LoginInfo.TourID = passtourID;
            //Check if User Login
            if (LoginInfo.UserID == "")
            {
                MessageBox.Show("Please Login to continue.");
                this.Hide();
                Login openLoginForm = new Login();
                openLoginForm.ShowDialog();
                ViewTour openViewTourForm = new ViewTour();
                openViewTourForm.Show();
            }
            else
            {
                //Store in static class so other forms can get values
                ViewTour openViewTourForm = new ViewTour();
                openViewTourForm.Show();
                this.Hide();
            }
            
            /*ViewTour openViewTour = new ViewTour(passtourID);*/
            //openViewTour.ShowDialog();

        }
        public static class LoginInfo
        {
            public static string UserID ="";
            public static string TourID = "";
            public static string FullName = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login openLoginForm = new Login();
            openLoginForm.ShowDialog();
            ViewAll openViewAllForm = new ViewAll();
            openViewAllForm.Show();
        }
    }
}
