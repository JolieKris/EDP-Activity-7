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
    public partial class Rep_Form : Form
    {
        public Rep_Form()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Rep_Form_Load(object sender, EventArgs e)
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
