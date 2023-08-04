
namespace Sürücü_Kursu_Otomasyonu
{
    partial class OdemeGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.btnBilgileriKaydet = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.txtKalanBorç = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTaksitSayısı = new System.Windows.Forms.ComboBox();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOdemeTutarı = new System.Windows.Forms.TextBox();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCekimTipi = new System.Windows.Forms.ComboBox();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(92, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ödeme Bilgilerini Giriniz";
            // 
            // btnBilgileriKaydet
            // 
            this.btnBilgileriKaydet.Location = new System.Drawing.Point(615, 344);
            this.btnBilgileriKaydet.Name = "btnBilgileriKaydet";
            this.btnBilgileriKaydet.Size = new System.Drawing.Size(125, 36);
            this.btnBilgileriKaydet.TabIndex = 92;
            this.btnBilgileriKaydet.Text = "Bilgileri Kaydet";
            this.btnBilgileriKaydet.UseVisualStyleBackColor = true;
            this.btnBilgileriKaydet.Click += new System.EventHandler(this.btnBilgileriKaydet_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Enabled = false;
            this.btnYeniKayit.Location = new System.Drawing.Point(487, 344);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(107, 36);
            this.btnYeniKayit.TabIndex = 91;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // txtKalanBorç
            // 
            this.txtKalanBorç.Location = new System.Drawing.Point(220, 240);
            this.txtKalanBorç.Name = "txtKalanBorç";
            this.txtKalanBorç.Size = new System.Drawing.Size(200, 22);
            this.txtKalanBorç.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 192;
            this.label3.Text = "Kalan Borç :";
            // 
            // cmbTaksitSayısı
            // 
            this.cmbTaksitSayısı.Enabled = false;
            this.cmbTaksitSayısı.FormattingEnabled = true;
            this.cmbTaksitSayısı.Items.AddRange(new object[] {
            "3",
            "5",
            "6",
            "9"});
            this.cmbTaksitSayısı.Location = new System.Drawing.Point(220, 343);
            this.cmbTaksitSayısı.Name = "cmbTaksitSayısı";
            this.cmbTaksitSayısı.Size = new System.Drawing.Size(200, 24);
            this.cmbTaksitSayısı.TabIndex = 189;
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(220, 155);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpOdemeTarihi.TabIndex = 188;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(220, 118);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(200, 22);
            this.txtTCKimlik.TabIndex = 187;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(92, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 186;
            this.label7.Text = "Taksit Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(98, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 185;
            this.label6.Text = "Çekim Tipi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 184;
            this.label5.Text = "Ödeme Şekli :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 183;
            this.label1.Text = "Ödenen Tutarı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 181;
            this.label10.Text = "Ödeme Tarihi :";
            // 
            // txtOdemeTutarı
            // 
            this.txtOdemeTutarı.Location = new System.Drawing.Point(220, 211);
            this.txtOdemeTutarı.Name = "txtOdemeTutarı";
            this.txtOdemeTutarı.Size = new System.Drawing.Size(200, 22);
            this.txtOdemeTutarı.TabIndex = 180;
            // 
            // txtOdenen
            // 
            this.txtOdenen.Location = new System.Drawing.Point(220, 183);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(200, 22);
            this.txtOdenen.TabIndex = 179;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 178;
            this.label11.Text = "TC Kimlik No :";
            // 
            // cmbCekimTipi
            // 
            this.cmbCekimTipi.Enabled = false;
            this.cmbCekimTipi.FormattingEnabled = true;
            this.cmbCekimTipi.Items.AddRange(new object[] {
            "Tek Çekim",
            "Taksitli Çekim"});
            this.cmbCekimTipi.Location = new System.Drawing.Point(220, 313);
            this.cmbCekimTipi.Name = "cmbCekimTipi";
            this.cmbCekimTipi.Size = new System.Drawing.Size(200, 24);
            this.cmbCekimTipi.TabIndex = 194;
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "Nakit ",
            "Kredi Kartı"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(220, 277);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(200, 24);
            this.cmbOdemeSekli.TabIndex = 195;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 196;
            this.label2.Text = "Ödeme Tutarı :";
            // 
            // OdemeGirisi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1330, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.cmbCekimTipi);
            this.Controls.Add(this.txtKalanBorç);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTaksitSayısı);
            this.Controls.Add(this.dtpOdemeTarihi);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOdemeTutarı);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBilgileriKaydet);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OdemeGirisi";
            this.Text = "Odeme Girisi";
            this.Load += new System.EventHandler(this.OdemeGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnBilgileriKaydet;
        public System.Windows.Forms.Button btnYeniKayit;
        public System.Windows.Forms.TextBox txtKalanBorç;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbTaksitSayısı;
        public System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtOdemeTutarı;
        public System.Windows.Forms.TextBox txtOdenen;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmbCekimTipi;
        public System.Windows.Forms.ComboBox cmbOdemeSekli;
        public System.Windows.Forms.Label label2;
    }
}