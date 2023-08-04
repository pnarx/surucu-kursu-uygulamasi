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
    public partial class OdemeGirisi : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";

        public OdemeGirisi()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OdemeGirisi_Load(object sender, EventArgs e)
        {
            if (cmbOdemeSekli.Text == "Kredi Kartı")
            {
                label6.Enabled = true;
                cmbTaksitSayısı.Enabled = true;
                cmbCekimTipi.Enabled = true;
                label7.Enabled = true;
                cmbTaksitSayısı.Enabled = true;

            }
            if (cmbOdemeSekli.Text == "Nakit")
            {
                label6.Enabled = false;
                cmbCekimTipi.Enabled = false;
                cmbOdemeSekli.Enabled = false;
                label7.Enabled = false;
                cmbTaksitSayısı.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtTCKimlik.Text = "";
        }

        private void rdKrediKartı_CheckedChanged(object sender, EventArgs e)
        {
            
        
  
        }

        private void txtTCKimlik_TextChanged(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            txtTCKimlik.Text = frm.dGVKursiyerKayit.CurrentRow.Cells[1].Value.ToString();
        }

        void odemegrid()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM odeme", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            Ödemeler odeme = new Ödemeler();
            odeme.dGVOdemeler.DataSource = tablo;



            con.Close();
        }
        private void btnBilgileriKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);
            string sql = "insert into  odeme (tc,otarih,topborc,otutar,kborc,osekli,ocekim,tsayısı) values('"+txtTCKimlik.Text+"','" + dtpOdemeTarihi.Value.ToString("yyy-MM-dd HH:mm:ss") + "','" + txtOdenen.Text+ "','" + txtOdemeTutarı.Text+"','"+txtKalanBorç.Text+"','" +cmbOdemeSekli.Text+"','"+cmbCekimTipi.Text+"','"+cmbTaksitSayısı.Text+"')";

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ödeme Girişi Yapıldı..");
            odemegrid();
        }
    }
}
