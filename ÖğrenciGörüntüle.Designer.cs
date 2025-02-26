namespace VTYSProjesi
{
    partial class ÖğrenciGörüntüle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciGörüntüle));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            Donem = new ComboBox();
            Fakulte = new ComboBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtEnrollment = new TextBox();
            txtSName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 131);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(510, 59);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 2;
            label2.Text = "Görüntüle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(522, 28);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(229, 157);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 1;
            label3.Text = "Kayıt No:";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchEnrollment.Location = new Point(327, 157);
            txtSearchEnrollment.Multiline = true;
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(187, 27);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(538, 156);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 261);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(Donem);
            panel2.Controls.Add(Fakulte);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 211);
            panel2.TabIndex = 5;
            // 
            // Donem
            // 
            Donem.FormattingEnabled = true;
            Donem.Location = new Point(622, 25);
            Donem.Name = "Donem";
            Donem.Size = new Size(216, 28);
            Donem.TabIndex = 19;
            // 
            // Fakulte
            // 
            Fakulte.FormattingEnabled = true;
            Fakulte.Location = new Point(184, 103);
            Fakulte.Name = "Fakulte";
            Fakulte.Size = new Size(195, 28);
            Fakulte.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(622, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 30);
            txtEmail.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(622, 65);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(216, 30);
            txtContact.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(747, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 31);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "İptal Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(622, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 31);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(495, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 31);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(498, 101);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 11;
            label9.Text = "Öğrenci Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 63);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 10;
            label8.Text = "Öğrenci İletişim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 28);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 9;
            label7.Text = "Öğrenci Dönemi";
            // 
            // txtEnrollment
            // 
            txtEnrollment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrollment.Location = new Point(184, 63);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.ReadOnly = true;
            txtEnrollment.Size = new Size(195, 30);
            txtEnrollment.TabIndex = 7;
            // 
            // txtSName
            // 
            txtSName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSName.Location = new Point(184, 22);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(195, 30);
            txtSName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 101);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 5;
            label6.Text = "Fakülte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 63);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Kayıt No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 25);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Öğrenci Adı";
            // 
            // ÖğrenciGörüntüle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(968, 711);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciGörüntüle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInformation";
            Load += ViewStudentInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtEnrollment;
        private TextBox txtSName;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtContact;
        private ComboBox Donem;
        private ComboBox Fakulte;
    }
}