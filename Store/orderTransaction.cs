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
using OfficeOpenXml;
using System.IO;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Office2010.Excel;
using ClosedXML.Report;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using ClosedXML.Excel;


namespace Store
{
    public partial class OrderTransaction : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;

        public OrderTransaction()
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

        private void TopSellingView_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void refreshOrder()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM orders";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewOrder.DataSource = dt;
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

        private void ref_btn_Click(object sender, EventArgs e)
        {
            refreshOrder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(textBoxOrderId.Text);
                int customerId = int.Parse(textBoxCustomerId.Text);
                DateTime orderDate = dateTimePickerOrderDate.Value;
                decimal totalAmount = decimal.Parse(textBoxTotalAmount.Text);

                // Open database connection
                connection.Open();

                // Insert transaction into the database
                string query = "INSERT INTO orders (order_id, customer_id, order_date, total_amount) " +
                               "VALUES (@orderId, @customerId, @orderDate, @totalAmount)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@orderDate", orderDate);
                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order inserted successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                // Close database connection
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    // First sheet: Selected Order
                    DataGridViewRow selectedRow = dataGridViewOrder.CurrentRow;
                    if (selectedRow != null)
                    {
                        DataTable selectedData = new DataTable();
                        foreach (DataGridViewColumn column in dataGridViewOrder.Columns)
                        {
                            selectedData.Columns.Add(column.HeaderText, column.ValueType);
                        }
                        DataRow newRow = selectedData.Rows.Add();
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            newRow[cell.ColumnIndex] = cell.Value;
                        }

