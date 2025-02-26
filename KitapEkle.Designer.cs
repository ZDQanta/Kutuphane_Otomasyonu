namespace VTYS_proje
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            pictureBox1 = new PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            txtKategori = new ComboBox();
            label8 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 83);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(392, 27);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 1;
            label1.Text = "Kitap Ekle";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(txtKategori);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cancelButton);
            panel2.Controls.Add(saveButton);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(273, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 432);
            panel2.TabIndex = 2;
            // 
            // txtKategori
            // 
            txtKategori.FormattingEnabled = true;
            txtKategori.Location = new Point(212, 307);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(289, 28);
            txtKategori.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(32, 311);
            label8.Name = "label8";
            label8.Size = new Size(80, 24);
            label8.TabIndex = 15;
            label8.Text = "Kategori";
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.Location = new Point(371, 351);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(130, 38);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "İptal";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(212, 351);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(142, 38);
            saveButton.TabIndex = 13;
            saveButton.Text = "Kaydet";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(212, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(213, 259);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(288, 31);
            txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(213, 210);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(288, 31);
            txtPrice.TabIndex = 10;
            // 
            // txtPublication
            // 
            txtPublication.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublication.Location = new Point(213, 113);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(288, 31);
            txtPublication.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(213, 66);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(288, 31);
            txtAuthor.TabIndex = 7;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(213, 19);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(288, 31);
            txtBookName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 266);
            label7.Name = "label7";
            label7.Size = new Size(105, 24);
            label7.TabIndex = 5;
            label7.Text = "Sayfa Sayısı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 217);
            label6.Name = "label6";
            label6.Size = new Size(55, 24);
            label6.TabIndex = 4;
            label6.Text = "Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 170);
            label5.Name = "label5";
            label5.Size = new Size(151, 24);
            label5.TabIndex = 3;
            label5.Text = "Satın Alma Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 120);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 2;
            label4.Text = "Yayınevi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 73);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 1;
            label3.Text = "Yazar İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 26);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 0;
            label2.Text = "Kitap İsmi";
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KitapEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KitapEkle";
            Load += KitapEkle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button cancelButton;
        private Button saveButton;
        private DateTimePicker dateTimePicker1;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private ComboBox txtKategori;
        private Label label8;
    }
}