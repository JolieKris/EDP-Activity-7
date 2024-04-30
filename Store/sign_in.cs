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
    public partial class login_form2 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;

        [DllImport("Gdi32.dll", EntryPoint = "CreatRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightElllipse
            );
        public login_form2()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenConnection())
            {
                string username = login_username.Text;
                string password = login_password.Text;

                string query = "SELECT COUNT(*) FROM loginformation WHERE BINARY username = @username AND BINARY password = @password AND isActive = 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Authentication Successful!");
                    var myform = new Dash_Form();
                    this.Hide();
                    myform.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Input or inactive account.");
                    var myform = new pass_recovery();
                    this.Hide();
                    myform.Show();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new Create_Form();
            this.Hide();
            myform.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new pass_recovery();
            this.Hide();
            myform.Show(); 
        }
    }
}
