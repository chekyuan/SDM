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
    public partial class TourGuide_ModifyTour : Form
    {
        string tourID;
        public TourGuide_ModifyTour(string passTourID)
        {
            InitializeComponent();
            tourID = passTourID;
        }
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        private void TourGuide_ModifyTour_Load(object sender, EventArgs e)
        {
            string sqlRetrieveData = "SELECT TCost, TDescription, TName, TCountry, TDuration FROM TOUR WHERE TourID = '"+tourID+"'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                txtName.Text = dr["TName"].ToString();
                txtDuration.Text = dr["TDuration"].ToString();
                txtDescription.Text = dr["TDescription"].ToString();
                txtCountry.Text = dr["TCountry"].ToString();
                txtCost.Text = dr["TCost"].ToString();
               
            }
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
            if (tName == "" || tcountry == "" || tDuration == "" || tCost == "" || tDescription == "")
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
                SqlConnection con = new SqlConnection(connectionString);
                string sql = "UPDATE TOUR SET TCost = @cost,TDescription = @description, TName = @name, TCountry = @country, TDuration = @duration " +
                    " WHERE TourID = @tourid";
                SqlCommand cm = new SqlCommand(sql, con);
                con.Open();
                cm.Parameters.AddWithValue("@cost", intCost);
                cm.Parameters.AddWithValue("@description", tDescription);
                cm.Parameters.AddWithValue("@name", tName);
                cm.Parameters.AddWithValue("@country", tcountry);
                cm.Parameters.AddWithValue("@duration", intDuration);
                cm.Parameters.AddWithValue("@tourid", tourID);


                cm.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Tour Updated!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
