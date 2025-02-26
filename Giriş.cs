using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace VTYS_proje
{
    public partial class Giriþ : Form
    {
        public Giriþ()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Parola")
            {
                txtPassword.Clear();
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Kullanýcý Adý")
            {
                txtUsername.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-M2P8015\\SQLEXPRESS; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Panel panel = new Panel();
                panel.Show();
            }
            else
            {
                MessageBox.Show("Yanlýþ Kullanýcý Adý Veya Parola", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Kaydol kaydol = new Kaydol();
            kaydol.Show();
        }

        private void Giriþ_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }

        private void btnstudentlogin_Click(object sender, EventArgs e)
        {
            ÖðrenciGiriþ öðrenciGiriþ = new ÖðrenciGiriþ();
            öðrenciGiriþ.Show();
        }
    }
}