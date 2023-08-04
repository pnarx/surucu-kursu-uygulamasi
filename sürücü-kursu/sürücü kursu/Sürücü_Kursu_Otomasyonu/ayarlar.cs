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


namespace Sürücü_Kursu_Otomasyonu
{
   
    public partial class ayarlar : Form
    {
       static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
       static DataSet ds;
        static SqlDataReader dr;

       public static string  baglan =  @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";
        public ayarlar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            label_mesaj.Text = kullanicigiris.kullanicimSession;

        }

        private void btnCıikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSifreDegiştir_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                EskiSifreKontrol();
            }
            else
            {
                label_mesaj.Text = " yeni şifre ve tekrarı aynı değil ... ";
                label_mesaj.Text = kullanicigiris.kullanicimSession;
            }


        }
        public  void EskiSifreKontrol()
        {

            string sorgu = "select sifre from tbl_login where kullanici='" + kullanicigiris.kullanicimSession+"'and sifre ='"+Veritabani.MD5Sifrele(txtMevcutSifre.Text)+"'";

            con = new SqlConnection(baglan);
  
            cmd = new SqlCommand(sorgu, con);
      

            con.Open();
            dr = cmd.ExecuteReader();

            //eğerverigelgidyse

            if (dr.Read())
            {
                //eski şifre doğruysa yapışacaktır
                string sql = "update tbl_login set sifre ='" + Veritabani.MD5Sifrele(txtYeniSifre.Text) + "'";

                MessageBox.Show("şifreniz güncellendi..");
                Veritabani.komutyolla(sql);
            }
            else
            {
                label_mesaj.Text = "Eski şifreniz hatalı ..";

            }
            con.Close();

           
        }

        private void label_mesaj_Click(object sender, EventArgs e)
        {

        }
    }
}
