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
using System.Security.Cryptography;

namespace Sürücü_Kursu_Otomasyonu
{
    public partial class kullanicigiris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True");
        public kullanicigiris()
        {
            InitializeComponent();
        }

        public static string kullanicimSession = " ";
        private void kullanicigiris_Load(object sender, EventArgs e)
        {

        }

       


        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != "")
            {
                rchtxtMD5.Text = Veritabani.MD5Sifrele(txtSifre.Text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rchtxtMD5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz");
                txtKullaniciAdi.Focus();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select* from tbl_login where kullanici = @nickname and sifre = @password", baglan);
                cmd.Parameters.AddWithValue("nickname", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("password", Veritabani.MD5Sifrele(txtSifre.Text));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kullanicimSession = txtKullaniciAdi.Text;
                    Form1 anaform = new Form1();
                    anaform.Show();
                    this.Hide();

                }


                else
                {
                    MessageBox.Show(" Hatalı giriş yaptınız !");

                    txtSifre.Clear();
                    txtKullaniciAdi.Clear();
                    txtKullaniciAdi.Focus();

                }
                baglan.Close();
            }
        }

        private void txtSifre_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
