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
    public partial class Register : Form
    {

        //Bruce's connection string
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }
        static Random random = new Random();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPass.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string userole = "";
            if (name == "" || password == "" || address == "" || email == ""  || confirmPassword == "")
            {
                MessageBox.Show("Please fill in the relevant fields");
            }
            else
            {
                if (password == confirmPassword)
                {
                    if (rbT.Checked == true)
                    {
                        userole = "T";
                    }
                    else
                    {
                        userole = "TG";
                    }
                    string userChara = "U";
                    for (int i = 0; i < 7; i++)
                    {
                        userChara = userChara + Convert.ToString(random.Next(1, 9));
                    }
                    SqlConnection con = new SqlConnection(connectionString);
                    string sqlInsertCountry = "INSERT INTO TUSERS (UserID, Password, FullName, Address, UserRole, Email) " +
                        "VALUES (@userid, @password, @fullname, @address, @userrole, @email)";
                    SqlCommand cm = new SqlCommand(sqlInsertCountry, con);
                    con.Open();
                    cm.Parameters.AddWithValue("@userid", userChara);
                    cm.Parameters.AddWithValue("@password", password);
                    cm.Parameters.AddWithValue("@fullname", name);
                    cm.Parameters.AddWithValue("@address", address);
                    cm.Parameters.AddWithValue("@userrole", userole);
                    cm.Parameters.AddWithValue("@email", email);

                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Registered");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match. Try again");
                }
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
