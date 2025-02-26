using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_proje
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtQuantity.Text != "")
            {


                string kategori = txtKategori.Text;
                string bName = txtBookName.Text;
                string bAuthor = txtAuthor.Text;
                string pDate = dateTimePicker1.Text;
                string publication = txtPublication.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 sayfa = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bPage,kategorii) values ('" + bName + "','" + bAuthor + "','" + publication + "','" + pDate + "','" + price + "','" + sayfa + "','" + kategori + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgiler Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz", "Emin Misiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Kategori from Kategoriler", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    txtKategori.Items.Add(Sdr.GetString(i));
                }

            }
            Sdr.Close();
            con.Close();
        }
    }
}
