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
using System.Xml.Linq;

namespace cosme
{
    public partial class doc : Form
    {
        public doc()
        {
            InitializeComponent();
        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT * FROM p_records";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            pv.DataSource = dt;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            Hide();
        }

        private void btnmv_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT * FROM m_records";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            mv.DataSource = dt;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtproce.Text) || string.IsNullOrWhiteSpace(txtprice.Text))  
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string connection = "server=localhost;user id=root;password=;database= cosme";
                string query = "INSERT INTO price_records(`PROCEDURE NAME`,`PROCEDURE PRICE`) VALUES('" + this.txtproce.Text + "','" + this.txtprice.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully saved");
                conn.Close();
                txtprice.Text = "";
                txtproce.Text = "";

            }
   

         
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtproce.Text) || string.IsNullOrWhiteSpace(txtprice.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string connection = "server=localhost;user id=root;password=;database=cosme";
                string query = "UPDATE price_records SET `PROCEDURE NAME` = '" + this.txtproce.Text + "',`PROCEDURE PRICE` = '" + this.txtprice.Text + "' WHERE `PROCEDURE#` = '" + this.txtget.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated succesfully");
                conn.Close();

                txtget.Text = "";
                txtproce.Text = "";
                txtprice.Text = "";

            }
       
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtproce.Text) || string.IsNullOrWhiteSpace(txtprice.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string connection = "server=localhost;user id=root;password=;database=cosme";
                string query = "DELETE FROM price_records WHERE `PROCEDURE#` ='" + this.txtget.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Data has been succesfully deleted!!");
                conn.Close();
                txtget.Text = "";
                txtproce.Text = "";
                txtprice.Text = "";

            }
         
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT * FROM price_records";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            pricev.DataSource = dt;
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT`PROCEDURE NAME`,`PROCEDURE PRICE` FROM price_records WHERE `PROCEDURE#`= '" + this.txtget.Text + "'  ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {

                txtproce.Text = srd.GetValue(0).ToString();
                txtprice.Text = srd.GetValue(1).ToString();
       
               

            }

            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
