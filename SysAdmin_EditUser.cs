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
    public partial class SysAdmin_EditUser : Form
    {
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";
        string userID;
        public SysAdmin_EditUser(string userid)
        {
            InitializeComponent();
            userID = userid;
        }

       
        private void SysAdmin_RemoveUser_Load(object sender, EventArgs e)
        {
            string sqlRetrieveData = "SELECT FullName, Password, Address, UserRole, Email FROM TUSERS WHERE UserID = '"+userID+"'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                txtName.Text = dr["FullName"].ToString();
                txtPassword.Text = dr["Password"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtUserRole.Text = dr["UserRole"].ToString();
            }
            con.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string userole = txtUserRole.Text;
            MessageBox.Show(userole);
            if (name == "" || password == "" || address == "" || email == "" || userole == "")
            {
                MessageBox.Show("Please fill in the relevant fields");
            }
            else if (userole != "TG" && userole != "T" && userole != "S")
            {
                MessageBox.Show("User Role must be either TG or T or S");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                string sql = "UPDATE TUSERS SET FullName = @name, Password = @password, Address = @address, Email = @email, UserRole = @userole " +
                    " WHERE UserID = @userid";
                SqlCommand cm = new SqlCommand(sql, con);
                con.Open();
                cm.Parameters.AddWithValue("@name", name);
                cm.Parameters.AddWithValue("@password", password);
                cm.Parameters.AddWithValue("@address", address);
                cm.Parameters.AddWithValue("@email", email);
                cm.Parameters.AddWithValue("@userole", userole);
                cm.Parameters.AddWithValue("@userid", userID);


                cm.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("User account updated!");
                this.Close();
            }
        }
    }
}
