namespace VTYS_proje
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            button1 = new Button();
            button2 = new Button();
            txtName = new TextBox();
            txtPass = new TextBox();
            txtUsername = new TextBox();
            txtSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 402);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 402);
            button2.Name = "button2";
            button2.Size = new Size(112, 49);
            button2.TabIndex = 1;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(128, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 27);
            txtName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(128, 286);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(192, 27);
            txtPass.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(127, 239);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(127, 187);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(192, 27);
            txtSurname.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(21, 140);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(21, 187);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(21, 239);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 8;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(21, 286);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Parola";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Kaydol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(349, 500);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSurname);
            Controls.Add(txtUsername);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Kaydol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kaydol";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtName;
        private TextBox txtPass;
        private TextBox txtUsername;
        private TextBox txtSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}