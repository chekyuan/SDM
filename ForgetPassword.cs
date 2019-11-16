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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        //Bruce's connection string
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password ="";
            string sqlRetrieveData = "SELECT Password FROM TUSERS WHERE Email = '" + email + "'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                password = dr["Password"].ToString();
            }
            con.Close();
            if(password == "")
            {
                MessageBox.Show("Email Not Found, Try again");
            }
            else
            {
                MessageBox.Show("Email Found! Password is "+password);
                this.Close();
            }
        }
    }
}
