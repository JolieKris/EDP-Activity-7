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
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new Home_Form();
            this.Hide();
            myform.Show();
        }

        private void About_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
