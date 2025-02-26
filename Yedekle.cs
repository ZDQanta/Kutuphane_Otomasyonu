using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYS_proje
{
    public partial class Yedekle : Form
    {
        public Yedekle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server = DESKTOP-M2P8015\\SQLEXPRESS;integrated Security = true");

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            checkedListBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select * from Sysdatabases order by name", conn);
            SqlDataReader myreader = cmd.ExecuteReader();
            while (myreader.Read())
                checkedListBox1.Items.Add(myreader[0]);
            conn.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int item = 0; item <= checkedListBox1.Items.Count - 1; item++)
                    checkedListBox1.SetItemChecked(item, true);
            }
            else
            {
                for (int item = 0; item <= checkedListBox1.Items.Count - 1; item++)
                    checkedListBox1.SetItemChecked(item, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                if (textBox1.Text != "")
                {
                    foreach (object databasecheck in checkedListBox1.CheckedItems)
                    {
                        string lfolder;
                        lfolder = textBox1.Text + @"\" + databasecheck.ToString() + ".mdf";
                        string strsql = "Backup Database " + databasecheck.ToString() + " To Disk='" + lfolder + "'";
                        SqlCommand cmd2 = new SqlCommand(strsql, conn);
                        conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("Veri Tabanı Başarıyla Yedeklendi.");
                }
                else
                {
                    MessageBox.Show("Lütfen Yedeklemek İstediğiniz Yeri Seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Yedeklemek İstediğiniz Veri Tabanını Seçiniz.");
            }
        }
    }
}
