using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace Store
{
    public partial class pass_recovery : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;
        public pass_recovery()
        {
            InitializeComponent();
            InitializeDataabase();
        }
        private void InitializeDataabase()
        {
            server = "127.0.0.1";
            database = "gadget_store";
            uid = "root";
            password = "1432";

            string connectionString;
            connectionString = "server=127.0.0.1; uid=root;pwd=1432;database=gadget_store";
            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"error: {ex.Message}");
                return false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_continuePass_Click(object sender, EventArgs e)
        {
            string username = username_PassRecovery.Text;
            string email = email_PassRecovery.Text;

            try
            {
                if (OpenConnection())
                {
                    String query = "SELECT COUNT(*) FROM loginformation WHERE BINARY username = @username AND email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        query = "Select password FROM loginformation WHERE username = @username AND email= @email";
                        cmd.CommandText = query;

                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                String recoveredPassword = dataReader.GetString(0);
                                MessageBox.Show($"Your password is: {recoveredPassword}");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or email");
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"error: {ex.Message}");

            }
            finally
            {
                CloseConnection();
            }
        }

        private void linkLabel_signUp_Pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new login_form2();
            this.Hide();
            myform.Show();
        }
    }
}