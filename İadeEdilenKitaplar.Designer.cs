namespace VTYS_proje
{
    partial class İadeEdilenKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İadeEdilenKitaplar));
            panel1 = new System.Windows.Forms.Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBookIssueDate = new TextBox();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(5, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 368);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(142, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(16, 297);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchStudent.Location = new Point(55, 230);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(152, 34);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Öğrenci Ara";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnterEnroll.Location = new Point(16, 176);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(220, 30);
            txtEnterEnroll.TabIndex = 2;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 136);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 1;
            label1.Text = "Kayıt No Giriniz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 368);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(269, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 141);
            panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(527, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(527, 52);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "İade";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(227, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(226, 54);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.ReadOnly = true;
            txtBookIssueDate.Size = new Size(260, 27);
            txtBookIssueDate.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(227, 12);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(259, 27);
            txtBookName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 104);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 2;
            label4.Text = "Kitap İade Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 57);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 1;
            label3.Text = "Kitap Emanet Tarihi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 15);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Kitap İsmi";
            // 
            // İadeEdilenKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(252, 152, 2);
            ClientSize = new Size(989, 530);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "İadeEdilenKitaplar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İadeEdilenKitaplar";
            Load += İadeEdilenKitaplar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private TextBox txtEnterEnroll;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBookIssueDate;
        private TextBox txtBookName;
    }
}