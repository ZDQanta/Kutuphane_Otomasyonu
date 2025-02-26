namespace VTYS_proje
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            menuStrip1 = new MenuStrip();
            kitapToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            kitaplaraGözAtToolStripMenuItem = new ToolStripMenuItem();
            öğrenciToolStripMenuItem = new ToolStripMenuItem();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            öğrencilereGözAtToolStripMenuItem = new ToolStripMenuItem();
            emanetToolStripMenuItem = new ToolStripMenuItem();
            geriAlToolStripMenuItem = new ToolStripMenuItem();
            kitapDetaylarıToolStripMenuItem = new ToolStripMenuItem();
            yedekleToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kitapToolStripMenuItem, öğrenciToolStripMenuItem, emanetToolStripMenuItem, geriAlToolStripMenuItem, kitapDetaylarıToolStripMenuItem, yedekleToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1111, 83);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kitapToolStripMenuItem
            // 
            kitapToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            kitapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEkleToolStripMenuItem, kitaplaraGözAtToolStripMenuItem });
            kitapToolStripMenuItem.Image = (Image)resources.GetObject("kitapToolStripMenuItem.Image");
            kitapToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            kitapToolStripMenuItem.Size = new Size(133, 79);
            kitapToolStripMenuItem.Text = "Kitap";
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.Image = (Image)resources.GetObject("kitapEkleToolStripMenuItem.Image");
            kitapEkleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(231, 56);
            kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            kitapEkleToolStripMenuItem.Click += kitapEkleToolStripMenuItem_Click;
            // 
            // kitaplaraGözAtToolStripMenuItem
            // 
            kitaplaraGözAtToolStripMenuItem.Image = (Image)resources.GetObject("kitaplaraGözAtToolStripMenuItem.Image");
            kitaplaraGözAtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kitaplaraGözAtToolStripMenuItem.Name = "kitaplaraGözAtToolStripMenuItem";
            kitaplaraGözAtToolStripMenuItem.Size = new Size(231, 56);
            kitaplaraGözAtToolStripMenuItem.Text = "Kitaplara Göz At";
            kitaplaraGözAtToolStripMenuItem.Click += kitaplaraGözAtToolStripMenuItem_Click;
            // 
            // öğrenciToolStripMenuItem
            // 
            öğrenciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, öğrencilereGözAtToolStripMenuItem });
            öğrenciToolStripMenuItem.Image = (Image)resources.GetObject("öğrenciToolStripMenuItem.Image");
            öğrenciToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            öğrenciToolStripMenuItem.Size = new Size(140, 79);
            öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.Image = (Image)resources.GetObject("öğrenciEkleToolStripMenuItem.Image");
            öğrenciEkleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(248, 56);
            öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            öğrenciEkleToolStripMenuItem.Click += öğrenciEkleToolStripMenuItem_Click;
            // 
            // öğrencilereGözAtToolStripMenuItem
            // 
            öğrencilereGözAtToolStripMenuItem.Image = (Image)resources.GetObject("öğrencilereGözAtToolStripMenuItem.Image");
            öğrencilereGözAtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            öğrencilereGözAtToolStripMenuItem.Name = "öğrencilereGözAtToolStripMenuItem";
            öğrencilereGözAtToolStripMenuItem.Size = new Size(248, 56);
            öğrencilereGözAtToolStripMenuItem.Text = "Öğrencilere Göz At";
            öğrencilereGözAtToolStripMenuItem.Click += öğrencilereGözAtToolStripMenuItem_Click;
            // 
            // emanetToolStripMenuItem
            // 
            emanetToolStripMenuItem.Image = (Image)resources.GetObject("emanetToolStripMenuItem.Image");
            emanetToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            emanetToolStripMenuItem.Name = "emanetToolStripMenuItem";
            emanetToolStripMenuItem.Size = new Size(204, 79);
            emanetToolStripMenuItem.Text = "Kitap Emanet Et";
            emanetToolStripMenuItem.Click += emanetToolStripMenuItem_Click;
            // 
            // geriAlToolStripMenuItem
            // 
            geriAlToolStripMenuItem.Image = (Image)resources.GetObject("geriAlToolStripMenuItem.Image");
            geriAlToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            geriAlToolStripMenuItem.Size = new Size(173, 79);
            geriAlToolStripMenuItem.Text = "Kitap İade Al";
            geriAlToolStripMenuItem.Click += geriAlToolStripMenuItem_Click;
            // 
            // kitapDetaylarıToolStripMenuItem
            // 
            kitapDetaylarıToolStripMenuItem.Image = (Image)resources.GetObject("kitapDetaylarıToolStripMenuItem.Image");
            kitapDetaylarıToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kitapDetaylarıToolStripMenuItem.Name = "kitapDetaylarıToolStripMenuItem";
            kitapDetaylarıToolStripMenuItem.Size = new Size(164, 79);
            kitapDetaylarıToolStripMenuItem.Text = "Kitap Takibi";
            kitapDetaylarıToolStripMenuItem.Click += kitapDetaylarıToolStripMenuItem_Click;
            // 
            // yedekleToolStripMenuItem
            // 
            yedekleToolStripMenuItem.Image = (Image)resources.GetObject("yedekleToolStripMenuItem.Image");
            yedekleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            yedekleToolStripMenuItem.Name = "yedekleToolStripMenuItem";
            yedekleToolStripMenuItem.Size = new Size(149, 79);
            yedekleToolStripMenuItem.Text = "Yedekle";
            yedekleToolStripMenuItem.Click += yedekleToolStripMenuItem_Click;
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
            // Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1111, 539);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Panel";
            Text = "Panel";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitapToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem kitaplaraGözAtToolStripMenuItem;
        private ToolStripMenuItem öğrenciToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrencilereGözAtToolStripMenuItem;
        private ToolStripMenuItem emanetToolStripMenuItem;
        private ToolStripMenuItem geriAlToolStripMenuItem;
        private ToolStripMenuItem kitapDetaylarıToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem yedekleToolStripMenuItem;
    }
}