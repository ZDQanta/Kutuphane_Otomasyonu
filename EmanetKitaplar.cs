using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_proje
{
    public partial class EmanetKitaplar : Form
    {
        public EmanetKitaplar()
        {
            InitializeComponent();
        }

        private void EmanetKitaplar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from Newbook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }

            }
            Sdr.Close();
            con.Close();
        }
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                String eid = txtEnrollement.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //-----------------------------------------------------------------------------
                // Bu kod bir  kayıt no sunun kaç kitap emanet aldığını sayar
                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //------------------------------------------------------------------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Geçersiz Kayıt No", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1)
                {
                    String enroll = txtEnrollement.Text;
                    String bookname = comboBoxBooks.Text;

                    // Kitabın daha önce alınıp alınmadığını kontrol et
                    if (!IsBookAlreadyIssued(enroll, bookname))
                    {
                        // Kitap daha önce alınmamışsa işlemi devam ettir
                        String sname = txtName.Text;
                        String sdep = txtDep.Text;
                        String sem = txtSem.Text;
                        Int64 contact = Int64.Parse(txtContact.Text);
                        String email = txtEmail.Text;
                        String bookIssueDate = dateTimePicker.Text;

                        String eid = txtEnrollement.Text;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        con.Open();

                        // IRBook tablosuna yeni kaydı ekle
                        cmd.CommandText = "INSERT INTO IRBook (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date, book_return_date) VALUES ('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "', NULL)";
                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Kitap Emanet Verildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci zaten bu kitabı almış durumda.", "Kitap Zaten Alınmış", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir kitap seçiniz.", "Kitap Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geçerli Kayıt No Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollement.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();

            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollement.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }
        private bool IsBookAlreadyIssued(string enrollment, string bookName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            // Kitabın daha önce alınıp alınmadığını kontrol et
            cmd.CommandText = "SELECT COUNT(*) FROM IRBook WHERE std_enroll = '" + enrollment + "' AND book_name = '" + bookName + "' AND book_return_date IS NULL";
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            return count > 0;
        }
    }
}
