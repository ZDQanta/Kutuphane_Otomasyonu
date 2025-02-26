namespace VTYS_proje
{
    partial class ÖğrenciAlınanKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciAlınanKitaplar));
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            btnIade = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(356, 358);
            label2.Name = "label2";
            label2.Size = new Size(222, 31);
            label2.TabIndex = 6;
            label2.Text = "İade Edilen Kitaplar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 187);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 4;
            label1.Text = "Emanet Alınan Kitaplar";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 403);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(933, 187);
            dataGridView2.TabIndex = 7;
            // 
            // btnIade
            // 
            btnIade.Location = new Point(320, 278);
            btnIade.Name = "btnIade";
            btnIade.Size = new Size(297, 57);
            btnIade.TabIndex = 8;
            btnIade.Text = "İade Et";
            btnIade.UseVisualStyleBackColor = true;
            btnIade.Click += btnIade_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 291);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // ÖğrenciAlınanKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(967, 602);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnIade);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciAlınanKitaplar";
            Text = "ÖğrenciAlınanKitaplar";
            Load += ÖğrenciAlınanKitaplar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
        private Button btnIade;
        private DateTimePicker dateTimePicker1;
    }
}