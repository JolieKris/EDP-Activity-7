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
using LiveCharts;
using LiveCharts.Wpf;

namespace Store
{
    public partial class Dash_Form : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;
        public Dash_Form()
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myform = new Dash_Form();
            this.Hide();
            myform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myform = new ReportGenerator();
            this.Hide();
            myform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new Home_Form();
            this.Hide();
            myform.Show();
        }
        private void refreshCus()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM customers";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewDash.DataSource = dt;
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
        private void Refresh_dash_btn_Click(object sender, EventArgs e)
        {
            refreshCus();
        }

        private void Graph_btn_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myform = new Products();
            this.Hide();
            myform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myform = new Home_Form();
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
