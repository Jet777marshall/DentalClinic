using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace cosme
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CAR CAR = new CAR();
            CAR.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (cbPosition.SelectedItem == null)
            {
                MessageBox.Show("Please choose an option before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {

                if (cbPosition.SelectedItem.ToString() == "Receptionist")
                {

                    string connectionString = "server=localhost;user id=root;password=;database=cosme";
                    string query = "SELECT * FROM r_records WHERE NAME = @Username AND PASSWORDS = @Password";

                    if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Please input Username and Password", "Error");
                    }
                    else
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {

                                        Form1 form1 = new Form1();
                                        form1.Show();
                                        Hide();
                                        MessageBox.Show("Login successful!", "Success");


                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed");
                                    }
                                }
                            }
                        }
                    }

                }
                //Receptionist log in


                //Receptionist log in
                if (cbPosition.SelectedItem.ToString() == "Doctor")
                {

                    string connectionString = "server=localhost;user id=root;password=;database=cosme";
                    string query = "SELECT * FROM d_records WHERE NAME = @Username AND PASSWORDS = @Password";

                    if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Please input Username and Password", "Error");
                    }
                    else
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {

                                        doc doc = new doc();
                                        doc.Show();
                                        Hide();
                                        MessageBox.Show("Login successful!", "Success");


                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed");
                                    }
                                }
                            }
                        }
                    }

                }
                //Receptionist log in



                //Pharmacologist log in
                if (cbPosition.SelectedItem.ToString() == "Pharmacologist")
                {

                    string connectionString = "server=localhost;user id=root;password=;database=cosme";
                    string query = "SELECT * FROM par_records WHERE NAME = @Username AND PASSWORDS = @Password";

                    if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Please input Username and Password", "Error");
                    }
                    else
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {

                                        phar phar = new phar();
                                        phar.Show();
                                        Hide();
                                        MessageBox.Show("Login successful!", "Success");


                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed");
                                    }
                                }
                            }
                        }
                    }

                }
                //Pharmacologist log in

            }
          



        }
    }
}
