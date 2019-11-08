using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace breadpan
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        //Bruce's connection string
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True";
        //Chek's connection string  
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choke\source\repos\breadpan\breadpan.mdf;Integrated Security=True";

        private void Test_Load(object sender, EventArgs e)
        {
            string id = "";
            string datetimeNow = DateTime.Now.ToString("yyyy/MM/dd");
            MessageBox.Show(datetimeNow);
            string sqlRetrieveData = "SELECT TransID, FromDate FROM TOURTRANSACTION WHERE FromDate < '"+ datetimeNow + "'";
            //string sqlRetrieveData = "SELECT TransID, FromDate FROM TOURTRANSACTION";

            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlRetrieveData, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["FromDate"].ToString();

              
            }
            con.Close();
            
           // string date = Convert.ToDateTime(DateTime.Now).ToString("MM/dd/yyyy");
            
        }
    }
}
