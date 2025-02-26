namespace VTYS_proje
{
    partial class ÖğrenciPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciPanel));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            bilgilerimToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            öğrenciToolStripMenuItem = new ToolStripMenuItem();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            öğrencilereGözAtToolStripMenuItem = new ToolStripMenuItem();
            emanetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            ogrencino = new Label();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { bilgilerimToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(143, 28);
            // 
            // bilgilerimToolStripMenuItem
            // 
            bilgilerimToolStripMenuItem.Name = "bilgilerimToolStripMenuItem";
            bilgilerimToolStripMenuItem.Size = new Size(142, 24);
            bilgilerimToolStripMenuItem.Text = "Bilgilerim";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrenciToolStripMenuItem, emanetToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 83);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciToolStripMenuItem
            // 
            öğrenciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, öğrencilereGözAtToolStripMenuItem });
            öğrenciToolStripMenuItem.Image = (Image)resources.GetObject("öğrenciToolStripMenuItem.Image");
            öğrenciToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            öğrenciToolStripMenuItem.Size = new Size(152, 79);
            öğrenciToolStripMenuItem.Text = "Bilgilerim";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.Image = (Image)resources.GetObject("öğrenciEkleToolStripMenuItem.Image");
            öğrenciEkleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(231, 56);
            öğrenciEkleToolStripMenuItem.Text = "Bilgilerim";
            öğrenciEkleToolStripMenuItem.Click += öğrenciEkleToolStripMenuItem_Click;
            // 
            // öğrencilereGözAtToolStripMenuItem
            // 
            öğrencilereGözAtToolStripMenuItem.Image = (Image)resources.GetObject("öğrencilereGözAtToolStripMenuItem.Image");
            öğrencilereGözAtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            öğrencilereGözAtToolStripMenuItem.Name = "öğrencilereGözAtToolStripMenuItem";
            öğrencilereGözAtToolStripMenuItem.Size = new Size(231, 56);
            öğrencilereGözAtToolStripMenuItem.Text = "Aldığım Kitaplar";
            öğrencilereGözAtToolStripMenuItem.Click += öğrencilereGözAtToolStripMenuItem_Click;
            // 
            // emanetToolStripMenuItem
            // 
            emanetToolStripMenuItem.Image = (Image)resources.GetObject("emanetToolStripMenuItem.Image");
            emanetToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            emanetToolStripMenuItem.Name = "emanetToolStripMenuItem";
            emanetToolStripMenuItem.Size = new Size(169, 79);
            emanetToolStripMenuItem.Text = "Kütüphane";
            emanetToolStripMenuItem.Click += emanetToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Image = (Image)resources.GetObject("çıkışToolStripMenuItem.Image");
            çıkışToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(103, 79);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // ogrencino
            // 
            ogrencino.AutoSize = true;
            ogrencino.BackColor = Color.White;
            ogrencino.Font = new Font("Segoe UI Light", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            ogrencino.ForeColor = Color.Black;
            ogrencino.Location = new Point(0, 83);
            ogrencino.Name = "ogrencino";
            ogrencino.Size = new Size(6, 3);
            ogrencino.TabIndex = 3;
            ogrencino.Text = "label1";
            ogrencino.Visible = false;
            // 
            // ÖğrenciPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ogrencino);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÖğrenciPanel";
            Text = "ÖğrenciPanel";
            WindowState = FormWindowState.Maximized;
            Load += ÖğrenciPanel_Load;
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem bilgilerimToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrenciToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem emanetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem öğrencilereGözAtToolStripMenuItem;
        private Label ogrencino;
    }
}