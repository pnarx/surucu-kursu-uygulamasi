using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Sürücü_Kursu_Otomasyonu
{
    class Veritabani
    {
        Veritabani()
        {


        }
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static System.Data.DataSet ds;

        public static string baglan = @"Data Source=LAPTOP-GFUIOMKC\SQLEXPRESS;Initial Catalog=Sürücü_Kursu_Otomasyonu;Integrated Security=True";

        public static bool BaglantiDurum()
        {
            // veritanai baglantısı kontrolü
            using (con = new SqlConnection(baglan))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;


                }
            }
        }
        public static void komutyolla(string sql)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

      public  static DataGridView GridDoldur(DataGridView gridim, string SelectSorgu)
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter(SelectSorgu, con);
            ds = new System.Data.DataSet();
            con.Open();
            da.Fill(ds, SelectSorgu);

            gridim.DataSource = ds.Tables[SelectSorgu];
            con.Close();
            return gridim;

        }

        public static string MD5Sifrele(string sifrelenecekmetin)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);

            // dizinin hash değeri çıkarılıyor

            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();



        }
        
    }
}
