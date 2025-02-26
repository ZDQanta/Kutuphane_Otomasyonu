using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_proje
{
    public partial class ÖğrenciKaydol : Form
    {
        public ÖğrenciKaydol()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex ex = new Regex("^[0-9]{10}");
            bool isTrue = ex.IsMatch(txtContact.Text);
            if (!isTrue)
            {
                MessageBox.Show("Yanlış Telefon Numarası Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtName.Text != "" && txtEnrollment.Text != "" && Bolumler.Text != "" && Donemler.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
                {


                    String dep = Bolumler.Text;
                    String name = txtName.Text;
                    String enroll = txtEnrollment.Text;
                    String sem = Donemler.Text;
                    Int64 mobile = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String spass = txtÖğrenciŞifre.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = " insert into NewStudent (sname,enroll,dep,sem,contact,email,spass) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "','" + spass + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurun.", "Tavsiye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ÖğrenciKaydol_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Fakulte from Fakulteler", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    Bolumler.Items.Add(Sdr.GetString(i));
                }

            }
            Sdr.Close();
            con.Close();


            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd2 = new SqlCommand("select Donem from Donemler", con);
            SqlDataReader Sdr2 = cmd2.ExecuteReader();

            while (Sdr2.Read())
            {
                for (int i = 0; i < Sdr2.FieldCount; i++)
                {
                    Donemler.Items.Add(Sdr2.GetString(i));
                }

            }
            Sdr2.Close();
            con.Close();
        }
    }
}
