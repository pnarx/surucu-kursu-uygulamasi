using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sürücü_Kursu_Otomasyonu
{
    public partial class kisiselBilgiler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";



        public kisiselBilgiler()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void kisiselBilgiler_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtTCKimlik.Text = "";
            txtAdı.Text = "";
            txtSoyadı.Text = "";
        }
        void kbilgilerigetir()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM kisiselbilgiler", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            NüfusBilgileri kisisel = new NüfusBilgileri();
            kisisel.dGVNüfusBilgileri.DataSource = tablo;



            con.Close();
        }
        private void btnBilgileriKaydet_Click(object sender, EventArgs e)
        {
            if (txtAnneAdi.Text == "" || txtBabaAdı.Text == "")
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz");

            }
            else
            {
                con = new SqlConnection(baglan);
                string sql = "insert into kisiselbilgiler(tc,ad,soyad,babaAd,anneAd,cinsiyet,dtarih,uyruk,kangrup) values('" + txtTCKimlik.Text + "','" + txtAdı.Text + "','" + txtSoyadı.Text + "','" + txtBabaAdı.Text + "','" + txtAnneAdi.Text + "','" + cmbCinsiyet.Text + "','" + dtpDogumTarihi.Value.ToString("yyy-MM-dd HH:mm:ss") + "','" + txtUyruk.Text + "','" + cmbKan.Text + "')";


                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("KİŞİSEL BİLGİLER KAYDOLDU..");
                con.Close();


                kbilgilerigetir();


               
            }

        }

        private void txtTCKimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
