namespace Store
{
    partial class login_form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            login_username = new TextBox();
            login_password = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 51);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to KayeTech";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 111);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 197);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8F);
            linkLabel1.Location = new Point(574, 383);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 21);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(397, 383);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 4;
            label4.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(661, 423);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(133, 21);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // login_username
            // 
            login_username.Location = new Point(397, 150);
            login_username.Name = "login_username";
            login_username.Size = new Size(382, 31);
            login_username.TabIndex = 6;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(397, 225);
            login_password.Name = "login_password";
            login_password.Size = new Size(382, 31);
            login_password.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(397, 321);
            button2.Name = "button2";
            button2.Size = new Size(382, 34);
            button2.TabIndex = 9;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(397, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Remember me?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // login_form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 483);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login_form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayeTech";
            Load += login_form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel linkLabel2;
        private TextBox login_username;
        private TextBox login_password;
        private Button button2;
        private CheckBox checkBox1;
    }
}