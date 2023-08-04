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
    public partial class Form1 : Form
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataSet ds;
        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";
        public Form1()
        {
            
            InitializeComponent();
            if (Veritabani.BaglantiDurum())
            {
                //MessageBox.Show("veri tabani bağlantısı gerçekleşti");
            }
        }

        public static string gidenbilgi = "";
        

       
        private void  formGetir(Form frm)
        {
           
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            

            frm.Show();
          
        }

        private void formuGetir(Form frm)
        {
       

            panel5.Controls.Clear();
            panel2.Visible = true;
            panel1.Visible = true;
         
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.Fixed3D;
            panel5.Controls.Add(frm);
            panel5.BackColor = Color.White;
            panel5.Visible = true;
            frm.Show();
            
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Veritabani.GridDoldur(dGVKursiyerKayit,"select*from kursiyer_kaydı");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kursiyerKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        void kursiyergetir()
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter("SELECT * FROM  Kursiyer_Kaydı", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

          
            dGVKursiyerKayit.DataSource = tablo;

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            
            kursiyerKayit kayitt = new kursiyerKayit();

            if (dGVKursiyerKayit.CurrentCell != null)
            {
                kayitt.txtId.Text = dGVKursiyerKayit.CurrentRow.Cells[0].Value.ToString();
                kayitt.txtTCKimlik.Text = dGVKursiyerKayit.CurrentRow.Cells[1].Value.ToString();
                kayitt.txtAdı.Text = dGVKursiyerKayit.CurrentRow.Cells[2].Value.ToString();
                kayitt.txtSoyadı.Text = dGVKursiyerKayit.CurrentRow.Cells[3].Value.ToString();
                kayitt.cmbKulArac.Text = dGVKursiyerKayit.CurrentRow.Cells[4].Value.ToString();
                kayitt.txtYas.Text = dGVKursiyerKayit.CurrentRow.Cells[5].Value.ToString();
                kayitt.cmbOgrenimDurumu.Text = dGVKursiyerKayit.CurrentRow.Cells[6].Value.ToString();
                kayitt.txtTel.Text = dGVKursiyerKayit.CurrentRow.Cells[7].Value.ToString();
                kayitt.cmbRapor.Text = dGVKursiyerKayit.CurrentRow.Cells[8].Value.ToString();
                kayitt.cmbBelge.Text = dGVKursiyerKayit.CurrentRow.Cells[9].Value.ToString();
                kayitt.dateTimePicker1.Text = dGVKursiyerKayit.CurrentRow.Cells[10].Value.ToString();
                kayitt.cmbSınıfAdı.Text = dGVKursiyerKayit.CurrentRow.Cells[11].Value.ToString();
                kayitt.cmbEhliyetSınıfı.Text = dGVKursiyerKayit.CurrentRow.Cells[12].Value.ToString();
            }
   
      

            formGetir(kayitt);

            kursiyergetir();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            kisiselBilgiler kişiselb = new kisiselBilgiler();
            kişiselb.txtId.Text = dGVKursiyerKayit.CurrentRow.Cells[0].Value.ToString();
            kişiselb.txtTCKimlik.Text = dGVKursiyerKayit.CurrentRow.Cells[1].Value.ToString();
            kişiselb.txtAdı.Text = dGVKursiyerKayit.CurrentRow.Cells[2].Value.ToString();
            kişiselb.txtSoyadı.Text = dGVKursiyerKayit.CurrentRow.Cells[3].Value.ToString();
            formGetir(kişiselb);
        }

        private void btnOdemeGirisi_Click(object sender, EventArgs e)
        {
            

            OdemeGirisi odemeg = new OdemeGirisi();
            odemeg.txtTCKimlik.Text = dGVKursiyerKayit.CurrentRow.Cells[1].Value.ToString();

            formGetir(odemeg);



        }

        private void btnNotGirisi_Click(object sender, EventArgs e)
        {

            NotGirisi not = new NotGirisi();
            not.txtTCKimlik.Text = dGVKursiyerKayit.CurrentRow.Cells[1].Value.ToString();

            formGetir(not);

        }

        private void btnPersonelBK_Click(object sender, EventArgs e)
        {
            personelBilgiveKayit Kayit = new personelBilgiveKayit();
            formGetir(Kayit);
            Kayit.BackColor = Color.Beige;
        }

        private void btnKursiyerArama_Click(object sender, EventArgs e)
        {
            KursiyerArama arama = new KursiyerArama();
            formGetir(arama);
            arama.BackColor = Color.Beige;
  
           
            
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            formGetir(ayarlar);  
            ayarlar.BackColor = Color.Beige;
            
        
         
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            Ödemeler odemeler = new Ödemeler();
            odemeler.BackColor = Color.Beige;
            odemeler.Show();
        }

        private void btnAdayBilgileri_Click(object sender, EventArgs e)
        {
            AdayBilgileri aday = new AdayBilgileri();
            aday.BackColor = Color.Beige;
            aday.Show();
        }

        private void btnNüfusBilgileri_Click(object sender, EventArgs e)
        {
            NüfusBilgileri nüfusB = new NüfusBilgileri();
            nüfusB.BackColor = Color.Beige;
            nüfusB.Show();
        }

        private void btnNotBilgisi_Click(object sender, EventArgs e)
        {
            NotBilgisi notbilgisi = new NotBilgisi();

 ;

            notbilgisi.Show();
            notbilgisi.BackColor = Color.Beige;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelBilgisi_Click(object sender, EventArgs e)
        {
            personelBilgisi personelBilgisi = new personelBilgisi();
            personelBilgisi.Show();
            personelBilgisi.BackColor = Color.Beige;
        }
        private void DataGridView1_CellContentClick_1(object sender , EventArgs e)
        {

        }

        private void dGVKursiyerKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kursiyerKayit kursiyerKayit = new kursiyerKayit();
            kursiyerKayit.Show();
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void dGVKursiyerKayit_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            kursiyerKayit kayit = new kursiyerKayit();

            dGVKursiyerKayit.AllowUserToAddRows = false;
            dGVKursiyerKayit.AllowUserToDeleteRows = false;
            dGVKursiyerKayit.ReadOnly = true;
           
        }

        private void dGVKursiyerKayit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

  
            
       


        }

          public int i;
        private void dGVKursiyerKayit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            i = e.RowIndex;
            AdayBilgileri a = new AdayBilgileri();
            a.txtAdı.Text = dGVKursiyerKayit.Rows[i].Cells[1].Value.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from Kursiyer_Kaydı";
            Veritabani.GridDoldur(dGVKursiyerKayit, sorgu);
            Veritabani.GridDoldur(dGVKursiyerKayit, "select * from Kursiyer_Kaydı where tc_kimlik like '%" + textBox1.Text+"' or ad like'%"+textBox1.Text+"'");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            raporFormu a = new raporFormu();
            this.Hide();
            a.ShowDialog();
        }
    }
}

 