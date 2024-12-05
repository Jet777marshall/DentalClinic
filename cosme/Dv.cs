using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cosme
{
    public partial class Dv : Form
    {
        public Dv()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT * FROM d_records";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Remove the 'password' column from the DataTable
            dt.Columns.Remove("Passwords");
            dt.Columns.Remove("Date");

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
