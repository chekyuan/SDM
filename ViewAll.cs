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
    public partial class ViewAll : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruce\source\repos\SDM\breadpan.mdf;Integrated Security=True");
        public ViewAll()
        {
            InitializeComponent();
          
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TourID,TourCost,TDate,TName,FullName FROM TOUR FULL JOIN TUSERS ON TOUR.UserID = TUSERS.UserID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for(int i = 0; i<dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem itm = new ListViewItem(dr["TourID"].ToString());
                itm.SubItems.Add(dr["FullName"].ToString());
                itm.SubItems.Add(dr["TourCost"].ToString());
                itm.SubItems.Add(dr["TDate"].ToString());
                itm.SubItems.Add(dr["TName"].ToString());
                lstAllTour.Items.Add(itm);

            }
        }

 
    }
}
