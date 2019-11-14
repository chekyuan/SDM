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
        static Random random = new Random();
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            string cardName = txtCardName.Text;
            string cardNum = txtCardNum.ToString();
            string month = txtMonth.Text;
            string year = txtYear.Text;
            string cvv = txtCvv.Text;
            int monthInt;
            int yearInt;
            int cvvInt;
            string cvvLength = txtCvv.Text;
            DateTime dtNow = DateTime.Now;
            int yearNow = dtNow.Year;
            int monthNow = dtNow.Month;
            bool checkMonth = int.TryParse(month, out monthInt);
            bool checkYear = int.TryParse(year, out yearInt);
            bool checkCvv = int.TryParse(cvv, out cvvInt);
            if (cardName == "")
            {
                MessageBox.Show("Please enter Card Name");
            }
            else if (cardNum.Length < 17 || cardNum == null)
            {
                MessageBox.Show("Invalid Card Number");
            }
            else if (checkMonth == false || checkYear == false || checkCvv == false)
            {
                MessageBox.Show("Expiry Date and CVV must be in numeric");
            }
            else if (checkMonth == true && checkYear == true && checkCvv == true)
            {
                if (monthInt > 12 || monthInt < 1)
                {
                    MessageBox.Show("Invalid Expiry Month");
                }
                
                else if (yearInt < yearNow)
                {
                    MessageBox.Show("Invalid Expiry Date");
                }
                else if (yearInt == yearNow)
                {
                    if (monthInt < monthNow)
                    {
                        MessageBox.Show("Invalid Expiry Date");
                    }
                   
                }
                else if (cvvLength.Length < 3 || cvvInt > 1000 || cvvInt < 0)
                {
                    MessageBox.Show("Invalid CVV");
                }
                else
                {
                    string transID = "T";
                    for (int i = 0; i < 7; i++)
                    {
                        transID = transID + Convert.ToString(random.Next(1, 9));
                    }

                    SqlConnection con = new SqlConnection(connectionString);
                    string sqlRetrieveCountry = "INSERT INTO TOURTRANSACTION (TransID, UserID, TourID, FromDate, Pax, ToDate, TStatus) VALUES (@transid, @userid, @tourid, @fromdate, @pax, @todate, @tstatus)";
                    SqlCommand cm = new SqlCommand(sqlRetrieveCountry, con);
                    con.Open();
                    cm.Parameters.AddWithValue("@transid", transID.ToString());
                    cm.Parameters.AddWithValue("@userid", ViewAll.LoginInfo.UserID);
                    cm.Parameters.AddWithValue("@tourid", ViewAll.LoginInfo.TourID);
                    cm.Parameters.AddWithValue("@fromdate", Convert.ToDateTime(ViewTour.BookTour.tourStartDate).ToString("MM/dd/yyy"));
                    cm.Parameters.AddWithValue("@todate", Convert.ToDateTime(ViewTour.BookTour.tourEndDate).ToString("MM/dd/yyy"));
                    cm.Parameters.AddWithValue("@pax", ViewTour.BookTour.pax);
                    cm.Parameters.AddWithValue("@tstatus", "Pending");

                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Tour Booked, Enjoy!");
                    ViewAll openViewAll = new ViewAll();
                    openViewAll.Show();
                    this.Hide();

                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewTour openViewTour = new ViewTour();
            openViewTour.Show();
        }
    }
}
