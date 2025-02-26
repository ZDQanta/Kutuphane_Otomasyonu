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
using System.Xml.Linq;

namespace VTYS_proje
{
    public partial class ÖğrenciAlınanKitaplar : Form
    {
        public ÖğrenciAlınanKitaplar()
        {
            InitializeComponent();
        }
        public string ogrno;
        private void ÖğrenciAlınanKitaplar_Load(object sender, EventArgs e)
        {
            string eid = ogrno;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where book_return_date is null and std_enroll = '" + eid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cmd.CommandText = "select * from IRBook where book_return_date is not null and std_enroll = '" + eid + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date ='" + dateTimePicker1.Text + "'where std_enroll= '" + ogrno + "'and id =" + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kitap İade Edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ÖğrenciAlınanKitaplar_Load(this, null);
        }
        String bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
