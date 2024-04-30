namespace Store
{
    partial class About_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Form));
            panel_about = new Panel();
            linkLabel = new LinkLabel();
            panel2_about = new Panel();
            label4 = new Label();
            panel3_about = new Panel();
            label1 = new Label();
            label_aboutHome = new Label();
            linkLabel_back = new LinkLabel();
            panel_about.SuspendLayout();
            panel2_about.SuspendLayout();
            panel3_about.SuspendLayout();
            SuspendLayout();
            // 
            // panel_about
            // 
            panel_about.BackColor = SystemColors.ActiveCaption;
            panel_about.Controls.Add(linkLabel);
            panel_about.Controls.Add(panel2_about);
            panel_about.Controls.Add(panel3_about);
            panel_about.Location = new Point(195, 76);
            panel_about.Name = "panel_about";
            panel_about.Size = new Size(724, 345);
            panel_about.TabIndex = 0;
            panel_about.Paint += panel1_Paint;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new Point(306, 304);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(98, 25);
            linkLabel.TabIndex = 2;
            linkLabel.TabStop = true;
            linkLabel.Text = "Contact Us";
            // 
            // panel2_about
            // 
            panel2_about.BackColor = SystemColors.GradientActiveCaption;
            panel2_about.Controls.Add(label4);
            panel2_about.Location = new Point(24, 172);
            panel2_about.Name = "panel2_about";
            panel2_about.Size = new Size(676, 102);
            panel2_about.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 40);
            label4.Name = "label4";
            label4.Size = new Size(564, 21);
            label4.TabIndex = 0;
            label4.Text = "Thank you for choosing KayeTech Gadget Store. We look forward to serving you!\r\n";
            // 
            // panel3_about
            // 
            panel3_about.BackColor = SystemColors.GradientActiveCaption;
            panel3_about.Controls.Add(label1);
            panel3_about.Location = new Point(24, 13);
            panel3_about.Name = "panel3_about";
            panel3_about.Size = new Size(676, 118);
            panel3_about.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(634, 63);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label_aboutHome
            // 
            label_aboutHome.AutoSize = true;
            label_aboutHome.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_aboutHome.Location = new Point(516, 33);
            label_aboutHome.Name = "label_aboutHome";
            label_aboutHome.Size = new Size(83, 28);
            label_aboutHome.TabIndex = 2;
            label_aboutHome.Text = "ABOUT ";
            // 
            // linkLabel_back
            // 
            linkLabel_back.AutoSize = true;
            linkLabel_back.Location = new Point(29, 33);
            linkLabel_back.Name = "linkLabel_back";
            linkLabel_back.Size = new Size(48, 25);
            linkLabel_back.TabIndex = 3;
            linkLabel_back.TabStop = true;
            linkLabel_back.Text = "Back";
            linkLabel_back.LinkClicked += linkLabel_back_LinkClicked;
            // 
            // About_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 483);
            Controls.Add(linkLabel_back);
            Controls.Add(label_aboutHome);
            Controls.Add(panel_about);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayeTech";
            Load += About_Form_Load;
            panel_about.ResumeLayout(false);
            panel_about.PerformLayout();
            panel2_about.ResumeLayout(false);
            panel2_about.PerformLayout();
            panel3_about.ResumeLayout(false);
            panel3_about.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_about;
        private Panel panel3_about;
        private Label label1;
        private Label label_aboutHome;
        private LinkLabel linkLabel;
        private Panel panel2_about;
        private Label label4;
        private LinkLabel linkLabel_back;
    }
}