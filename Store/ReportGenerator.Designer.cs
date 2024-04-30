namespace Store
{
    partial class ReportGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGenerator));
            panelll = new Panel();
            btn_user = new Button();
            bnt_dash = new Button();
            bnt_sett = new Button();
            bnt_rep = new Button();
            TopSelling = new Button();
            btn_cus = new Button();
            btn_products = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewTop = new DataGridView();
            dataSet1BindingSource1 = new BindingSource(components);
            label3 = new Label();
            Genbtn = new Button();
            button10 = new Button();
            dataSet1BindingSource = new BindingSource(components);
            panelll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelll
            // 
            panelll.BackColor = SystemColors.ActiveCaption;
            panelll.Controls.Add(btn_user);
            panelll.Controls.Add(bnt_dash);
            panelll.Controls.Add(bnt_sett);
            panelll.Controls.Add(bnt_rep);
            panelll.Controls.Add(TopSelling);
            panelll.Controls.Add(btn_cus);
            panelll.Controls.Add(btn_products);
            panelll.Controls.Add(pictureBox1);
            panelll.Controls.Add(label2);
            panelll.Controls.Add(label1);
            panelll.Location = new Point(12, 5);
            panelll.Name = "panelll";
            panelll.Size = new Size(155, 466);
            panelll.TabIndex = 9;
            // 
            // btn_user
            // 
            btn_user.BackColor = Color.LightGray;
            btn_user.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_user.Location = new Point(18, 406);
            btn_user.Name = "btn_user";
            btn_user.Size = new Size(95, 34);
            btn_user.TabIndex = 18;
            btn_user.Text = "User";
            btn_user.UseVisualStyleBackColor = false;
            btn_user.Click += button7_Click;
            // 
            // bnt_dash
            // 
            bnt_dash.BackColor = Color.LightGray;
            bnt_dash.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_dash.Location = new Point(18, 366);
            bnt_dash.Name = "bnt_dash";
            bnt_dash.Size = new Size(95, 34);
            bnt_dash.TabIndex = 17;
            bnt_dash.Text = "Dashboard";
            bnt_dash.UseVisualStyleBackColor = false;
            bnt_dash.Click += button6_Click;
            // 
            // bnt_sett
            // 
            bnt_sett.BackColor = Color.LightGray;
            bnt_sett.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnt_sett.Location = new Point(18, 166);
            bnt_sett.Name = "bnt_sett";
            bnt_sett.Size = new Size(95, 34);
            bnt_sett.TabIndex = 16;
            bnt_sett.Text = "HOMES";
            bnt_sett.UseVisualStyleBackColor = false;
            bnt_sett.Click += bnt_sett_Click;
            // 
            // bnt_rep
            // 
            bnt_rep.BackColor = Color.LightGray;
            bnt_rep.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_rep.Location = new Point(18, 325);
            bnt_rep.Name = "bnt_rep";
            bnt_rep.Size = new Size(95, 34);
            bnt_rep.TabIndex = 15;
            bnt_rep.Text = "Sales";
            bnt_rep.UseVisualStyleBackColor = false;
            bnt_rep.Click += button4_Click;
            // 
            // TopSelling
            // 
            TopSelling.BackColor = Color.LightGray;
            TopSelling.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TopSelling.Location = new Point(18, 285);
            TopSelling.Name = "TopSelling";
            TopSelling.Size = new Size(95, 34);
            TopSelling.TabIndex = 14;
            TopSelling.Text = "Orders";
            TopSelling.UseVisualStyleBackColor = false;
            TopSelling.Click += btn_orders_Click;
            // 
            // btn_cus
            // 
            btn_cus.BackColor = Color.LightGray;
            btn_cus.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cus.Location = new Point(18, 246);
            btn_cus.Name = "btn_cus";
            btn_cus.Size = new Size(95, 34);
            btn_cus.TabIndex = 13;
            btn_cus.Text = "Views";
            btn_cus.UseVisualStyleBackColor = false;
            btn_cus.Click += btn_cus_Click;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.LightGray;
            btn_products.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_products.Location = new Point(18, 206);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(95, 34);
            btn_products.TabIndex = 12;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 127);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 3;
            label2.Text = "Jolie Kris";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 8;
            label1.Text = "Top Selling";
            // 
            // dataGridViewTop
            // 
            dataGridViewTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTop.Location = new Point(243, 72);
            dataGridViewTop.Name = "dataGridViewTop";
            dataGridViewTop.RowHeadersWidth = 62;
            dataGridViewTop.Size = new Size(803, 328);
            dataGridViewTop.TabIndex = 10;
            dataGridViewTop.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataSet1BindingSource1
            // 
            dataSet1BindingSource1.DataSource = typeof(DataSet1);
            dataSet1BindingSource1.Position = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 21);
            label3.Name = "label3";
            label3.Size = new Size(205, 28);
            label3.TabIndex = 11;
            label3.Text = "Top Selling Products";
            label3.Click += label3_Click;
            // 
            // Genbtn
            // 
            Genbtn.Location = new Point(852, 427);
            Genbtn.Name = "Genbtn";
            Genbtn.Size = new Size(194, 34);
            Genbtn.TabIndex = 15;
            Genbtn.Text = "Generate Report";
            Genbtn.UseVisualStyleBackColor = true;
            Genbtn.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(934, 19);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 16;
            button10.Text = "Refresh";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // dataSet1BindingSource
            // 
            dataSet1BindingSource.DataSource = typeof(DataSet1);
            dataSet1BindingSource.Position = 0;
            // 
            // ReportGenerator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 483);
            Controls.Add(button10);
            Controls.Add(Genbtn);
            Controls.Add(label3);
            Controls.Add(dataGridViewTop);
            Controls.Add(panelll);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportGenerator";
            Load += ReportGenerator_Load;
            panelll.ResumeLayout(false);
            panelll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelll;
        private Button btn_user;
        private Button bnt_dash;
        private Button bnt_sett;
        private Button bnt_rep;
        private Button TopSelling;
        private Button btn_cus;
        private Button btn_products;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewTop;
        private Label label3;
        private Button Genbtn;
        private Button button10;
        private BindingSource dataSet1BindingSource;
        private BindingSource dataSet1BindingSource1;
    }
}