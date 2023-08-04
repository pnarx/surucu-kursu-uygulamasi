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
    public partial class KursiyerArama : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";

        public KursiyerArama()
        {
            InitializeComponent();
        }
  
        /*
       void griddoldur(string sql )
        {

            con = new SqlConnection(baglan);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();

            da.Fill(ds, "Kursiyer_Kaydı");

            Form1 f = new Form1();
            f.dGVKursiyerKayit.DataSource = ds.Tables["Kursiyer_Kaydı"];
            con.Close();
       
           

        }
        */
        
        
        private void btnSorgula_Click(object sender, EventArgs e)
        {  
            /*
            if (textBox1.Text != "")
            {
                
                if (rdTCKimlik.Checked == true)
                {
                    Form1 a = new Form1();
                    baglan = " select * from Kursiyer_Kaydı  where tc_kimlik Like '% " + textBox1.Text + "' ";
                    Veritabani.GridDoldur(a.dGVKursiyerKayit, baglan);
                    MessageBox.Show("KAYITLI KULLANICI");

                    
                }
                else if (rdİsmeGöre.Checked == true)
                {
                    Form1 a = new Form1();
                    baglan = " select * from Kursiyer_Kaydı  where ad Like '%" + textBox1.Text + "' ";
                    Veritabani.GridDoldur(a.dGVKursiyerKayit, baglan);
                    MessageBox.Show("KAYITLI KULLANICI");

                    
                }
          
            }
            */

        }
      
        
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          /*  
            Form1 a = new Form1();
            String sorgu = "select * from Kursiyer_Kaydı";
            Veritabani.GridDoldur(a.dGVKursiyerKayit, sorgu);
            baglan = " select * from Kursiyer_Kaydı  where tc_kimlik Like '% " + textBox1.Text + "' ";
            Veritabani.GridDoldur(a.dGVKursiyerKayit, baglan);
           //MessageBox.Show("KAYITLI KULLANICI");

*/
        }

        private void rdİsmeGöre_CheckedChanged(object sender, EventArgs e)
        {
            
        }
       
        private void KursiyerArama_Load(object sender, EventArgs e)
        {
          
        }

     
        
    }
}
