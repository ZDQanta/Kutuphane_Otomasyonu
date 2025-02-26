using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

using DataTable = System.Data.DataTable;
using excel = Microsoft.Office.Interop.Excel;


namespace VTYS_proje
{
    public partial class KitapGörüntüle : Form
    {
        public KitapGörüntüle()
        {
            InitializeComponent();
        }

        private void KitapGörüntüle_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            //burda kitap görüntüleme için açtığımız datagrigView1 e sql de oluşturmuş olduğumuz tabloyu getirir ve görüntülememizi sağlayan kodlar var.
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            Info info = new Info();
            con.ConnectionString = info.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //üstteki işlemde çekmiş olduğumuz tabloları dataset tipinde bir obje oluşturup onun içine sığdırıyoruz bu dataset tablo tutuyor.

            dataGridView1.DataSource = ds.Tables[0];

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            con.Open();

            cmd2 = new SqlCommand("select Kategori from Kategoriler", con);
            SqlDataReader Sdr = cmd2.ExecuteReader();

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
        int bid;
        Int64 rowID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //bu kod bize boş olmayan bir satırın herhangi bir yerine bastıımızda bookid sini göstermeye yarıyor.
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            // con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            Info info = new Info();
            con.ConnectionString = info.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bid =" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //satır numarasını veren id bid ise kitap no yu veren id .
            rowID = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPubl.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPage.Text = ds.Tables[0].Rows[0][6].ToString();
            txtKategori.Text = ds.Tables[0].Rows[0][8].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                Info info = new Info();
                con.ConnectionString = info.ConnectionString;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    if (txtBookName.Text != "")
                    {
                        cmd.CommandText = "SELECT * FROM NewBook WHERE bName LIKE @BookName";
                        cmd.Parameters.AddWithValue("@BookName", txtBookName.Text + "%");
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM NewBook";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            panel2.Visible = false;
            KitapGörüntüle_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kitap Bilgilerini Güncellemek İstediğinize Emin Misiniz ?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string kategori = txtKategori.Text;
                string pdate = dateTimePicker1.Text;
                string bname = txtBookName.Text;
                Int64 sayfa = Int64.Parse(txtPage.Text);
                string bauthor = txtAuthor.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                string publ = txtPubl.Text;


                SqlConnection con = new SqlConnection();
                Info info = new Info();
                con.ConnectionString = info.ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewBook set bName = '" + bname + "',bAuthor = '" + bauthor + "',bPubl = '" + publ + "',bPDate = '" + pdate + "',bPrice = " + price + ",bPage = " + sayfa + ",kategorii = '" + kategori + "' where bid = " + rowID + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                KitapGörüntüle_Load(this, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kitap Bilgilerini Silmek İstediğinize Emin Misiniz ?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection();
                Info info = new Info();
                con.ConnectionString = info.ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewBook where bid = " + rowID + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                KitapGörüntüle_Load(this, null);
            }
        }
        bool export_dgw_excel_1(DataGridView dgw)
        {
            //Add Reference Microsoft.Office.Interop.Excel kütüphanesini ekleyin
            //using satırlarına using Excel = Microsoft.Office.Interop.Excel; satırını ekleyin.
            bool durum = false;
            try
            {
                dgw.SelectAll();
                DataObject dataObj = dgw.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                excel.Application xlexcel;
                excel.Workbook xlWorkBook;
                excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                excel.Range CR = (excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                //Kodumuz buraya kadar gelip veri aktarımını tamamladı ise durum true yaparak işlemin başarılı
                //Olduğu bilgisini alıyoruz.
                durum = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid Verileri Aktarılamadı : " + ex.Message);
            }
            return durum;



        }




        private void btn_export_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                excel.Range alan = (excel.Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    excel.Range alan2 = (excel.Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridView1[i, j].Value;
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    string filepath = op.FileName;
                    string con = "Provider=Microsoft.Ace.OleDb.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR={1}'";
                    con = string.Format(con, filepath, "yes");

                    using (OleDbConnection excelConnection = new OleDbConnection(con))
                    {
                        excelConnection.Open();
                        DataTable dtexcel = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();

                        OleDbCommand com = new OleDbCommand("Select * from [" + excelsheet + "]", excelConnection);
                        OleDbDataAdapter oda = new OleDbDataAdapter(com);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);

                        excelConnection.Close();

                        // Verileri DataGridView'e yükle
                        dataGridView1.DataSource = dt;

                        // Veritabanına aktar
                        string connectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                        using (SqlConnection dbConnection = new SqlConnection(connectionString))
                        {
                            dbConnection.Open();

                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = dbConnection;

                                foreach (DataRow row in dt.Rows)
                                {
                                    // Örneğin, veritabanında "NewBook" adında bir tablo olduğunu varsayalım
                                    cmd.CommandText = "INSERT INTO NewBook ( bName, bAuthor, bPubl, bPDate, bPrice, bPage, KategoriID, kategorii) " +
                                                      "VALUES ( @Column2, @Column3, @Column4, @Column5, @Column6, @Column7, @Column8, @Column9)";

                                    // Parametre değerlerini ayarla (kolon adlarına göre düzenle)

                                    cmd.Parameters.AddWithValue("@Column2", row["bName"]);
                                    cmd.Parameters.AddWithValue("@Column3", row["bAuthor"]);
                                    cmd.Parameters.AddWithValue("@Column4", row["bPubl"]);
                                    cmd.Parameters.AddWithValue("@Column5", row["bPDate"]);
                                    cmd.Parameters.AddWithValue("@Column6", row["bPrice"]);
                                    cmd.Parameters.AddWithValue("@Column7", row["bPage"]);
                                    cmd.Parameters.AddWithValue("@Column8", row["KategoriID"]);
                                    cmd.Parameters.AddWithValue("@Column9", row["kategorii"]);



                                    // Komutu çalıştır

                                    cmd.ExecuteNonQuery();


                                    // Parametreleri temizle
                                    cmd.Parameters.Clear();
                                }
                            }

                            dbConnection.Close();
                        }

                        MessageBox.Show("Veriler başarıyla veritabanına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                Info info = new Info();
                con.ConnectionString = info.ConnectionString;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        cmd.CommandText = "SELECT * FROM NewBook WHERE bName LIKE @BookName";
                        cmd.Parameters.AddWithValue("@BookName", txtName.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Eğer arama kutusu boşsa, tüm kitapları göster
                        cmd.CommandText = "SELECT * FROM NewBook";

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
        }
    }
}
