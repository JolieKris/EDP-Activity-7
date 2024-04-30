namespace Store
{
    partial class Form1
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
            checkBox1 = new CheckBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(209, 241);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Remember me?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(209, 300);
            button2.Name = "button2";
            button2.Size = new Size(382, 34);
            button2.TabIndex = 29;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 31);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 31);
            textBox1.TabIndex = 27;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 7F);
            linkLabel2.Location = new Point(473, 402);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(118, 19);
            linkLabel2.TabIndex = 26;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(209, 362);
            label4.Name = "label4";
            label4.Size = new Size(153, 19);
            label4.TabIndex = 25;
            label4.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 7F);
            linkLabel1.Location = new Point(368, 362);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(55, 19);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 176);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 23;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 90);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 22;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 30);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 21;
            label1.Text = "Welcome to KayeTech";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private LinkLabel linkLabel2;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}