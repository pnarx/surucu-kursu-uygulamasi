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
    public partial class NotGirisi : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";


        public NotGirisi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtTCKimlik.Text = "";
        }
        void notgrid()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM notbilgisi", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            NotBilgisi not = new NotBilgisi();

            not.dGVNotBilgisi.DataSource = tablo;



            con.Close();
        }
        private void btnBilgileriKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglan);
            string sql = "insert into notbilgisi(tc,sınavtarihi,tnot,mnot,ilknot) values('" + txtTCKimlik.Text+"','"+ dateTimePicker2.Value.ToString("yyy-MM-dd HH:mm:ss") + "','" + txtTrafikfSınavNotu.Text + "','" +txtMotorSınavNotu.Text + "','" +txtİlkYardımSınavNotu.Text + "')";


            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Not Girişi Yapıldı..");

            notgrid();
        }
    }
}
