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
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtUsername.Text != "" && txtPass.Text != "")
            {



                string Uname = txtName.Text;
                string USurname = txtSurname.Text;
                string Username = txtUsername.Text;
                string password = txtPass.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into LoginTable (username,pass,name,surname) values ('" + Username + "','" + password + "','" + Uname + "','" + USurname + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgiler Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtSurname.Clear();
                txtUsername.Clear();
                txtPass.Clear();

            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
