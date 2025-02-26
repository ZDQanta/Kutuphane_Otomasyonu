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
    public partial class ÖğrenciKütüphane : Form
    {
        private string connectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
        public ÖğrenciKütüphane()
        {
            InitializeComponent();
        }
        public string ogrno;
        Int64 rowid;
        private void ÖğrenciKütüphane_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select bid,bname,bAuthor,bPubl,bPage,kategorii from NewBook";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            con.Open();

            cmd2 = new SqlCommand("select Fakulte from Fakulteler", con);
            SqlDataReader Sdr = cmd2.ExecuteReader();

            con.Close();


            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            con.Open();

            cmd3 = new SqlCommand("select Donem from Donemler", con);
            SqlDataReader Sdr2 = cmd3.ExecuteReader();


            con.Close();
        }

        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bid = " + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DSS = new DataSet();
            DA.Fill(DSS);


            txtBookName.Text = DSS.Tables[0].Rows[0][1].ToString();


            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con2;

            cmd2.CommandText = "select * from NewStudent where enroll = " + ogrno + "";
            SqlDataAdapter DA2 = new SqlDataAdapter(cmd2);
            DataSet DS = new DataSet();
            DA2.Fill(DS);



            txtSName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = DS.Tables[0].Rows[0][2].ToString();
            Fakulte.Text = DS.Tables[0].Rows[0][3].ToString();
            Donem.Text = DS.Tables[0].Rows[0][4].ToString();
            txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
        }



        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtSName.Text != "")
            {

                String enroll = txtEnrollment.Text;
                String sname = txtSName.Text;
                String sdep = Fakulte.Text;
                String sem = Donem.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;
                String bookname = txtBookName.Text;
                String bookIssueDate = dateTimePicker.Text;

                String eid = txtEnrollment.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date)values('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kitap Emanet Verildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kitap Şeçilemedi yada Maksimun Emanet Sayısına Ulaşıldı", "Kitap Şeçilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_SearchBook", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Depolanan procedure parametrelerini ekleyebilirsiniz
                        command.Parameters.AddWithValue("@SearchKeyword", txtSearch.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Sonuçları DataGridView kontrolünde görüntüle
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

