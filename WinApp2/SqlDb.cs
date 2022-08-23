using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp2
{
    public partial class SqlDb : Form
    {
        public SqlDb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "data source=.; database=test; integrated security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "select * from Customer";
                con.Open();
                SqlDataAdapter sql = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "data source=.; database=test; integrated security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "Insert into Customer values('rodi', 'demss')" +
                           "Insert into Customer values('henki', 'bek')" +
                           "Insert into Customer values('mike', 'demsi')";
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(q, con);
                var result = sqlCommand.ExecuteNonQuery();
                MessageBox.Show(result.ToString()+"Rows Affected!");
            }
        }
    }
}
    