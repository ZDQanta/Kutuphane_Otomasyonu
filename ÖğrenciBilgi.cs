using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VTYS_proje
{
    public partial class ÖğrenciBilgi : Form
    {
        public string ogrno;
        public ÖğrenciBilgi()
        {

            InitializeComponent();
        }
        Int64 rowid;
        private void ÖğrenciBilgi_Load(object sender, EventArgs e)
        {
            string eid = ogrno;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());
            txtName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = DS.Tables[0].Rows[0][2].ToString();
            Fakulte.Text = DS.Tables[0].Rows[0][3].ToString();
            Donem.Text = DS.Tables[0].Rows[0][4].ToString();
            txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
            txtpass.Text = DS.Tables[0].Rows[0][9].ToString();

            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd2 = new SqlCommand("select Donem from Donemler", con);
            SqlDataReader Sdr2 = cmd2.ExecuteReader();

            while (Sdr2.Read())
            {
                for (int i = 0; i < Sdr2.FieldCount; i++)
                {
                    Donem.Items.Add(Sdr2.GetString(i));
                }

            }
            Sdr2.Close();
            con.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sem = Donem.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string semail = txtEmail.Text;
            string spass = txtpass.Text;
            if (MessageBox.Show("Veri Güncellenecek. Onaylıyor Musunuz?", "Güncelleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set  sem = '" + sem + "', contact = '" + contact + "', email = '" + semail + "', spass = '" + spass + "' where stuid = " + rowid + " ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydedilmemiş Veri Kaybolacak.", "Emin Misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
