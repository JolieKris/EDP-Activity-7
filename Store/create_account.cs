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

namespace Store
{
    public partial class Create_Form : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;
        public Create_Form()
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
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAccount(string name, string username, string password, string email, bool isActive)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO loginformation (name, username, password, email, isActive) VALUES (@name, @username, @password, @email, @status)";
                ; MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", isActive);

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = name_create.Text;
            string username = username_create.Text;
            string password = password_create.Text;
            string email = email_create.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                AddAccount(name, username, password, email, true);
                MessageBox.Show("Successfully Added.");
            }
            else
            {
                MessageBox.Show("Please complete log in information");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new login_form2();
            this.Hide();
            myform.Show();
        }
    }
}
