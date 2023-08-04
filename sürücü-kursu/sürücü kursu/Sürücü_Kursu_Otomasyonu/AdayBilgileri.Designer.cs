
namespace Sürücü_Kursu_Otomasyonu
{
    partial class AdayBilgileri
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
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dGVAdayBilgileri = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cmbRapor = new System.Windows.Forms.ComboBox();
            this.cmbBelge = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbEhliyetSınıfı = new System.Windows.Forms.ComboBox();
            this.cmbSınıfAdı = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbKulArac = new System.Windows.Forms.ComboBox();
            this.cmbOgrenimDurumu = new System.Windows.Forms.ComboBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAdayBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(12, 545);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(107, 36);
            this.btnGüncelle.TabIndex = 110;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dGVAdayBilgileri
            // 
            this.dGVAdayBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAdayBilgileri.Location = new System.Drawing.Point(12, 12);
            this.dGVAdayBilgileri.Name = "dGVAdayBilgileri";
            this.dGVAdayBilgileri.RowHeadersWidth = 51;
            this.dGVAdayBilgileri.RowTemplate.Height = 24;
            this.dGVAdayBilgileri.Size = new System.Drawing.Size(1023, 179);
            this.dGVAdayBilgileri.TabIndex = 112;
            this.dGVAdayBilgileri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAdayBilgileri_CellEnter);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(140, 545);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 36);
            this.btnSil.TabIndex = 114;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(884, 529);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(107, 36);
            this.btnCikis.TabIndex = 116;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(155, 457);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(145, 22);
            this.txtTel.TabIndex = 149;
            // 
            // cmbRapor
            // 
            this.cmbRapor.FormattingEnabled = true;
            this.cmbRapor.Items.AddRange(new object[] {
            "VAR",
            "YOK"});
            this.cmbRapor.Location = new System.Drawing.Point(155, 492);
            this.cmbRapor.Name = "cmbRapor";
            this.cmbRapor.Size = new System.Drawing.Size(145, 24);
            this.cmbRapor.TabIndex = 148;
            // 
            // cmbBelge
            // 
            this.cmbBelge.FormattingEnabled = true;
            this.cmbBelge.Items.AddRange(new object[] {
            "VAR",
            "YOK"});
            this.cmbBelge.Location = new System.Drawing.Point(457, 224);
            this.cmbBelge.Name = "cmbBelge";
            this.cmbBelge.Size = new System.Drawing.Size(145, 24);
            this.cmbBelge.TabIndex = 147;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(155, 222);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 22);
            this.txtId.TabIndex = 146;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 17);
            this.label19.TabIndex = 145;
            this.label19.Text = "ID :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(481, 440);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 144;
            this.label18.Text = "1";
            // 
            // cmbEhliyetSınıfı
            // 
            this.cmbEhliyetSınıfı.FormattingEnabled = true;
            this.cmbEhliyetSınıfı.Items.AddRange(new object[] {
            "M",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F"});
            this.cmbEhliyetSınıfı.Location = new System.Drawing.Point(461, 368);
            this.cmbEhliyetSınıfı.Name = "cmbEhliyetSınıfı";
            this.cmbEhliyetSınıfı.Size = new System.Drawing.Size(145, 24);
            this.cmbEhliyetSınıfı.TabIndex = 143;
            // 
            // cmbSınıfAdı
            // 
            this.cmbSınıfAdı.FormattingEnabled = true;
            this.cmbSınıfAdı.Items.AddRange(new object[] {
            "2022/1 SABAH",
            "2022/1 AKŞAM",
            "2022/2 SABAH",
            "2022/2 AKŞAM"});
            this.cmbSınıfAdı.Location = new System.Drawing.Point(461, 340);
            this.cmbSınıfAdı.Name = "cmbSınıfAdı";
            this.cmbSınıfAdı.Size = new System.Drawing.Size(145, 24);
            this.cmbSınıfAdı.TabIndex = 142;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 141;
            // 
            // cmbKulArac
            // 
            this.cmbKulArac.FormattingEnabled = true;
            this.cmbKulArac.Items.AddRange(new object[] {
            "M",
            "N",
            "G",
            "O"});
            this.cmbKulArac.Location = new System.Drawing.Point(155, 350);
            this.cmbKulArac.Name = "cmbKulArac";
            this.cmbKulArac.Size = new System.Drawing.Size(145, 24);
            this.cmbKulArac.TabIndex = 140;
            // 
            // cmbOgrenimDurumu
            // 
            this.cmbOgrenimDurumu.FormattingEnabled = true;
            this.cmbOgrenimDurumu.Items.AddRange(new object[] {
            "İLKÖĞRETİM",
            "ORTAOKUL",
            "LİSE",
            "LİSANS",
            "ÖNLİSANS",
            "YÜKSEKLİSANS",
            "DOKTORA"});
            this.cmbOgrenimDurumu.Location = new System.Drawing.Point(155, 411);
            this.cmbOgrenimDurumu.Name = "cmbOgrenimDurumu";
            this.cmbOgrenimDurumu.Size = new System.Drawing.Size(145, 24);
            this.cmbOgrenimDurumu.TabIndex = 139;
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(155, 290);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(145, 22);
            this.txtAdı.TabIndex = 138;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(155, 322);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(145, 22);
            this.txtSoyadı.TabIndex = 137;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(155, 384);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(145, 22);
            this.txtYas.TabIndex = 136;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(155, 259);
            this.txtTCKimlik.MaxLength = 11;
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(145, 22);
            this.txtTCKimlik.TabIndex = 135;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 132;
            this.label16.Text = "20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(363, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 131;
            this.label15.Text = "Sınıf Mevcudu :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(363, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 17);
            this.label14.TabIndex = 130;
            this.label14.Text = "Sınıf Kapasitesi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 129;
            this.label13.Text = "Ehliyet Sınıfı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 128;
            this.label12.Text = "Sınıf Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 127;
            this.label11.Text = "Kayıt Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(363, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 126;
            this.label10.Text = "Sınıf Bilgileri ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 125;
            this.label9.Text = "Öğrenim Durumu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 124;
            this.label8.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 123;
            this.label7.Text = " Sağlık Raporu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 122;
            this.label6.Text = "Adli Belge :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 121;
            this.label5.Text = "Yaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 120;
            this.label4.Text = "Araç Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = "Adı:";
            // 
            // AdayBilgileri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1035, 593);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cmbRapor);
            this.Controls.Add(this.cmbBelge);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbEhliyetSınıfı);
            this.Controls.Add(this.cmbSınıfAdı);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbKulArac);
            this.Controls.Add(this.cmbOgrenimDurumu);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dGVAdayBilgileri);
            this.Controls.Add(this.btnGüncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdayBilgileri";
            this.Text = "AdayBilgileri";
            this.Load += new System.EventHandler(this.AdayBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAdayBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.DataGridView dGVAdayBilgileri;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.ComboBox cmbRapor;
        public System.Windows.Forms.ComboBox cmbBelge;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cmbEhliyetSınıfı;
        public System.Windows.Forms.ComboBox cmbSınıfAdı;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cmbKulArac;
        public System.Windows.Forms.ComboBox cmbOgrenimDurumu;
        public System.Windows.Forms.TextBox txtAdı;
        public System.Windows.Forms.TextBox txtSoyadı;
        public System.Windows.Forms.TextBox txtYas;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}