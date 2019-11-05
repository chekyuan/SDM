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
            label12.Text = ViewAll.LoginInfo.UserID;
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

        }

        private void calFrom_DateSelected(object sender, DateRangeEventArgs e)
        {
            int duration = int.Parse(lblDuration.Text);
           string dateStart = calFrom.SelectionRange.Start.ToShortDateString();
            DateTime startDate = calFrom.SelectionRange.Start;
            DateTime endDate = startDate.AddDays(duration);
            lblSDate.Visible = true; 
            lblEDate.Visible = true;
            lblSDate.Text = startDate.ToShortDateString();
            lblEDate.Text = endDate.ToShortDateString();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment passPayment = new Payment();
            passPayment.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewAll.LoginInfo.TourID = "";
        }
    }
}
