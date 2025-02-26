namespace VTYS_proje
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignup = new Button();
            button3 = new Button();
            btnstudentlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(35, 36, 55);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(88, 178);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 27);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Kullanıcı Adı";
            txtUsername.MouseClick += txtUsername_MouseClick;
            txtUsername.MouseEnter += txtUsername_MouseEnter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 36, 55);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(88, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Parola";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(35, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(274, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = Color.Black;
            btnSignup.Location = new Point(35, 365);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(274, 45);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Kaydol";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(312, 12);
            button3.Name = "button3";
            button3.Size = new Size(25, 29);
            button3.TabIndex = 7;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnstudentlogin
            // 
            btnstudentlogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnstudentlogin.ForeColor = Color.Black;
            btnstudentlogin.Location = new Point(35, 427);
            btnstudentlogin.Name = "btnstudentlogin";
            btnstudentlogin.Size = new Size(274, 46);
            btnstudentlogin.TabIndex = 8;
            btnstudentlogin.Text = "Öğrenci Giriş\r\n";
            btnstudentlogin.UseVisualStyleBackColor = true;
            btnstudentlogin.Click += btnstudentlogin_Click;
            // 
            // Giriş
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(349, 500);
            Controls.Add(btnstudentlogin);
            Controls.Add(button3);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Giriş";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Giriş_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignup;
        private Button button3;
        private Button btnstudentlogin;
    }
}