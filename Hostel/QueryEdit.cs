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

namespace Hostel
{
    public partial class QueryEdit : Form
    {

        private const string ConnectionString =
            @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tazik\Desktop\Hostel\Hostel\Hostel.mdf;Integrated Security=True";

        public QueryEdit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Text = "SELECT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sqlconn = new SqlConnection(ConnectionString))
                {
                    sqlconn.Open();
                    var oda = new SqlDataAdapter(TestInput.Text, sqlconn);
                    var dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            
            
        }
    }
}
