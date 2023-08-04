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
using System.Data;
using System.Data.SqlClient;


namespace Sürücü_Kursu_Otomasyonu
{
   
    public partial class personelBilgisi : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";





        public personelBilgisi()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        void personelgetir()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM personelbilgisi", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);


            dGVPersonelBilgi.DataSource = tablo;



            con.Close();

        }
            private void personelBilgisi_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(baglan);
            string sql = "insert into personelbilgisi(tc,adı,soyadı,telefon,adres,eposta,görevi) values('" + txtTCKimlikNo.Text + "','" + txtAdı.Text + "','" + txtSoyadi.Text + "','" + txtTel.Text + "','" + txtAdres.Text + "','" + txtEposta.Text + "','" + txtGörevi.Text + "')";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();


            personelgetir();

        }

        private void dGVPersonelBilgi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dGVPersonelBilgi.CurrentRow.Cells[0].Value.ToString();
            txtTCKimlikNo.Text = dGVPersonelBilgi.CurrentRow.Cells[1].Value.ToString();
            txtAdı.Text = dGVPersonelBilgi.CurrentRow.Cells[2].Value.ToString();
            txtSoyadi.Text = dGVPersonelBilgi.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dGVPersonelBilgi.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dGVPersonelBilgi.CurrentRow.Cells[5].Value.ToString();
            txtEposta.Text = dGVPersonelBilgi.CurrentRow.Cells[6].Value.ToString();

            txtGörevi.Text = dGVPersonelBilgi.CurrentRow.Cells[7].Value.ToString();
        }

        private void dGVPersonelBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(baglan);

            string sql2 = "DELETE FROM personelbilgisi where ID= "+txtid.Text+"";

           
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
            con.Close();


            personelgetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);
            string sql = "UPDATE personelbilgisi SET tc='" + txtTCKimlikNo.Text + "'where eposta ='" + txtEposta.Text +  "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();


            personelgetir();
        }
    }
}
