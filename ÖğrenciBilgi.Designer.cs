namespace VTYS_proje
{
    partial class ÖğrenciBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciBilgi));
            Donem = new ComboBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            txtpass = new TextBox();
            label1 = new Label();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            Fakulte = new TextBox();
            SuspendLayout();
            // 
            // Donem
            // 
            Donem.FormattingEnabled = true;
            Donem.Location = new Point(141, 163);
            Donem.Name = "Donem";
            Donem.Size = new Size(195, 28);
            Donem.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(141, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 30);
            txtEmail.TabIndex = 29;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(141, 206);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(195, 30);
            txtContact.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 252);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 27;
            label9.Text = "Öğrenci Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 206);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 26;
            label8.Text = "Öğrenci İletişim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 163);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 25;
            label7.Text = "Öğrenci Dönemi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 124);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 22;
            label6.Text = "Fakülte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 81);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 21;
            label5.Text = "Kayıt No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 40);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 20;
            label4.Text = "Öğrenci Adı";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(113, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 31);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(242, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 31);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "İptal Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(141, 298);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(195, 30);
            txtpass.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 303);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 34;
            label1.Text = "Öğrenci Şifre";
            // 
            // txtEnrollment
            // 
            txtEnrollment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEnrollment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrollment.Location = new Point(141, 71);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.ReadOnly = true;
            txtEnrollment.Size = new Size(195, 30);
            txtEnrollment.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(141, 30);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(195, 30);
            txtName.TabIndex = 37;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // Fakulte
            // 
            Fakulte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Fakulte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Fakulte.Location = new Point(141, 114);
            Fakulte.Name = "Fakulte";
            Fakulte.ReadOnly = true;
            Fakulte.Size = new Size(195, 30);
            Fakulte.TabIndex = 38;
            // 
            // ÖğrenciBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(430, 407);
            Controls.Add(Fakulte);
            Controls.Add(txtName);
            Controls.Add(txtEnrollment);
            Controls.Add(txtpass);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(Donem);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciBilgi";
            Text = "ÖğrenciBilgi";
            Load += ÖğrenciBilgi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Donem;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtpass;
        private Label label1;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private TextBox Fakulte;
    }
}