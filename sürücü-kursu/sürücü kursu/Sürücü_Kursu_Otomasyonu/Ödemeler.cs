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
    public partial class Ödemeler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";


        public Ödemeler()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtTCKimlikNo_TextChanged(object sender, EventArgs e)
        {

        }
        void odemegrid()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM odeme", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dGVOdemeler.DataSource = tablo;



            con.Close();
        }
        private void Ödemeler_Load(object sender, EventArgs e)
        {
            
         

            odemegrid();
        }

        private void dGVOdemeler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           

            txtTCKimlik.Text=dGVOdemeler.CurrentRow.Cells[1].Value.ToString();
            dtpOdemeTarihi.Text = dGVOdemeler.CurrentRow.Cells[2].Value.ToString();
            txtOdemeTutarı.Text = dGVOdemeler.CurrentRow.Cells[3].Value.ToString();
            txtOdenen.Text = dGVOdemeler.CurrentRow.Cells[4].Value.ToString();
            txtKalanBorç.Text = dGVOdemeler.CurrentRow.Cells[5].Value.ToString();
            cmbOdemeSekli.Text = dGVOdemeler.CurrentRow.Cells[6].Value.ToString();
           cmbTaksitSayısı.Text = dGVOdemeler.CurrentRow.Cells[7].Value.ToString();
            cmbCekimTipi.Text = dGVOdemeler.CurrentRow.Cells[8].Value.ToString();
  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {


            con = new SqlConnection(baglan);

            string sql2 = "DELETE FROM odeme where tc= '" + txtTCKimlik.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
            con.Close();

            odemegrid();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);
            string sql = "UPDATE odeme SET kborc='" + txtKalanBorç.Text + "' , otutar='"+txtOdenen.Text+"'where topborc ='" + txtOdemeTutarı.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();


            odemegrid();
        }
    }
}
