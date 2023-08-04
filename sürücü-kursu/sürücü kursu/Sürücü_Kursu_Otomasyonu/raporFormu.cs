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
using CrystalDecisions.CrystalReports.Engine;

namespace Sürücü_Kursu_Otomasyonu
{
    public partial class raporFormu : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public raporFormu()
        {
            InitializeComponent();
        }

        private void raporFormu_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Kursiyer_Kaydı";
            con = new SqlConnection(Veritabani.baglan);
            
            con.Open();

            cmd = new SqlCommand(sorgu, con);
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();

            da.Fill(ds);
            
            raporSürücüKursu1.SetDataSource(ds.Tables["Kursiyer_Kaydı"]);
            crystalReportViewer1.ReportSource = raporSürücüKursu1;
            crystalReportViewer1.RefreshReport();
            con.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
        }
    }
}
