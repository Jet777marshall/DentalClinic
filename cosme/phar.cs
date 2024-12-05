using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cosme
{
    public partial class phar : Form
    {
        public phar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtmn.Text) || string.IsNullOrWhiteSpace(txtq.Text) ||
                  string.IsNullOrWhiteSpace(txtp.Text))   
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string connection = "server=localhost;user id=root;password=;database= cosme";
                string query = "INSERT INTO m_records(`MEDICINE NAME`,STOCKS,PRICE) VALUES('" + this.txtmn.Text + "','" + this.txtq.Text + "','" + this.txtp.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully saved");
                conn.Close();

                txtmn.Text = "";
                txtq.Text = "";
                txtp.Text = "";

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtmn.Text) || string.IsNullOrWhiteSpace(txtq.Text) ||
                 string.IsNullOrWhiteSpace(txtp.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=cosme";
                string query = "UPDATE m_records SET `MEDICINE NAME` = '" + this.txtmn.Text + "', STOCKS = '" + this.txtq.Text + "', PRICE = '" + this.txtp.Text + "' WHERE `MEDICINE#` = '" + this.txtnumber.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated succesfully");
                conn.Close();

                txtmn.Text = "";
                txtq.Text = "";
                txtp.Text = "";
                txtnumber.Text = "";

            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtnumber.Text))
            {
                MessageBox.Show("NO INFO NUMBER", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string connection = "server=localhost;user id=root;password=;database=cosme";
                string query = "DELETE FROM m_records WHERE `MEDICINE#`  ='" + this.txtnumber.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Data has been succesfully deleted!!");
                conn.Close();

                txtmn.Text = "";
                txtq.Text = "";
                txtp.Text = "";
                txtnumber.Text = "";


            }
           
        
        
        }

        private void btnLoad_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT`MEDICINE NAME`,STOCKS,PRICE FROM m_records WHERE `MEDICINE#`= '" + this.txtnumber.Text + "'  ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {

                txtmn.Text = srd.GetValue(0).ToString();
                txtq.Text = srd.GetValue(1).ToString();
                txtp.Text = srd.GetValue(2).ToString();
               

            }

            conn.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            Hide();
        }
    }
}
