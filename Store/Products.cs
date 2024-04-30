using ClosedXML.Excel;
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

namespace Store
{
    public partial class Products : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;
        public Products()
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
        private void refreshProd()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewProd.DataSource = dt;
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
            refreshProd();
        }

        private void dataGridViewProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(textBoxProductId.Text);
                string productName = textBoxProductName.Text;
                string brand = textBoxBrand.Text;
                string category = textBoxCategory.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);
                string description = textBoxDescription.Text;

                // Open database connection
                connection.Open();

                // Insert product into the database
                string query = "INSERT INTO products (product_id, product_name, brand, category, price, quantity, description) " +
                               "VALUES (@productId, @productName, @brand, @category, @price, @quantity, @description)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product inserted successfully.", "Success");
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


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the dataGridViewProd
                if (dataGridViewProd.SelectedRows.Count > 0)
                {
                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Get the product_id of the selected row
                        int productId = int.Parse(dataGridViewProd.SelectedRows[0].Cells["product_id"].Value.ToString());

                        // Delete the record from the database
                        DeleteRecord(productId);

                        // Refresh the dataGridViewProd
                        refreshProd();
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
                string query = "DELETE FROM products WHERE product_id = @productId";
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

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(textBoxProductId.Text);
                string productName = textBoxProductName.Text;
                string brand = textBoxBrand.Text;
                string category = textBoxCategory.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);
                string description = textBoxDescription.Text;

                string connectionString = "server=127.0.0.1; uid=root;pwd=1432;database=gadget_store";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE products SET product_name = @productName, brand = @brand, category = @category, " +
                                   "price = @price, quantity = @quantity, description = @description " +
                                   "WHERE product_id = @productId";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@description", description);

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
        private void UpdateRecord(int productId, string productName, string Brand, string Category, decimal Price, int Quantity, string Description)
        {
            try
            {

                // Retrieve data from input controls
                int product_id = int.Parse(textBoxProductId.Text); // Assuming textBoxProductId contains the product ID
                string product_name = textBoxProductName.Text;
                string brand = textBoxBrand.Text;
                string category = textBoxCategory.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);
                string description = textBoxDescription.Text;


                {
                    connection.Open();

                    string query = "UPDATE products SET product_name = @productName, brand = @brand, category = @category, " +
                                   "price = @price, quantity = @quantity, description = @description WHERE product_id = @productId";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@description", description);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfullyyy.", "Success");
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


        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void GenerateRepProd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    // First sheet: Selected Order
                    DataGridViewRow selectedRow = dataGridViewProd.CurrentRow;
                    if (selectedRow != null)
                    {
                        DataTable selectedData = new DataTable();
                        selectedData.Columns.Add("product_id", typeof(int));
                        selectedData.Columns.Add("product_name", typeof(string));
                        selectedData.Columns.Add("brand", typeof(string));
                        selectedData.Columns.Add("category", typeof(string));
                        selectedData.Columns.Add("price", typeof(decimal));
                        selectedData.Columns.Add("quantity", typeof(int));
                        selectedData.Columns.Add("description", typeof(string));

                        DataRow newRow = selectedData.Rows.Add();
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            newRow[cell.ColumnIndex] = cell.Value;
                        }

                        var worksheet = workbook.Worksheets.Add("Products");
                        worksheet.Cell(2, 6).Value = "LIST OF PRODUCTS";
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

                        worksheet.Cell(6, 4).Value = "Product ID";
                        worksheet.Cell(6, 5).Value = "Product Name";
                        worksheet.Cell(6, 6).Value = "Brand";
                        worksheet.Cell(6, 7).Value = "Category";
                        worksheet.Cell(6, 8).Value = "Price";
                        worksheet.Cell(6, 9).Value = "Quantity";
                        worksheet.Cell(6, 10).Value = "Description";

                        var dataRange = worksheet.Range("D6:J6");
                        dataRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        dataRange.Style.Font.SetBold(true);
                        dataRange.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                        worksheet.Cell(7, 4).Value = selectedData.Rows[0]["product_id"].ToString();
                        worksheet.Cell(7, 5).Value = (string)selectedData.Rows[0]["product_name"];
                        worksheet.Cell(7, 6).Value = (string)selectedData.Rows[0]["brand"];
                        worksheet.Cell(7, 7).Value = (string)selectedData.Rows[0]["category"];
                        worksheet.Cell(7, 8).Value = (decimal)selectedData.Rows[0]["price"];
                        worksheet.Cell(7, 9).Value = (int)selectedData.Rows[0]["quantity"];
                        worksheet.Cell(7, 10).Value = (string)selectedData.Rows[0]["description"];

                        var Rangedata = worksheet.Range("D7:J7");
                        Rangedata.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        worksheet.Cell(10, 4).Value = " PREPARED BY:";
                        worksheet.Cell(13, 4).Value = " REQUESTING OFFICER";
                        worksheet.Cell(10, 6).Value = " REVIEWED BY:";
                        worksheet.Cell(13, 6).Value = " ADMIN STAFF";
                        worksheet.Cell(10, 9).Value = " APPROVED BY:";
                        worksheet.Cell(13, 9).Value = " ADMIN OFFICER";

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

        private void bnt_sett_Click(object sender, EventArgs e)
        {
            var myform = new Home_Form();
            this.Hide();
            myform.Show();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            var myform = new Products();
            this.Hide();
            myform.Show();
        }

        private void btn_cus_Click(object sender, EventArgs e)
        {
            var myform = new ReportGenerator();
            this.Hide();
            myform.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            var myform = new OrderTransaction();
            this.Hide();
            myform.Show();
        }

        private void bnt_rep_Click(object sender, EventArgs e)
        {
            var myform = new Rep_Form();
            this.Hide();
            myform.Show();

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            var myform = new User();
            this.Hide();
            myform.Show();

        }

        private void bnt_dash_Click(object sender, EventArgs e)
        {
            var myform = new Dash_Form();
            this.Hide();
            myform.Show();
        }
    }
}
