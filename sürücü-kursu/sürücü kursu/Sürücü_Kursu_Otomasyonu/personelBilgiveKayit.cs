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
    public partial class personelBilgiveKayit : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";



        public personelBilgiveKayit()
        {
            InitializeComponent();
        }

        private void personelBilgiveKayit_Load(object sender, EventArgs e)
        {
            Veritabani.GridDoldur(dtGVPersonelBilgiKayit, "select*from personelbilgisi");
        }
        void personelgetir()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM personelbilgisi", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

           
            dtGVPersonelBilgiKayit.DataSource = tablo;



            con.Close();
        }
        private void btnBilgileriKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);
            string sql = "insert into personelbilgisi(tc,adı,soyadı,telefon,adres,eposta,görevi) values('"+txtTCKimlikNo.Text+"','"+txtAdı.Text+"','"+txtSoyadi.Text+"','"+txtTel.Text+"','"+txtAdres.Text+"','"+txtEposta.Text+"','"+txtGörevi.Text+"')";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            personelgetir();


        }

        private void dtGVPersonelBilgiKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtGVPersonelBilgiKayit_CellEnter(object sender, DataGridViewCellEventArgs e)

        {
            txtid.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[0].Value.ToString();
            txtTCKimlikNo.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[1].Value.ToString();
            txtAdı.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[2].Value.ToString();
            txtSoyadi.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[5].Value.ToString();
            txtEposta.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[6].Value.ToString();
           
            txtGörevi.Text = dtGVPersonelBilgiKayit.CurrentRow.Cells[7].Value.ToString();

            
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtTCKimlikNo.Text= "";
            txtAdı.Text = "";
            txtSoyadi.Text = "";
            txtTel.Text = "";
            txtAdres.Text = "";
            txtEposta.Text = "";
            txtGörevi.Text = "";
        

        }
    }
}
