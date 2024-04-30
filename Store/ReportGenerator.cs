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
using OfficeOpenXml.Style;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Reflection;

namespace Store
{
    public partial class ReportGenerator : Form
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string database;
        private string password;
        private object pnlNav;
        private string connectionString;
        private string excelFilePath;
        private object txtFileName;

        public ReportGenerator()
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM top_selling_products_view";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewTop.DataSource = dt;
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
        private void button10_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myform = new Rep_Form();
            this.Hide();
            myform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myform = new Dash_Form();
            this.Hide();
            myform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var myform = new User();
            this.Hide();
            myform.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var workbook = new ExcelPackage())
                {



                    // First sheet: Top Selling Products
                    var worksheet = workbook.Workbook.Worksheets.Add("Top Selling Products");

                    // Date Generated
                    worksheet.Cells[2, 9].Value = "Date Generated:";
                    worksheet.Cells[2, 10].Value = DateTime.Now.ToShortDateString();
                    worksheet.Cells[2, 6].Value = "Top Selling Products";
                    var dataRange = worksheet.Cells["F2:F6"];
                    dataRange = worksheet.Cells["I2:I9"];



                    // Logo
                    string logoPath = "C:/Users/Jolie Kris Briton/Downloads/kayeTechLogo.png";
                    if (File.Exists(logoPath))
                    {
                        var logo = worksheet.Drawings.AddPicture("Logo", new FileInfo(logoPath));
                        logo.SetPosition(4, 4);
                        logo.SetSize(100, 100);
                    }

                    // Headers
                    worksheet.Cells[5, 4].Value = "Product ID";
                    worksheet.Cells[5, 5].Value = "Product Name";
                    worksheet.Cells[5, 6].Value = "Brand";
                    worksheet.Cells[5, 7].Value = "Category";
                    worksheet.Cells[5, 8].Value = "Total Quantity Sold";

                    dataRange = worksheet.Cells["D5:H5"];
                    dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    dataRange.Style.Font.Bold = true;
                    dataRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    dataRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    dataRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    dataRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;


                    // Data
                    int rowStartIndex = 7;
                    for (int rowIndex = 0; rowIndex < dataGridViewTop.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow row = dataGridViewTop.Rows[rowIndex];
                        for (int columnIndex = 0; columnIndex < dataGridViewTop.Columns.Count; columnIndex++)
                        {
                            worksheet.Cells[rowIndex + rowStartIndex, columnIndex + 4].Value = row.Cells[columnIndex].Value?.ToString();
                        }
                    }

                    // Autofit columns
                    worksheet.Cells.AutoFitColumns();

                    // Prepare by, requested officer, reviewed by, approved by
                    worksheet.Cells[16, 4].Value = " PREPARED BY:";
                    worksheet.Cells[19, 4].Value = " REQUESTING OFFICER";
                    worksheet.Cells[16, 7].Value = " REVIEWED BY:";
                    worksheet.Cells[19, 7].Value = " ADMIN STAFF";
                    worksheet.Cells[16, 9].Value = " APPROVED BY:";
                    worksheet.Cells[19, 9].Value = " ADMIN OFFICER";


                    // Save the workbook
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo file = new FileInfo(saveFileDialog.FileName);
                        workbook.SaveAs(file);
                        MessageBox.Show("Excel file successfully generated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportGenerator_Load(object sender, EventArgs e)
        {

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            var myform = new OrderTransaction();
            this.Hide();
            myform.Show();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
