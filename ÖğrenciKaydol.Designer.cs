namespace VTYS_proje
{
    partial class ÖğrenciKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciKaydol));
            btnCancel = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            Donemler = new ComboBox();
            Bolumler = new ComboBox();
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
            txtÖğrenciŞifre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(265, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 49);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(66, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 49);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Donemler
            // 
            Donemler.FormattingEnabled = true;
            Donemler.Location = new Point(265, 248);
            Donemler.Name = "Donemler";
            Donemler.Size = new Size(194, 28);
            Donemler.TabIndex = 32;
            // 
            // Bolumler
            // 
            Bolumler.FormattingEnabled = true;
            Bolumler.Location = new Point(265, 206);
            Bolumler.Name = "Bolumler";
            Bolumler.Size = new Size(194, 28);
            Bolumler.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(265, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 30;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(265, 287);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(194, 27);
            txtContact.TabIndex = 29;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(265, 168);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(194, 27);
            txtEnrollment.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.Location = new Point(265, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 27);
            txtName.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(26, 330);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 26;
            label7.Text = "Öğrenci Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(26, 287);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 25;
            label6.Text = "Öğrenci İletişim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(26, 244);
            label5.Name = "label5";
            label5.Size = new Size(155, 28);
            label5.TabIndex = 24;
            label5.Text = "Öğrenci Dönemi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(26, 206);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 23;
            label4.Text = "Bölüm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(26, 168);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 22;
            label3.Text = "Kayıt No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 21;
            label2.Text = "Öğrenci Adı";
            // 
            // txtÖğrenciŞifre
            // 
            txtÖğrenciŞifre.Location = new Point(265, 375);
            txtÖğrenciŞifre.Name = "txtÖğrenciŞifre";
            txtÖğrenciŞifre.Size = new Size(194, 27);
            txtÖğrenciŞifre.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(26, 375);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 33;
            label1.Text = "Öğrenci Şifresi";
            // 
            // ÖğrenciKaydol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(497, 500);
            Controls.Add(txtÖğrenciŞifre);
            Controls.Add(label1);
            Controls.Add(Donemler);
            Controls.Add(Bolumler);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtEnrollment);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciKaydol";
            Text = "ÖğrenciKaydol";
            Load += ÖğrenciKaydol_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnSave;
        private PictureBox pictureBox1;
        private ComboBox Donemler;
        private ComboBox Bolumler;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtÖğrenciŞifre;
        private Label label1;
    }
}