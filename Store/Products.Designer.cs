namespace Store
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            panelll = new Panel();
            btn_user = new Button();
            bnt_dash = new Button();
            bnt_sett = new Button();
            bnt_rep = new Button();
            btn_orders = new Button();
            btn_cus = new Button();
            btn_products = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            DeleteProd = new Button();
            UpdateProd = new Button();
            InsertProd = new Button();
            textBoxProductId = new TextBox();
            textBoxCategory = new TextBox();
            textBoxProductName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            GenerateRepProd = new Button();
            RefereshProdbtn = new Button();
            dataGridViewProd = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            textBoxBrand = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxPrice = new TextBox();
            label10 = new Label();
            textBoxDescription = new TextBox();
            panelll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).BeginInit();
            SuspendLayout();
            // 
            // panelll
            // 
            panelll.BackColor = SystemColors.ActiveCaption;
            panelll.Controls.Add(btn_user);
            panelll.Controls.Add(bnt_dash);
            panelll.Controls.Add(bnt_sett);
            panelll.Controls.Add(bnt_rep);
            panelll.Controls.Add(btn_orders);
            panelll.Controls.Add(btn_cus);
            panelll.Controls.Add(btn_products);
            panelll.Controls.Add(pictureBox1);
            panelll.Controls.Add(label2);
            panelll.Controls.Add(label1);
            panelll.Location = new Point(12, 12);
            panelll.Name = "panelll";
            panelll.Size = new Size(155, 456);
            panelll.TabIndex = 10;
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
            btn_user.Click += btn_user_Click;
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
            bnt_dash.Click += bnt_dash_Click;
            // 
            // bnt_sett
            // 
            bnt_sett.BackColor = Color.LightGray;
            bnt_sett.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnt_sett.Location = new Point(18, 166);
            bnt_sett.Name = "bnt_sett";
            bnt_sett.Size = new Size(95, 34);
            bnt_sett.TabIndex = 16;
            bnt_sett.Text = "HOME";
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
            bnt_rep.Click += bnt_rep_Click;
            // 
            // btn_orders
            // 
            btn_orders.BackColor = Color.LightGray;
            btn_orders.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_orders.Location = new Point(18, 285);
            btn_orders.Name = "btn_orders";
            btn_orders.Size = new Size(95, 34);
            btn_orders.TabIndex = 14;
            btn_orders.Text = "Orders";
            btn_orders.UseVisualStyleBackColor = false;
            btn_orders.Click += btn_orders_Click;
            // 
            // btn_cus
            // 
            btn_cus.BackColor = Color.LightGray;
            btn_cus.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btn_products.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 8;
            label1.Text = "Products";
            // 
            // DeleteProd
            // 
            DeleteProd.Location = new Point(1002, 201);
            DeleteProd.Name = "DeleteProd";
            DeleteProd.Size = new Size(106, 34);
            DeleteProd.TabIndex = 40;
            DeleteProd.Text = "Delete";
            DeleteProd.UseVisualStyleBackColor = true;
            DeleteProd.Click += button3_Click;
            // 
            // UpdateProd
            // 
            UpdateProd.Location = new Point(1002, 140);
            UpdateProd.Name = "UpdateProd";
            UpdateProd.Size = new Size(106, 34);
            UpdateProd.TabIndex = 39;
            UpdateProd.Text = "Update";
            UpdateProd.UseVisualStyleBackColor = true;
            UpdateProd.Click += UpdateOrder_Click;
            // 
            // InsertProd
            // 
            InsertProd.Location = new Point(1002, 80);
            InsertProd.Name = "InsertProd";
            InsertProd.Size = new Size(106, 34);
            InsertProd.TabIndex = 38;
            InsertProd.Text = "Insert";
            InsertProd.UseVisualStyleBackColor = true;
            InsertProd.Click += button2_Click;
            // 
            // textBoxProductId
            // 
            textBoxProductId.Location = new Point(323, 318);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.Size = new Size(150, 31);
            textBoxProductId.TabIndex = 36;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(583, 361);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(150, 31);
            textBoxCategory.TabIndex = 35;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(323, 364);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(150, 31);
            textBoxProductName.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 370);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 33;
            label7.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 324);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 32;
            label6.Text = "Brand:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 367);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 31;
            label5.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 318);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 30;
            label4.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 12);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 29;
            label3.Text = "Products";
            // 
            // GenerateRepProd
            // 
            GenerateRepProd.Location = new Point(905, 425);
            GenerateRepProd.Name = "GenerateRepProd";
            GenerateRepProd.Size = new Size(183, 34);
            GenerateRepProd.TabIndex = 28;
            GenerateRepProd.Text = "Generate Report";
            GenerateRepProd.UseVisualStyleBackColor = true;
            GenerateRepProd.Click += GenerateRepProd_Click;
            // 
            // RefereshProdbtn
            // 
            RefereshProdbtn.Location = new Point(996, 12);
            RefereshProdbtn.Name = "RefereshProdbtn";
            RefereshProdbtn.Size = new Size(112, 34);
            RefereshProdbtn.TabIndex = 27;
            RefereshProdbtn.Text = "Refresh";
            RefereshProdbtn.UseVisualStyleBackColor = true;
            RefereshProdbtn.Click += ref_btn_Click;
            // 
            // dataGridViewProd
            // 
            dataGridViewProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProd.Location = new Point(190, 59);
            dataGridViewProd.Name = "dataGridViewProd";
            dataGridViewProd.RowHeadersWidth = 62;
            dataGridViewProd.Size = new Size(798, 228);
            dataGridViewProd.TabIndex = 26;
            dataGridViewProd.CellContentClick += dataGridViewProd_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(770, 314);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 41;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(748, 367);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 42;
            label9.Text = "Quantity:";
            label9.Click += label9_Click;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(583, 312);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(150, 31);
            textBoxBrand.TabIndex = 43;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(838, 364);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(150, 31);
            textBoxQuantity.TabIndex = 44;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(838, 311);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(150, 31);
            textBoxPrice.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(190, 425);
            label10.Name = "label10";
            label10.Size = new Size(173, 25);
            label10.TabIndex = 46;
            label10.Text = "Product Description:";
            label10.Click += label10_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(369, 421);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(279, 31);
            textBoxDescription.TabIndex = 47;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 483);
            Controls.Add(textBoxDescription);
            Controls.Add(label10);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxBrand);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(DeleteProd);
            Controls.Add(UpdateProd);
            Controls.Add(InsertProd);
            Controls.Add(textBoxProductId);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(GenerateRepProd);
            Controls.Add(RefereshProdbtn);
            Controls.Add(dataGridViewProd);
            Controls.Add(panelll);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            panelll.ResumeLayout(false);
            panelll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelll;
        private Button btn_user;
        private Button bnt_dash;
        private Button bnt_sett;
        private Button bnt_rep;
        private Button btn_orders;
        private Button btn_cus;
        private Button btn_products;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button DeleteProd;
        private Button UpdateProd;
        private Button InsertProd;
        private TextBox textBoxProductId;
        private TextBox textBoxCategory;
        private TextBox textBoxProductName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button GenerateRepProd;
        private Button RefereshProdbtn;
        private DataGridView dataGridViewProd;
        private Label label8;
        private Label label9;
        private TextBox textBoxBrand;
        private TextBox textBoxQuantity;
        private TextBox textBoxPrice;
        private Label label10;
        private TextBox textBoxDescription;
    }
}