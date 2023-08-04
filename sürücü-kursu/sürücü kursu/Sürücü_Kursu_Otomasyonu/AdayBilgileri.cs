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
    public partial class AdayBilgileri : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";


        public AdayBilgileri()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void kursiyergetir()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM  Kursiyer_Kaydı", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dGVAdayBilgileri.DataSource = tablo;



            con.Close();
        }
        private void AdayBilgileri_Load(object sender, EventArgs e)
        {
            kursiyergetir();

        }

        private void dGVAdayBilgileri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dGVAdayBilgileri.CurrentRow.Cells[0].Value.ToString();
            txtTCKimlik.Text = dGVAdayBilgileri.CurrentRow.Cells[1].Value.ToString();
            txtAdı.Text = dGVAdayBilgileri.CurrentRow.Cells[2].Value.ToString();
            txtSoyadı.Text = dGVAdayBilgileri.CurrentRow.Cells[3].Value.ToString();
            cmbKulArac.Text = dGVAdayBilgileri.CurrentRow.Cells[4].Value.ToString();
            txtYas.Text = dGVAdayBilgileri.CurrentRow.Cells[5].Value.ToString();
            cmbOgrenimDurumu.Text = dGVAdayBilgileri.CurrentRow.Cells[6].Value.ToString();
           txtTel.Text = dGVAdayBilgileri.CurrentRow.Cells[7].Value.ToString();
            cmbRapor.Text = dGVAdayBilgileri.CurrentRow.Cells[8].Value.ToString();
           cmbBelge.Text = dGVAdayBilgileri.CurrentRow.Cells[9].Value.ToString();
            dateTimePicker1.Text = dGVAdayBilgileri.CurrentRow.Cells[10].Value.ToString();
            cmbSınıfAdı.Text = dGVAdayBilgileri.CurrentRow.Cells[11].Value.ToString();
            cmbEhliyetSınıfı.Text = dGVAdayBilgileri.CurrentRow.Cells[12].Value.ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(baglan);

            string sql2 = "DELETE FROM Kursiyer_Kaydı where aday_id = '" + txtId.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
            con.Close();
            Veritabani.GridDoldur(dGVAdayBilgileri, "select * from Kursiyer_Kaydı");
            MessageBox.Show(" KURSİYER SİLME İŞLEMİ YAPILDI .");


            kursiyergetir();
   
             


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            con = new SqlConnection(baglan);
            string sql = "UPDATE Kursiyer_Kaydı SET tc_kimlik ='" + txtTCKimlik.Text+ "'where aday_id ='" + txtId.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            Veritabani.GridDoldur(dGVAdayBilgileri, "select * from Kursiyer_Kaydı");
            MessageBox.Show(" KURSİYER GÜNCELLEME İŞLEMİ YAPILDI .");


            kursiyergetir();
        }
    }
}
