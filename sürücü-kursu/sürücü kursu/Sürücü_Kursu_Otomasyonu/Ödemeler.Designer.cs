
namespace Sürücü_Kursu_Otomasyonu
{
    partial class Ödemeler
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dGVOdemeler = new System.Windows.Forms.DataGridView();
            this.cmbTaksitSayısı = new System.Windows.Forms.ComboBox();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOdemeTutarı = new System.Windows.Forms.TextBox();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKalanBorç = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.cmbCekimTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(700, 376);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(78, 36);
            this.btnCikis.TabIndex = 160;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(600, 376);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 36);
            this.btnSil.TabIndex = 159;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(446, 376);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(122, 36);
            this.btnGüncelle.TabIndex = 158;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dGVOdemeler
            // 
            this.dGVOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOdemeler.Location = new System.Drawing.Point(0, 0);
            this.dGVOdemeler.Name = "dGVOdemeler";
            this.dGVOdemeler.RowHeadersWidth = 51;
            this.dGVOdemeler.RowTemplate.Height = 24;
            this.dGVOdemeler.Size = new System.Drawing.Size(844, 118);
            this.dGVOdemeler.TabIndex = 161;
            this.dGVOdemeler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOdemeler_CellEnter);
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
            this.cmbTaksitSayısı.Location = new System.Drawing.Point(186, 383);
            this.cmbTaksitSayısı.Name = "cmbTaksitSayısı";
            this.cmbTaksitSayısı.Size = new System.Drawing.Size(200, 24);
            this.cmbTaksitSayısı.TabIndex = 173;
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(185, 187);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpOdemeTarihi.TabIndex = 172;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(185, 150);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(200, 22);
            this.txtTCKimlik.TabIndex = 171;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(58, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 170;
            this.label7.Text = "Taksit Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(58, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 169;
            this.label6.Text = "Çekim Tipi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 168;
            this.label5.Text = "Ödeme Şekli :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 167;
            this.label8.Text = "Ödeme Tutarı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 166;
            this.label9.Text = "Ödenen Tutar :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 165;
            this.label10.Text = "Ödeme Tarihi :";
            // 
            // txtOdemeTutarı
            // 
            this.txtOdemeTutarı.Location = new System.Drawing.Point(185, 214);
            this.txtOdemeTutarı.Name = "txtOdemeTutarı";
            this.txtOdemeTutarı.Size = new System.Drawing.Size(200, 22);
            this.txtOdemeTutarı.TabIndex = 164;
            // 
            // txtOdenen
            // 
            this.txtOdenen.Location = new System.Drawing.Point(186, 242);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(200, 22);
            this.txtOdenen.TabIndex = 163;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 162;
            this.label11.Text = "TC Kimlik No :";
            // 
            // txtKalanBorç
            // 
            this.txtKalanBorç.Location = new System.Drawing.Point(185, 272);
            this.txtKalanBorç.Name = "txtKalanBorç";
            this.txtKalanBorç.Size = new System.Drawing.Size(200, 22);
            this.txtKalanBorç.TabIndex = 177;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "Kalan Borç :";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "nakit",
            "kredi kartı"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(186, 309);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(200, 24);
            this.cmbOdemeSekli.TabIndex = 197;
            // 
            // cmbCekimTipi
            // 
            this.cmbCekimTipi.Enabled = false;
            this.cmbCekimTipi.FormattingEnabled = true;
            this.cmbCekimTipi.Items.AddRange(new object[] {
            "Tek Çekim",
            "Taksitli Çekim"});
            this.cmbCekimTipi.Location = new System.Drawing.Point(186, 345);
            this.cmbCekimTipi.Name = "cmbCekimTipi";
            this.cmbCekimTipi.Size = new System.Drawing.Size(200, 24);
            this.cmbCekimTipi.TabIndex = 196;
            // 
            // Ödemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 467);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOdemeTutarı);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dGVOdemeler);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Name = "Ödemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.Ödemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.DataGridView dGVOdemeler;
        public System.Windows.Forms.ComboBox cmbTaksitSayısı;
        public System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtOdemeTutarı;
        public System.Windows.Forms.TextBox txtOdenen;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtKalanBorç;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbOdemeSekli;
        public System.Windows.Forms.ComboBox cmbCekimTipi;
    }
}