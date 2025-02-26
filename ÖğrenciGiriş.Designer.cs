namespace VTYS_proje
{
    partial class ÖğrenciGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciGiriş));
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            btnSignup = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 36, 55);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(77, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 27);
            txtPassword.TabIndex = 8;
            txtPassword.Text = "Parola";
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(35, 36, 55);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(77, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 27);
            txtUsername.TabIndex = 7;
            txtUsername.Text = "Kullanıcı Adı";
            txtUsername.MouseClick += txtUsername_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = Color.Black;
            btnSignup.Location = new Point(24, 347);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(274, 45);
            btnSignup.TabIndex = 10;
            btnSignup.Text = "Kaydol";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(24, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(274, 43);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(294, 12);
            button3.Name = "button3";
            button3.Size = new Size(25, 29);
            button3.TabIndex = 12;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.MouseClick += button3_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // ÖğrenciGiriş
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(331, 453);
            Controls.Add(pictureBox3);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciGiriş";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ÖğrenciGiriş";
            Load += ÖğrenciGiriş_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private Button btnSignup;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox3;
    }
}