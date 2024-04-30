namespace Store
{
    partial class Create_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Form));
            imageList1 = new ImageList(components);
            button2 = new Button();
            password_create = new TextBox();
            email_create = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            name_create = new TextBox();
            username_create = new TextBox();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "iconfinder-rootaccess-4417096_116625.ico");
            // 
            // button2
            // 
            button2.Location = new Point(343, 287);
            button2.Name = "button2";
            button2.Size = new Size(427, 34);
            button2.TabIndex = 16;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // password_create
            // 
            password_create.Location = new Point(446, 221);
            password_create.MaxLength = 10;
            password_create.Name = "password_create";
            password_create.PasswordChar = '*';
            password_create.PlaceholderText = "password";
            password_create.Size = new Size(324, 31);
            password_create.TabIndex = 14;
            password_create.UseSystemPasswordChar = true;
            // 
            // email_create
            // 
            email_create.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_create.Location = new Point(446, 184);
            email_create.Name = "email_create";
            email_create.PlaceholderText = "email@gmail.com";
            email_create.Size = new Size(324, 31);
            email_create.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 227);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 12;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(379, 191);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, 49);
            label1.Name = "label1";
            label1.Size = new Size(220, 28);
            label1.TabIndex = 17;
            label1.Text = "CREATE AN ACCOUNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 110);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 18;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 147);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 19;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // name_create
            // 
            name_create.Location = new Point(446, 110);
            name_create.Name = "name_create";
            name_create.PlaceholderText = "Full Name";
            name_create.Size = new Size(324, 31);
            name_create.TabIndex = 20;
            // 
            // username_create
            // 
            username_create.Location = new Point(446, 147);
            username_create.Name = "username_create";
            username_create.PlaceholderText = "@username";
            username_create.Size = new Size(324, 31);
            username_create.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 376);
            label7.Name = "label7";
            label7.Size = new Size(218, 25);
            label7.TabIndex = 25;
            label7.Text = "Already have an account? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(621, 376);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 25);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Create_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 483);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(username_create);
            Controls.Add(name_create);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(password_create);
            Controls.Add(email_create);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Create_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayeTech";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Button button2;
        private TextBox password_create;
        private TextBox email_create;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox name_create;
        private TextBox username_create;
        private Label label7;
        private LinkLabel linkLabel1;
    }
}