namespace VTYSProjesi
{
    partial class ÖğrenciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciEkle));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            Donemler = new ComboBox();
            Bolumler = new ComboBox();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 102);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(464, 36);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Ekle";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 332);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(Donemler);
            panel2.Controls.Add(Bolumler);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(293, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 332);
            panel2.TabIndex = 3;
            // 
            // Donemler
            // 
            Donemler.FormattingEnabled = true;
            Donemler.Location = new Point(281, 149);
            Donemler.Name = "Donemler";
            Donemler.Size = new Size(194, 28);
            Donemler.TabIndex = 16;
            // 
            // Bolumler
            // 
            Bolumler.FormattingEnabled = true;
            Bolumler.Location = new Point(281, 107);
            Bolumler.Name = "Bolumler";
            Bolumler.Size = new Size(194, 28);
            Bolumler.TabIndex = 15;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(304, 287);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 32);
            btnExit.TabIndex = 14;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(179, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 32);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(58, 287);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 32);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(281, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(281, 188);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(194, 27);
            txtContact.TabIndex = 10;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(281, 69);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(194, 27);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(281, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 27);
            txtName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 231);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 5;
            label7.Text = "Öğrenci Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 188);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 4;
            label6.Text = "Öğrenci İletişim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 145);
            label5.Name = "label5";
            label5.Size = new Size(155, 28);
            label5.TabIndex = 3;
            label5.Text = "Öğrenci Dönemi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 107);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 2;
            label4.Text = "Bölüm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 69);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 1;
            label3.Text = "Kayıt No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci Adı";
            // 
            // ÖğrenciEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ÖğrenciEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
        private ComboBox Bolumler;
        private ComboBox Donemler;
    }
}
