namespace VTYS_proje
{
    partial class ÖğrenciKütüphane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciKütüphane));
            panel2 = new System.Windows.Forms.Panel();
            Donem = new TextBox();
            Fakulte = new TextBox();
            txtBookName = new TextBox();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            btnCancel = new Button();
            btnIssue = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtEnrollment = new TextBox();
            txtSName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(Donem);
            panel2.Controls.Add(Fakulte);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePicker);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnIssue);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 250);
            panel2.TabIndex = 7;
            // 
            // Donem
            // 
            Donem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Donem.Location = new Point(622, 25);
            Donem.Name = "Donem";
            Donem.ReadOnly = true;
            Donem.Size = new Size(195, 30);
            Donem.TabIndex = 25;
            // 
            // Fakulte
            // 
            Fakulte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Fakulte.Location = new Point(184, 101);
            Fakulte.Name = "Fakulte";
            Fakulte.ReadOnly = true;
            Fakulte.Size = new Size(195, 30);
            Fakulte.TabIndex = 24;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(184, 195);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(195, 30);
            txtBookName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 195);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 22;
            label2.Text = "Kitap Adı";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(225, 149);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(248, 27);
            dateTimePicker.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 149);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 20;
            label1.Text = "Kitap Emanet Tarihi";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(622, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(216, 30);
            txtEmail.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(622, 65);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(216, 30);
            txtContact.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(787, 149);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 51);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "İptal Et";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            btnIssue.FlatStyle = FlatStyle.Popup;
            btnIssue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssue.Location = new Point(645, 149);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(124, 51);
            btnIssue.TabIndex = 12;
            btnIssue.Text = "Emanet Al";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
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
            txtSName.ReadOnly = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 261);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(244, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.AccessibleName = "";
            txtSearch.Location = new Point(40, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(181, 27);
            txtSearch.TabIndex = 9;
            txtSearch.Text = "ARAMA";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.UseWaitCursor = true;
            // 
            // ÖğrenciKütüphane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(968, 711);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciKütüphane";
            Text = "ÖğrenciKütüphane";
            Load += ÖğrenciKütüphane_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnCancel;
        private Button btnIssue;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtEnrollment;
        private TextBox txtSName;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private TextBox txtBookName;
        private Label label2;
        private TextBox Donem;
        private TextBox Fakulte;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}