                        var worksheet = workbook.Worksheets.Add("Selected Order");
                        worksheet.Cell(2, 6).Value = "ORDER TRANSACTION";
                        worksheet.Cell(2, 9).Value = "DATE REQUESTED:";
                        worksheet.Cell(2, 10).Value = DateTime.Now.ToShortDateString();
                        worksheet.Range("F2:F2").Style.Font.SetBold(true);
                        worksheet.Range("I2:I2").Style.Font.SetBold(true);
                        worksheet.Range("D1:F1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        string logoPath = "C:/Users/Jolie Kris Briton/Downloads/kayeTechLogo.png";
                        if (File.Exists(logoPath))
                        {
                            var picture = worksheet.AddPicture(logoPath)
                                .MoveTo(worksheet.Cell(2, 2))
                                .WithSize(100, 100);
                        }

                        worksheet.Cell(6, 5).Value = "Order ID";
                        worksheet.Cell(6, 6).Value = "Customer ID";
                        worksheet.Cell(6, 7).Value = "Order Date";
                        worksheet.Cell(6, 8).Value = "Total Amount";

                        var dataRange = worksheet.Range("E6:H6");
                        dataRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        dataRange.Style.Font.SetBold(true);
                        dataRange.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                        worksheet.Cell(7, 5).Value = selectedData.Rows[0]["order_id"].ToString();
                        worksheet.Cell(7, 6).Value = (string)selectedData.Rows[0]["customer_id"];
                        worksheet.Cell(7, 7).Value = (DateTime)selectedData.Rows[0]["order_date"];
                        worksheet.Cell(7, 8).Value = (decimal)selectedData.Rows[0]["total_amount"];

                        var Rangedata = worksheet.Range("E7:H7");
                        Rangedata.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        worksheet.Cell(10, 4).Value = " PREPARED BY:";
                        worksheet.Cell(12, 4).Value = " REQUESTING OFFICER";
                        worksheet.Cell(10, 6).Value = " REVIEWED BY:";
                        worksheet.Cell(12, 6).Value = " ADMIN STAFF";
                        worksheet.Cell(10, 9).Value = " APPROVED BY:";
                        worksheet.Cell(12, 9).Value = " ADMIN OFFICER";

                        // Autofit columns
                        worksheet.Columns().AdjustToContents();
                    }
                    else
                    {
                        MessageBox.Show("No row selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Save the workbook
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Excel file generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private DataTable GetOrdersData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string connectionString;
                connectionString = "server=127.0.0.1; uid=root;pwd=1432;database=gadget_store";
                connection = new MySqlConnection(connectionString);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM orders"; // Assuming the table name is Orders
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(textBoxOrderId.Text);
            int customerId = int.Parse(textBoxCustomerId.Text);
            DateTime orderDate = dateTimePickerOrderDate.Value;
            decimal totalAmount = decimal.Parse(textBoxTotalAmount.Text);

            try
            {
                string connectionString;
                connectionString = "server=127.0.0.1; uid=root;pwd=1432;database=gadget_store";
                connection = new MySqlConnection(connectionString);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE orders SET customer_id = @customerId, order_date = @orderDate, total_amount = @totalAmount " +
                                   "WHERE order_id = @orderId";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@orderDate", orderDate);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success");
                        // Optionally refresh the dataGridView here
                    }
                    else
                    {
                        MessageBox.Show("Record not found or no changes made.", "Information");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }
        private void UpdateRecord(int orderId, int customerId, DateTime orderDate, decimal totalAmount)
        {
            try
            {
                // Retrieve data from input controls
                int order_id = int.Parse(textBoxOrderId.Text);
                int customer_id = int.Parse(textBoxCustomerId.Text);
                DateTime order_date = dateTimePickerOrderDate.Value;
                decimal total_amount = decimal.Parse(textBoxTotalAmount.Text);

                string connectionString = "server=127.0.0.1; uid=root;pwd=1432;database=gadget_store";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE orders SET customer_id = @customerId, order_date = @orderDate, total_amount = @totalAmount " +
                                   "WHERE order_id = @orderId";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@orderDate", orderDate);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or no changes made.", "Information");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }
        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if a valid row is clicked (avoiding the header row)
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridViewOrder.Rows[e.RowIndex];

                    // Extract data from the selected row
                    int orderId = int.Parse(selectedRow.Cells["order_id"].Value.ToString());
                    int customerId = int.Parse(selectedRow.Cells["customer_id"].Value.ToString());
                    DateTime orderDate = DateTime.Parse(selectedRow.Cells["order_date"].Value.ToString());
                    decimal totalAmount = decimal.Parse(selectedRow.Cells["total_amount"].Value.ToString());

                    // Populate the form controls with the selected row's data
                    textBoxOrderId.Text = orderId.ToString();
                    textBoxCustomerId.Text = customerId.ToString();
                    dateTimePickerOrderDate.Value = orderDate;
                    textBoxTotalAmount.Text = totalAmount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOrder.CellClick += new DataGridViewCellEventHandler(dataGridViewOrder_CellClick);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the dataGridView
                if (dataGridViewOrder.SelectedRows.Count > 0)
                {
                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Get the order_id of the selected row
                        int orderId = int.Parse(dataGridViewOrder.SelectedRows[0].Cells["order_id"].Value.ToString());

                        // Delete the record from the database
                        DeleteRecord(orderId);

                        // Refresh the dataGridView
                        refreshOrder();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
        private void DeleteRecord(int orderId)
        {
            try
            {
                // Open database connection
                connection.Open();

                // Delete the record from the database
                string query = "DELETE FROM orders WHERE order_id = @orderId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                // Close database connection
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void textBoxOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_settV_Click(object sender, EventArgs e)
        {
            var myform = new Home_Form();
            this.Hide();
            myform.Show();
        }

        private void btn_productsV_Click(object sender, EventArgs e)
        {
            var myform = new Products();
            this.Hide();
            myform.Show();
        }

        private void btn_cusV_Click(object sender, EventArgs e)
        {
            var myform = new ReportGenerator();
            this.Hide();
            myform.Show();

        }

        private void btn_ordersV_Click(object sender, EventArgs e)
        {

            var myform = new OrderTransaction();
            this.Hide();
            myform.Show();
        }

        private void bnt_repV_Click(object sender, EventArgs e)
        {
            var myform = new Rep_Form();
            this.Hide();
            myform.Show();
        }

        private void bnt_dashV_Click(object sender, EventArgs e)
        {
            var myform = new Dash_Form();
            this.Hide();
            myform.Show();
        }

        private void btn_userV_Click(object sender, EventArgs e)
        {
            var myform = new User();
            this.Hide();
            myform.Show();

        }
    }
}
