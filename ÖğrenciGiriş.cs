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
    public partial class ÖğrenciGiriş : Form
    {
        public ÖğrenciGiriş()
        {
            InitializeComponent();
        }


        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Kullanıcı Adı")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Parola")
            {
                txtPassword.Clear();
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where enroll = '" + txtUsername.Text + "' and spass = '" + txtPassword.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                ÖğrenciPanel öğrenciPanel = new ÖğrenciPanel();
                öğrenciPanel.ogrencinoo = txtUsername.Text;
                öğrenciPanel.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı Veya Parola", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {
            ÖğrenciKaydol öğrenciKaydol = new ÖğrenciKaydol();
            öğrenciKaydol.Show();

        }

        private void ÖğrenciGiriş_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }


}

