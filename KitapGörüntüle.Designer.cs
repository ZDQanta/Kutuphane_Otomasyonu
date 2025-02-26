namespace VTYS_proje
{
    partial class KitapGörüntüle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapGörüntüle));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtName = new TextBox();
            btnRefresh = new Button();
            panel2 = new System.Windows.Forms.Panel();
            txtKategori = new ComboBox();
            label9 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtPrice = new TextBox();
            txtPage = new TextBox();
            txtPubl = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_import = new Button();
            btn_export = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 141);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(531, 52);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 1;
            label1.Text = "Kitap Görüntüle";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(909, 297);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 177);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 2;
            label2.Text = "Kitap İsmi";
            // 
            // txtName
            // 
            txtName.Location = new Point(333, 177);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 3;
            txtName.Click += txtName_Click;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(597, 175);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(159, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(txtKategori);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPage);
            panel2.Controls.Add(txtPubl);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 543);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 336);
            panel2.TabIndex = 5;
            // 
            // txtKategori
            // 
            txtKategori.FormattingEnabled = true;
            txtKategori.Location = new Point(145, 200);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(188, 28);
            txtKategori.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(46, 200);
            label9.Name = "label9";
            label9.Size = new Size(80, 24);
            label9.TabIndex = 15;
            label9.Text = "Kategori";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(513, 261);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 44);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 44);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(220, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 44);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(603, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(519, 99);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtPage
            // 
            txtPage.Location = new Point(519, 147);
            txtPage.Name = "txtPage";
            txtPage.Size = new Size(250, 27);
            txtPage.TabIndex = 9;
            // 
            // txtPubl
            // 
            txtPubl.Location = new Point(145, 144);
            txtPubl.Name = "txtPubl";
            txtPubl.Size = new Size(188, 27);
            txtPubl.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(145, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(188, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(145, 44);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(188, 27);
            txtBookName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(408, 44);
            label8.Name = "label8";
            label8.Size = new Size(167, 24);
            label8.TabIndex = 5;
            label8.Text = "Satın Alınma Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(408, 99);
            label7.Name = "label7";
            label7.Size = new Size(50, 24);
            label7.TabIndex = 4;
            label7.Text = "Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(408, 147);
            label6.Name = "label6";
            label6.Size = new Size(105, 24);
            label6.TabIndex = 3;
            label6.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 92);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 2;
            label5.Text = "Yazar İsmi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 147);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 1;
            label4.Text = "Yayın Evi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 44);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 0;
            label3.Text = "Kitap İsmi";
            // 
            // btn_import
            // 
            btn_import.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_import.Location = new Point(12, 175);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(159, 29);
            btn_import.TabIndex = 6;
            btn_import.Text = "Excelden Aktar";
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // btn_export
            // 
            btn_export.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_export.Location = new Point(762, 175);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(159, 29);
            btn_export.TabIndex = 7;
            btn_export.Text = "Dışa Aktar";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // KitapGörüntüle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(933, 891);
            Controls.Add(btn_export);
            Controls.Add(btn_import);
            Controls.Add(panel2);
            Controls.Add(btnRefresh);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KitapGörüntüle";
            Text = "KitapGörüntüle";
            Load += KitapGörüntüle_Load;
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

        private System.Windows.Forms.Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtName;
        private Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private TextBox txtBookName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPrice;
        private TextBox txtPage;
        private TextBox txtPubl;
        private TextBox txtAuthor;
        private ComboBox txtKategori;
        private Label label9;
        private Button btn_import;
        private Button btn_export;
    }
}