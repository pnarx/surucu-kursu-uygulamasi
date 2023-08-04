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
    public partial class NotBilgisi : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";

        public NotBilgisi()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dGVNotBilgisi_CellEnter(object sender, DataGridViewCellEventArgs e)

        {

            txtTCKimlikNo.Text = dGVNotBilgisi.CurrentRow.Cells[1].Value.ToString();
            dtpsınavTarih.Text = dGVNotBilgisi.CurrentRow.Cells[2].Value.ToString();
            txtMotorSınavNotu.Text= dGVNotBilgisi.CurrentRow.Cells[3].Value.ToString();
           txtTrafikfSınavNotu.Text = dGVNotBilgisi.CurrentRow.Cells[4].Value.ToString();
           txtİlkYardımSınavNotu.Text = dGVNotBilgisi.CurrentRow.Cells[5].Value.ToString();



        }

        private void grpKursiyerNotGirsi_Enter(object sender, EventArgs e)
        {

        }
        void notgrid()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM notbilgisi", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);


           dGVNotBilgisi.DataSource = tablo;



            con.Close();

        }
        private void NotBilgisi_Load(object sender, EventArgs e)
        {
         

            notgrid();
        }

        private void txtTCKimlikNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);

            string sql = "DELETE FROM notbilgisi where tc= '" + txtTCKimlikNo.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("NOT BİLGİLERİ SİLİNDİ..");
            con.Close();


            notgrid();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);
            string sql = "UPDATE notbilgisi SET tnot='" + txtTrafikfSınavNotu.Text + "' ,mnot='" + txtMotorSınavNotu.Text + "'where tc ='" + txtTCKimlikNo.Text + "'";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("NOT BİLGİLERİ GÜNCELLENDİ ..");
            con.Close();


            notgrid();
        }
    }
}
