namespace VTYS_proje
{
    partial class EmanetKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitaplar));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtEnrollement = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            label10 = new Label();
            comboBoxBooks = new ComboBox();
            btnIssueBook = new Button();
            dateTimePicker = new DateTimePicker();
            txtEmail = new TextBox();
            txtDep = new TextBox();
            txtSem = new TextBox();
            txtContact = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 158);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(418, 64);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 1;
            label1.Text = "Emanet Kitaplar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, -33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtEnrollement);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 413);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(143, 310);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(31, 310);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 35);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(55, 240);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Öğrenci Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrollement.Location = new Point(31, 188);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(206, 30);
            txtEnrollement.TabIndex = 2;
            txtEnrollement.TextChanged += txtEnrollement_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 147);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Kayıt No Giriniz";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBoxBooks);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtDep);
            panel3.Controls.Add(txtSem);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(275, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 413);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(25, 268);
            label10.Name = "label10";
            label10.Size = new Size(85, 23);
            label10.TabIndex = 15;
            label10.Text = "Kitap İsmi";
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(201, 260);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(248, 31);
            comboBoxBooks.TabIndex = 14;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.Location = new Point(321, 349);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(128, 35);
            btnIssueBook.TabIndex = 13;
            btnIssueBook.Text = "Emanet Kitap";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(201, 309);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(248, 27);
            dateTimePicker.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(201, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(248, 30);
            txtEmail.TabIndex = 11;
            // 
            // txtDep
            // 
            txtDep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDep.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDep.Location = new Point(201, 60);
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(248, 30);
            txtDep.TabIndex = 10;
            // 
            // txtSem
            // 
            txtSem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSem.Location = new Point(201, 110);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(248, 30);
            txtSem.TabIndex = 9;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(201, 160);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(248, 30);
            txtContact.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(201, 16);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(248, 30);
            txtName.TabIndex = 7;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(132, 387);
            label9.Name = "label9";
            label9.Size = new Size(340, 23);
            label9.TabIndex = 6;
            label9.Text = "Bir Öğrenci En Fazla 3 Kitap Emanet Alabilir";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 312);
            label8.Name = "label8";
            label8.Size = new Size(157, 23);
            label8.TabIndex = 5;
            label8.Text = "Kitap Emanet Tarihi";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 215);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 4;
            label7.Text = "Öğrenci Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 163);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 3;
            label6.Text = "Öğrenci İletişimi";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 113);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 2;
            label5.Text = "Öğrenci Dönemi";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 63);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 1;
            label4.Text = "Bölümü";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 19);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Öğrenci Adı";
            // 
            // EmanetKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 152, 2);
            ClientSize = new Size(749, 583);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmanetKitaplar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmanetKitaplar";
            Load += EmanetKitaplar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnSearch;
        private TextBox txtEnrollement;
        private Button btnExit;
        private Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDep;
        private TextBox txtSem;
        private TextBox txtContact;
        private TextBox txtName;
        private Label label9;
        private Button btnIssueBook;
        private DateTimePicker dateTimePicker;
        private Label label10;
        private ComboBox comboBoxBooks;
        private TextBox txtEmail;
    }
}