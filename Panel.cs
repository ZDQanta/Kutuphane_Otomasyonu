using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTYSProjesi;

namespace VTYS_proje
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğine Emin Misin ?", "Evet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle ke = new KitapEkle();
            ke.Show();
        }

        private void kitaplaraGözAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapGörüntüle kG = new KitapGörüntüle();
            kG.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciEkle ast = new ÖğrenciEkle();
            ast.Show();
        }

        private void öğrencilereGözAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciGörüntüle vsi = new ÖğrenciGörüntüle();
            vsi.Show();
        }

        private void kitapDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenelKitapBilgileri cbd = new GenelKitapBilgileri();
            cbd.Show();
        }

        private void emanetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetKitaplar EK = new EmanetKitaplar();
            EK.Show();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İadeEdilenKitaplar ied = new İadeEdilenKitaplar();
            ied.Show();
        }

        private void yedekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yedekle yedekle = new Yedekle();
            yedekle.Show();
        }
    }
}
