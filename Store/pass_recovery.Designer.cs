namespace Store
{
    partial class pass_recovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pass_recovery));
            email_PassRecovery = new TextBox();
            label_PassRecovery = new Label();
            label_EmailPass = new Label();
            btn_continuePass = new Button();
            label_account = new Label();
            linkLabel_signUp_Pass = new LinkLabel();
            label_usernamePass = new Label();
            username_PassRecovery = new TextBox();
            SuspendLayout();
            // 
            // email_PassRecovery
            // 
            email_PassRecovery.Location = new Point(426, 223);
            email_PassRecovery.Name = "email_PassRecovery";
            email_PassRecovery.PlaceholderText = "email@gmail.com";
            email_PassRecovery.Size = new Size(309, 31);
            email_PassRecovery.TabIndex = 0;
            email_PassRecovery.TextChanged += textBox1_TextChanged;
            // 
            // label_PassRecovery
            // 
            label_PassRecovery.AutoSize = true;
            label_PassRecovery.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_PassRecovery.Location = new Point(488, 58);
            label_PassRecovery.Name = "label_PassRecovery";
            label_PassRecovery.Size = new Size(195, 28);
            label_PassRecovery.TabIndex = 1;
            label_PassRecovery.Text = "Password Recovery\r\n";
            // 
            // label_EmailPass
            // 
            label_EmailPass.AutoSize = true;
            label_EmailPass.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_EmailPass.Location = new Point(426, 199);
            label_EmailPass.Name = "label_EmailPass";
            label_EmailPass.Size = new Size(48, 21);
            label_EmailPass.TabIndex = 3;
            label_EmailPass.Text = "Email";
            // 
            // btn_continuePass
            // 
            btn_continuePass.Location = new Point(426, 299);
            btn_continuePass.Name = "btn_continuePass";
            btn_continuePass.Size = new Size(309, 34);
            btn_continuePass.TabIndex = 4;
            btn_continuePass.Text = "Continue";
            btn_continuePass.UseVisualStyleBackColor = true;
            btn_continuePass.Click += btn_continuePass_Click;
            // 
            // label_account
            // 
            label_account.AutoSize = true;
            label_account.Location = new Point(445, 392);
            label_account.Name = "label_account";
            label_account.Size = new Size(197, 25);
            label_account.TabIndex = 5;
            label_account.Text = "Don't have an account?";
            label_account.Click += label4_Click;
            // 
            // linkLabel_signUp_Pass
            // 
            linkLabel_signUp_Pass.AutoSize = true;
            linkLabel_signUp_Pass.Location = new Point(648, 392);
            linkLabel_signUp_Pass.Name = "linkLabel_signUp_Pass";
            linkLabel_signUp_Pass.Size = new Size(56, 25);
            linkLabel_signUp_Pass.TabIndex = 6;
            linkLabel_signUp_Pass.TabStop = true;
            linkLabel_signUp_Pass.Text = "Login";
            linkLabel_signUp_Pass.LinkClicked += linkLabel_signUp_Pass_LinkClicked;
            // 
            // label_usernamePass
            // 
            label_usernamePass.AutoSize = true;
            label_usernamePass.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_usernamePass.Location = new Point(426, 121);
            label_usernamePass.Name = "label_usernamePass";
            label_usernamePass.Size = new Size(81, 21);
            label_usernamePass.TabIndex = 7;
            label_usernamePass.Text = "Username";
            // 
            // username_PassRecovery
            // 
            username_PassRecovery.Location = new Point(426, 145);
            username_PassRecovery.Name = "username_PassRecovery";
            username_PassRecovery.PlaceholderText = "username";
            username_PassRecovery.Size = new Size(309, 31);
            username_PassRecovery.TabIndex = 8;
            // 
            // pass_recovery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 483);
            Controls.Add(username_PassRecovery);
            Controls.Add(label_usernamePass);
            Controls.Add(linkLabel_signUp_Pass);
            Controls.Add(label_account);
            Controls.Add(btn_continuePass);
            Controls.Add(label_EmailPass);
            Controls.Add(label_PassRecovery);
            Controls.Add(email_PassRecovery);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pass_recovery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayeTech";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_PassRecovery;
        private Label label_PassRecovery;
        private Label label_EmailPass;
        private Button btn_continuePass;
        private Label label_account;
        private LinkLabel linkLabel_signUp_Pass;
        private Label label_usernamePass;
        private TextBox username_PassRecovery;
    }
}