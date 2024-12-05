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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cosme
{
    public partial class CAR : Form
    {
        public CAR()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (cbPosition.SelectedItem == null)
            {
                MessageBox.Show("Please choose an option before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //insert Receptionist info
                if (cbPosition.SelectedItem.ToString() == "Receptionist")
                {

                    string connection = "server=localhost;user id=root;password=;database=cosme";
                    string query = "INSERT INTO r_records(NAME, LASTNAME, EMAIL, DATE, PASSWORDS) VALUES(@Name, @Lastname, @Email, @Date, @Passwords)";

                    // Check if any required textbox is empty
                    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtpassword.Text) ||
                        string.IsNullOrWhiteSpace(txtCpass.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtpassword.Text != txtCpass.Text)
                    {
                        MessageBox.Show("Passwords do not match. Please check your input.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (MySqlConnection conn = new MySqlConnection(connection))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                try
                                {
                                    cmd.Parameters.AddWithValue("@Name", this.txtName.Text);
                                    cmd.Parameters.AddWithValue("@Lastname", this.txtLastname.Text);
                                    cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                                    cmd.Parameters.AddWithValue("@Date", this.dtp.Value.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@Passwords", this.txtpassword.Text);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Successfully saved");
                                    txtName.Text = "";
                                    txtLastname.Text = "";
                                    txtEmail.Text = "";
                                    txtpassword.Text = "";
                                    txtCpass.Text = "";
                                }
                                catch (MySqlException ex)
                                {
                                    if (ex.Number == 1062) // MySQL error number for duplicate entry
                                    {
                                        MessageBox.Show("Username or Email already in use. Please choose a different one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        // Handle other database-related exceptions if needed
                                        MessageBox.Show("An error occurred while saving the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }


                }
                //insert Receptionist info




                //insert Pharmacologistt info
                if (cbPosition.SelectedItem.ToString() == "Pharmacologist")
                {

                    string connection = "server=localhost;user id=root;password=;database=cosme";
                    string query = "INSERT INTO par_records(NAME, LASTNAME, EMAIL, DATE, PASSWORDS) VALUES(@Name, @Lastname, @Email, @Date, @Passwords)";

                    // Check if any required textbox is empty
                    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtpassword.Text) ||
                        string.IsNullOrWhiteSpace(txtCpass.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtpassword.Text != txtCpass.Text)
                    {
                        MessageBox.Show("Passwords do not match. Please check your input.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (MySqlConnection conn = new MySqlConnection(connection))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                try
                                {
                                    cmd.Parameters.AddWithValue("@Name", this.txtName.Text);
                                    cmd.Parameters.AddWithValue("@Lastname", this.txtLastname.Text);
                                    cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                                    cmd.Parameters.AddWithValue("@Date", this.dtp.Value.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@Passwords", this.txtpassword.Text);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Successfully saved");
                                    txtName.Text = "";
                                    txtLastname.Text = "";
                                    txtEmail.Text = "";
                                    txtpassword.Text = "";
                                    txtCpass.Text = "";
                                }
                                catch (MySqlException ex)
                                {
                                    if (ex.Number == 1062) // MySQL error number for duplicate entry
                                    {
                                        MessageBox.Show("Username or Email already in use. Please choose a different one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        // Handle other database-related exceptions if needed
                                        MessageBox.Show("An error occurred while saving the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }





                }
                //insert Pharmacologistt info


                //insert Doctor info
                if (cbPosition.SelectedItem.ToString() == "Doctor")
                {
                    string connection = "server=localhost;user id=root;password=;database=cosme";
                    string query = "INSERT INTO d_records(NAME, LASTNAME, EMAIL, DATE, PASSWORDS) VALUES(@Name, @Lastname, @Email, @Date, @Passwords)";

                    // Check if any required textbox is empty
                    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtpassword.Text) ||
                        string.IsNullOrWhiteSpace(txtCpass.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtpassword.Text != txtCpass.Text)
                    {
                        MessageBox.Show("Passwords do not match. Please check your input.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (MySqlConnection conn = new MySqlConnection(connection))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                try
                                {
                                    cmd.Parameters.AddWithValue("@Name", this.txtName.Text);
                                    cmd.Parameters.AddWithValue("@Lastname", this.txtLastname.Text);
                                    cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                                    cmd.Parameters.AddWithValue("@Date", this.dtp.Value.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@Passwords", this.txtpassword.Text);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Successfully saved");
                                    txtName.Text = "";
                                    txtLastname.Text = "";
                                    txtEmail.Text = "";
                                    txtpassword.Text = "";
                                    txtCpass.Text = "";
                                }
                                catch (MySqlException ex)
                                {
                                    if (ex.Number == 1062) // MySQL error number for duplicate entry
                                    {
                                        MessageBox.Show("Username or Email already in use. Please choose a different one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        // Handle other database-related exceptions if needed
                                        MessageBox.Show("An error occurred while saving the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }



                }
                //insert Doctor info

            }





        }

        private void show_Click(object sender, EventArgs e)
        {

            // Toggle the visibility of passwords
            if (txtpassword.PasswordChar == '\0')
            {
                // If passwords are currently visible, hide them
                txtpassword.PasswordChar = '*'; // Set to '*' or any character you prefer
                txtCpass.PasswordChar = '*';
            }
            else
            {
                // If passwords are currently hidden, show them
                txtpassword.PasswordChar = '\0'; // Set to null character to reveal text
                txtCpass.PasswordChar = '\0';
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            Hide();
        }
    }
}
