
namespace Sürücü_Kursu_Otomasyonu
{
    partial class NüfusBilgileri
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dGVNüfusBilgileri = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbKan = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtBabaAdı = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNüfusBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(139, 484);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 36);
            this.btnSil.TabIndex = 140;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(26, 484);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(107, 36);
            this.btnGüncelle.TabIndex = 139;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(23, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(362, 17);
            this.label17.TabIndex = 138;
            this.label17.Text = "Türkiye Cumhuriyeti Kimlik Kartı Bilgilerini Giriniz";
            // 
            // dGVNüfusBilgileri
            // 
            this.dGVNüfusBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNüfusBilgileri.Location = new System.Drawing.Point(0, 0);
            this.dGVNüfusBilgileri.Name = "dGVNüfusBilgileri";
            this.dGVNüfusBilgileri.RowHeadersWidth = 51;
            this.dGVNüfusBilgileri.RowTemplate.Height = 24;
            this.dGVNüfusBilgileri.Size = new System.Drawing.Size(924, 175);
            this.dGVNüfusBilgileri.TabIndex = 156;
            this.dGVNüfusBilgileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNüfusBilgileri_CellContentClick);
            this.dGVNüfusBilgileri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNüfusBilgileri_CellEnter);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(786, 484);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(125, 36);
            this.btnCikis.TabIndex = 157;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
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
            this.cmbKan.Location = new System.Drawing.Point(435, 371);
            this.cmbKan.Name = "cmbKan";
            this.cmbKan.Size = new System.Drawing.Size(121, 24);
            this.cmbKan.TabIndex = 177;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN",
            "DİĞER"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(435, 236);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cmbCinsiyet.TabIndex = 176;
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(435, 334);
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(145, 22);
            this.txtUyruk.TabIndex = 175;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 174;
            this.label7.Text = "Kan Grubu :";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(435, 291);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(174, 22);
            this.dtpDogumTarihi.TabIndex = 173;
            // 
            // txtBabaAdı
            // 
            this.txtBabaAdı.Location = new System.Drawing.Point(146, 392);
            this.txtBabaAdı.Name = "txtBabaAdı";
            this.txtBabaAdı.Size = new System.Drawing.Size(145, 22);
            this.txtBabaAdı.TabIndex = 172;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(146, 241);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 22);
            this.txtId.TabIndex = 171;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 17);
            this.label19.TabIndex = 170;
            this.label19.Text = "Seri No :";
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(146, 312);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(145, 22);
            this.txtAdı.TabIndex = 169;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(146, 354);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(145, 22);
            this.txtSoyadı.TabIndex = 168;
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Location = new System.Drawing.Point(146, 425);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(145, 22);
            this.txtAnneAdi.TabIndex = 167;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(146, 276);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(145, 22);
            this.txtTCKimlik.TabIndex = 166;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 165;
            this.label9.Text = "Cinsiyeti :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 164;
            this.label8.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 163;
            this.label6.Text = "Uyruğu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 162;
            this.label5.Text = "Anne Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 161;
            this.label4.Text = "Baba Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 160;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 159;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 158;
            this.label1.Text = "Adı:";
            // 
            // NüfusBilgileri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(923, 532);
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dGVNüfusBilgileri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label17);
            this.Name = "NüfusBilgileri";
            this.Text = "NüfusBilgileri";
            this.Load += new System.EventHandler(this.NüfusBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNüfusBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.DataGridView dGVNüfusBilgileri;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.ComboBox cmbKan;
        public System.Windows.Forms.ComboBox cmbCinsiyet;
        public System.Windows.Forms.TextBox txtUyruk;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        public System.Windows.Forms.TextBox txtBabaAdı;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtAdı;
        public System.Windows.Forms.TextBox txtSoyadı;
        public System.Windows.Forms.TextBox txtAnneAdi;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}