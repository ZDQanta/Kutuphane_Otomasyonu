namespace VTYS_proje
{
    partial class Yedekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yedekle));
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Veri Tabanları";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(29, 109);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(201, 202);
            checkedListBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(29, 79);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(257, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Bütün Veri Tabanlarını Seç";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(404, 37);
            button1.Name = "button1";
            button1.Size = new Size(194, 42);
            button1.TabIndex = 3;
            button1.Text = "Yedeklenecek Yer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(404, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(404, 156);
            button2.Name = "button2";
            button2.Size = new Size(194, 62);
            button2.TabIndex = 5;
            button2.Text = "Veri Tabanını Yedekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Yedekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Yedekle";
            Text = "Veri Tabanı Yedekle";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
    }
}