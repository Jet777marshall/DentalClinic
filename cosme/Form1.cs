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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PATIENTNAME.Text) || string.IsNullOrWhiteSpace(PROCEDURE.Text) ||
                   string.IsNullOrWhiteSpace(APPOINTMENT.Text) || string.IsNullOrWhiteSpace(TIME.Text) ||
                   string.IsNullOrWhiteSpace(DOCTOR.Text)|| string.IsNullOrWhiteSpace(ROOM.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string connection = "server=localhost;user id=root;password=;database= cosme";
                string query = "INSERT INTO p_records(PATIENT_NAME, `PROCEDURE`, APPOINTMENT, `TIME`, DOCTOR, ROOM) VALUES('" + this.PATIENTNAME.Text + "','" + this.PROCEDURE.Text + "','" + this.APPOINTMENT.Text + "','" + this.TIME.Text + "','" + this.DOCTOR.Text + "','" + this.ROOM.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;

                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully saved");
                conn.Close();

                PATIENTNAME.Text = "";
                PROCEDURE.Text = "";
                APPOINTMENT.Text = "";
                TIME.Text = "";
                ROOM.Text = "";
                DOCTOR.Text = "";
                PATIENTNO.Text = "";

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PATIENTNAME.Text) || string.IsNullOrWhiteSpace(PROCEDURE.Text) ||
                 string.IsNullOrWhiteSpace(APPOINTMENT.Text) || string.IsNullOrWhiteSpace(TIME.Text) ||
                 string.IsNullOrWhiteSpace(DOCTOR.Text) || string.IsNullOrWhiteSpace(ROOM.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string connection = "server=localhost;user id=root;password=;database=cosme";
                string query = "UPDATE p_records SET PATIENT_NAME = '" + this.PATIENTNAME.Text + "', `PROCEDURE`= '" + this.PROCEDURE.Text + "', APPOINTMENT= '" + this.APPOINTMENT.Text + "', `TIME`= '" + this.TIME.Text + "', DOCTOR= '" + this.DOCTOR.Text + "', ROOM= '" + this.ROOM.Text + "' WHERE PATIENT_NUMBER= '" + this.PATIENTNO.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated succesfully");
                conn.Close();

                PATIENTNAME.Text = "";
                PROCEDURE.Text = "";
                APPOINTMENT.Text = "";
                TIME.Text = "";
                ROOM.Text = "";
                DOCTOR.Text = "";
                PATIENTNO.Text = "";

            }
       
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT * FROM p_records";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PATIENTNO.Text))

            {
                MessageBox.Show("GET INFO", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string connection = "server=localhost;user id=root;password=;database=cosme";
                string query = "DELETE FROM p_records WHERE PATIENT_NUMBER ='" + this.PATIENTNO.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Data has been succesfully deleted!!");
                conn.Close();
                PATIENTNO.Text = "";
                PATIENTNAME.Text = "";
                PROCEDURE.Text = "";
                APPOINTMENT.Text = "";
                TIME.Text = "";
                ROOM.Text = "";
                DOCTOR.Text = "";

            }
          
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cosme";
            string query = "SELECT PATIENT_NAME,`PROCEDURE`,APPOINTMENT,`TIME`,DOCTOR,ROOM FROM p_records WHERE PATIENT_NUMBER= '" + this.PATIENTNO.Text + "'  ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {

                PATIENTNAME.Text = srd.GetValue(0).ToString();
                PROCEDURE.Text = srd.GetValue(1).ToString();
                APPOINTMENT.Text = srd.GetValue(2).ToString();
                TIME.Text = srd.GetValue(3).ToString();
                DOCTOR.Text = srd.GetValue(4).ToString();
                ROOM.Text = srd.GetValue(5).ToString();

            }

            conn.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            Hide();
        }

        private void btn_dlist_Click(object sender, EventArgs e)
        {
            Dv Dv = new Dv();
            Dv.Show();
           

        }

        private void btn_Mist_Click(object sender, EventArgs e)
        {
            Mv Mv = new Mv();
            Mv.Show();
            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {

            pv pv = new pv();
            pv.Show();

        }
    }
}
