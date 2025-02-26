using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_proje
{
    public partial class ÖğrenciPanel : Form
    {
        public ÖğrenciPanel()
        {
            InitializeComponent();
        }
        public string ogrencinoo;
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğine Emin Misin ?", "Evet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciBilgi öğrenciBilgi = new ÖğrenciBilgi();
            öğrenciBilgi.ogrno = ogrencino.Text;
            öğrenciBilgi.Show();
        }
        private void öğrencilereGözAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciAlınanKitaplar öğrenciAlınanKitaplar = new ÖğrenciAlınanKitaplar();
            öğrenciAlınanKitaplar.ogrno = ogrencino.Text;
            öğrenciAlınanKitaplar.Show();
        }
        private void ÖğrenciPanel_Load(object sender, EventArgs e)
        {
            ogrencino.Text = ogrencinoo;
            ogrencino.Text = ogrencinoo;
        }

        private void emanetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciKütüphane öğrenciKütüphane = new ÖğrenciKütüphane();
            öğrenciKütüphane.ogrno = ogrencino.Text;
            öğrenciKütüphane.Show();
        }
    }
}
