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
using Sürücü_Kursu_Otomasyonu;





namespace Sürücü_Kursu_Otomasyonu
{
    


    public partial class kursiyerKayit : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";

        public kursiyerKayit()
        {
            InitializeComponent();
        }

      

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {

            
            txtId.Text = " ";
            txtTCKimlik.Text = "";
            txtAdı.Text = "";
            txtSoyadı.Text ="";
           cmbKulArac.Text = "";
            txtYas.Text = ""; ;
            cmbOgrenimDurumu.Text = "";
           txtTel.Text ="";
           cmbRapor.Text = "";
           cmbBelge.Text =  "";
           dateTimePicker1.Text = "";
           cmbSınıfAdı.Text = "";
            cmbEhliyetSınıfı.Text = "";


           




        }
      

        void kursiyergetir()
        { 
          
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM  Kursiyer_Kaydı", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            // Form1 kayit = new Form1();

            // kayit.dGVKursiyerKayit.DataSource = tablo;

              AdayBilgileri aday = new AdayBilgileri();
            aday.dGVAdayBilgileri.DataSource = tablo;

            con.Close();
        }
        private void kursiyerKayit_Load(object sender, EventArgs e)
        {
            AdayBilgileri kayit = new AdayBilgileri();
            Veritabani.GridDoldur(kayit.dGVAdayBilgileri, "select*from Kursiyer_Kaydı ");

        }
      
        private void btnBilgileriKaydet_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            con = new SqlConnection(baglan);
            string sql = "insert into Kursiyer_Kaydı(tc_kimlik,ad,soyad,kul_arac,yas,tahsil,telefon,rapor,belge,kayit_tarih,sınıf_ad,ehliyet_sınıfı) VALUES ('" + txtTCKimlik.Text+"','"+txtAdı.Text+"','"+txtSoyadı.Text+"','"+cmbKulArac.Text+"','"+txtYas.Text+"','"+cmbOgrenimDurumu.Text+"','"+txtTel.Text+"','"+cmbRapor.Text+"','"+ cmbBelge.Text+"','"+dateTimePicker1.Value.ToString("yyy-MM-dd HH:mm:ss")+"','"+cmbSınıfAdı.Text+"','"+cmbEhliyetSınıfı.Text+"')";

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            
            

            MessageBox.Show("kursiyer kaydı yapıldı");
           
            con.Close();
             
           
           //  kursiyergetir();
            Veritabani.GridDoldur(FRM.dGVKursiyerKayit, "select * from Kursiyer_Kaydı ");
        } 
    }
}
