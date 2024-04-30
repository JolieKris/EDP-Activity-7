using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Store
{
    public partial class User : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;
        public User()
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

        private void refreshAccount()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM loginformation";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            refreshAccount();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM loginformation WHERE BINARY name LIKE @name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", "%" + search_txtbox.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            string newName = name_txtbox.Text.Trim();
            string newUsername = username_txtbox.Text.Trim();
            string newPassword = pass_textbox.Text.Trim();
            string newEmail = email_txtbox.Text.Trim();
            int user_id = Convert.ToInt32(id_textbox.Text.Trim());

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please complete the information.");
                return;
            }
            try
            {
                connection.Open();
                string query = "UPDATE loginformation SET name = @name, username = @username, password = @password, email = @email " + "WHERE user_id= @user_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@name", newName);
                cmd.Parameters.AddWithValue("@username", newUsername);
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@email", newEmail);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                    refreshAccount();
                }
                else
                {
                    MessageBox.Show("Failed to Update");
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }
        private void AccountStatus(int status)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select as user.");
                return;
            }

            int user_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["user_id"].Value);

            try
            {
                connection.Open();
                string query = "UPDATE loginformation SET IsActive = @status WHERE user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@status", status);
                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    string action = status == 1 ? "activated" : "deactivated";
                    MessageBox.Show("User acccount " + action + " successfully.");
                    refreshAccount();
                }
                else
                {
                    MessageBox.Show("Failed to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_activate_Click(object sender, EventArgs e)
        {
            AccountStatus(1);
        }

        private void btn_deactivate_Click(object sender, EventArgs e)
        {
            AccountStatus(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myform = new Dash_Form();
            this.Hide();
            myform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myform = new Rep_Form();
            this.Hide();
            myform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var myform = new User();
            this.Hide();
            myform.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myform = new Home_Form();
            this.Hide();
            myform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myform = new Products();
            this.Hide();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myform = new ReportGenerator();
            this.Hide();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myform = new OrderTransaction();
            this.Hide();
            myform.Show();
        }
    }

}

