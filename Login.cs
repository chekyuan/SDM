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
    public partial class Login : Form
    {

        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string fullname = "";
                string userID = "";
                string userRole = "";
                SqlConnection con = new SqlConnection(connectionString);
                string sqlRetrieveCountry = "SELECT Email, Password, UserID, FullName, UserRole " +
                                            "FROM TUSERS " +
                                            "WHERE Email = '" + username + "' AND Password = '" + password + "'";
                SqlCommand cm = new SqlCommand(sqlRetrieveCountry, con);
                con.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Email"].ToString() == username && dr["Password"].ToString() == password)
                    {
                        userID = dr["UserID"].ToString();
                        fullname = dr["FullName"].ToString();
                        userRole = dr["UserRole"].ToString();
                    }
                }

                if (userID != "")
                {
                    ViewAll.LoginInfo.UserID = userID;
                    ViewAll.LoginInfo.FullName = fullname;
                    ViewAll.LoginInfo.UserRole = userRole;
                    MessageBox.Show("Login successful");

                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong. Try Again");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and Password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgetPassword openForgetPassword = new ForgetPassword();
            openForgetPassword.ShowDialog();
        }
    }
}
