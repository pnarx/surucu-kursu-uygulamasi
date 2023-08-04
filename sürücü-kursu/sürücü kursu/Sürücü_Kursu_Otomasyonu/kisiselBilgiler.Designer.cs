
namespace Sürücü_Kursu_Otomasyonu
{
    partial class kisiselBilgiler
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
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.btnBilgileriKaydet = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBabaAdı = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbKan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(135, 137);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(145, 22);
            this.txtAdı.TabIndex = 90;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(135, 179);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(145, 22);
            this.txtSoyadı.TabIndex = 89;
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Location = new System.Drawing.Point(135, 250);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(145, 22);
            this.txtAnneAdi.TabIndex = 88;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(135, 101);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(145, 22);
            this.txtTCKimlik.TabIndex = 87;
            this.txtTCKimlik.TextChanged += new System.EventHandler(this.txtTCKimlik_TextChanged);
            // 
            // btnBilgileriKaydet
            // 
            this.btnBilgileriKaydet.Location = new System.Drawing.Point(455, 299);
            this.btnBilgileriKaydet.Name = "btnBilgileriKaydet";
            this.btnBilgileriKaydet.Size = new System.Drawing.Size(125, 36);
            this.btnBilgileriKaydet.TabIndex = 86;
            this.btnBilgileriKaydet.Text = "Bilgileri Kaydet";
            this.btnBilgileriKaydet.UseVisualStyleBackColor = true;
            this.btnBilgileriKaydet.Click += new System.EventHandler(this.btnBilgileriKaydet_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Enabled = false;
            this.btnYeniKayit.Location = new System.Drawing.Point(329, 299);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(107, 36);
            this.btnYeniKayit.TabIndex = 85;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(26, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(362, 17);
            this.label17.TabIndex = 84;
            this.label17.Text = "Türkiye Cumhuriyeti Kimlik Kartı Bilgilerini Giriniz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 75;
            this.label8.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Uyruğu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Anne Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Baba Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Adı:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(135, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 22);
            this.txtId.TabIndex = 104;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 17);
            this.label19.TabIndex = 103;
            this.label19.Text = "Seri No :";
            // 
            // txtBabaAdı
            // 
            this.txtBabaAdı.Location = new System.Drawing.Point(135, 217);
            this.txtBabaAdı.Name = "txtBabaAdı";
            this.txtBabaAdı.Size = new System.Drawing.Size(145, 22);
            this.txtBabaAdı.TabIndex = 106;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(433, 116);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(174, 22);
            this.dtpDogumTarihi.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 109;
            this.label7.Text = "Kan Grubu :";
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(433, 156);
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(174, 22);
            this.txtUyruk.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Cinsiyeti :";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN",
            "DİĞER"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(433, 76);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(174, 24);
            this.cmbCinsiyet.TabIndex = 113;
            // 
            // cmbKan
            // 
            this.cmbKan.FormattingEnabled = true;
            this.cmbKan.Items.AddRange(new object[] {
            "A0RH+",
            "A0RH-",
            "B0RH+",
            "B0RH-",
            "ABRH+",
            "ABRH-",
            "00RH+",
            "00RH-"});
            this.cmbKan.Location = new System.Drawing.Point(433, 196);
            this.cmbKan.Name = "cmbKan";
            this.cmbKan.Size = new System.Drawing.Size(174, 24);
            this.cmbKan.TabIndex = 114;
            // 
            // kisiselBilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 470);
            this.Controls.Add(this.cmbKan);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtUyruk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtBabaAdı);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAnneAdi);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.btnBilgileriKaydet);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kisiselBilgiler";
            this.Text = "Kişisel Bilgiler";
            this.Load += new System.EventHandler(this.kisiselBilgiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtAdı;
        public System.Windows.Forms.TextBox txtSoyadı;
        public System.Windows.Forms.TextBox txtAnneAdi;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.Button btnBilgileriKaydet;
        public System.Windows.Forms.Button btnYeniKayit;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtBabaAdı;
        public System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtUyruk;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbCinsiyet;
        public System.Windows.Forms.ComboBox cmbKan;
        public System.Windows.Forms.Label label1;
    }
}