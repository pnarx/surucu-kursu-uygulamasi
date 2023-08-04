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
    public partial class NüfusBilgileri : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";

        public NüfusBilgileri()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NüfusBilgileri_Load(object sender, EventArgs e)
        {
            Veritabani.GridDoldur(dGVNüfusBilgileri, "select*from kisiselbilgiler");
        }

        private void dGVNüfusBilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void dGVNüfusBilgileri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dGVNüfusBilgileri.CurrentRow.Cells[0].Value.ToString();
            txtTCKimlik.Text = dGVNüfusBilgileri.CurrentRow.Cells[1].Value.ToString();
            txtAdı.Text = dGVNüfusBilgileri.CurrentRow.Cells[2].Value.ToString();
            txtSoyadı.Text = dGVNüfusBilgileri.CurrentRow.Cells[3].Value.ToString();
            txtBabaAdı.Text = dGVNüfusBilgileri.CurrentRow.Cells[4].Value.ToString();
            txtAnneAdi.Text = dGVNüfusBilgileri.CurrentRow.Cells[5].Value.ToString();
            cmbCinsiyet.Text = dGVNüfusBilgileri.CurrentRow.Cells[6].Value.ToString();
            dtpDogumTarihi.Text= dGVNüfusBilgileri.CurrentRow.Cells[7].Value.ToString();
            txtUyruk.Text = dGVNüfusBilgileri.CurrentRow.Cells[8].Value.ToString();
            cmbKan.Text = dGVNüfusBilgileri.CurrentRow.Cells[9].Value.ToString();

        }
       
        private void btnSil_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(baglan);

            string sql2 = "DELETE FROM kisiselbilgiler where serino= "+txtId.Text+" ";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
          
            con.Close();
            Veritabani.GridDoldur(dGVNüfusBilgileri, "select * from Kursiyer_Kaydı");
            MessageBox.Show("NÜFUS BİLGİLERİ SİLİNDİ..");
              kbilgilerigetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(baglan);
            string sql = "UPDATE  kisiselbilgiler  SET  tc='" +txtTCKimlik.Text + "' , ad='" + txtAdı.Text + "'where kangrup ='" + cmbKan.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            Veritabani.GridDoldur(dGVNüfusBilgileri, "select * from Kursiyer_Kaydı");
            MessageBox.Show("NÜFUS BİLGİLERİ GÜNCELLENDİ..");
            con.Close();


            kbilgilerigetir();
        }
    }
}
