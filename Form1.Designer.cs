namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            button2 = new Button();
            pictureBoxInstagram = new PictureBox();
            pictureBoxGithub = new PictureBox();
            pictureBoxTwitter = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGithub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTwitter).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(35, 36, 55);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(98, 167);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(162, 16);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username";
            txtUsername.MouseClick += txtUsername_MouseClick;
            txtUsername.MouseEnter += txtUsername_MouseEnter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 36, 55);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(98, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(162, 16);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Senha";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(67, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(67, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(98, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 1);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(98, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 1);
            panel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(67, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(193, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Cyan;
            button2.Location = new Point(67, 307);
            button2.Name = "button2";
            button2.Size = new Size(193, 36);
            button2.TabIndex = 8;
            button2.Text = "Inscrever-se";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBoxInstagram
            // 
            pictureBoxInstagram.Image = (Image)resources.GetObject("pictureBoxInstagram.Image");
            pictureBoxInstagram.Location = new Point(67, 378);
            pictureBoxInstagram.Name = "pictureBoxInstagram";
            pictureBoxInstagram.Size = new Size(49, 50);
            pictureBoxInstagram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInstagram.TabIndex = 9;
            pictureBoxInstagram.TabStop = false;
            pictureBoxInstagram.Click += pictureBoxInstagram_Click;
            // 
            // pictureBoxGithub
            // 
            pictureBoxGithub.Image = (Image)resources.GetObject("pictureBoxGithub.Image");
            pictureBoxGithub.Location = new Point(136, 378);
            pictureBoxGithub.Name = "pictureBoxGithub";
            pictureBoxGithub.Size = new Size(49, 50);
            pictureBoxGithub.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGithub.TabIndex = 10;
            pictureBoxGithub.TabStop = false;
            pictureBoxGithub.Click += pictureBoxGithub_Click;
            // 
            // pictureBoxTwitter
            // 
            pictureBoxTwitter.Image = (Image)resources.GetObject("pictureBoxTwitter.Image");
            pictureBoxTwitter.Location = new Point(211, 378);
            pictureBoxTwitter.Name = "pictureBoxTwitter";
            pictureBoxTwitter.Size = new Size(49, 50);
            pictureBoxTwitter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTwitter.TabIndex = 11;
            pictureBoxTwitter.TabStop = false;
            pictureBoxTwitter.Click += pictureBoxTwitter_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(304, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 23);
            btnClose.TabIndex = 12;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(333, 461);
            Controls.Add(btnClose);
            Controls.Add(pictureBoxTwitter);
            Controls.Add(pictureBoxGithub);
            Controls.Add(pictureBoxInstagram);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGithub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTwitter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private Button button2;
        private PictureBox pictureBoxInstagram;
        private PictureBox pictureBoxGithub;
        private PictureBox pictureBoxTwitter;
        private Button btnClose;
    }
}