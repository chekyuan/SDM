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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";
        
        private void Payment_Load(object sender, EventArgs e)
        {

            lblPax.Text= ViewTour.BookTour.pax.ToString();
            lblFrom.Text = ViewTour.BookTour.tourStartDate;
            lblTo.Text = ViewTour.BookTour.tourEndDate;
            float totalCost = 0;
            SqlConnection con = new SqlConnection(connectionString);

            string sqlRetrieveCountry = "SELECT TName, TDescription, TCost " +
                                        "FROM TOUR " +
                                        "WHERE TourID = '" + ViewAll.LoginInfo.TourID  + "'";
            SqlCommand cm = new SqlCommand(sqlRetrieveCountry, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                lblTourName.Text = dr["TName"].ToString();
                txtDescription.Text = dr["TDescription"].ToString();
                totalCost = float.Parse(dr["TCost"].ToString());
            }
            con.Close();
             totalCost = totalCost * ViewTour.BookTour.pax;
            lblTotalCost.Text = "$" + totalCost.ToString();
        }
    }
}
