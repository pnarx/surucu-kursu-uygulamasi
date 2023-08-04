
namespace Sürücü_Kursu_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPersonelBilgisi = new System.Windows.Forms.Button();
            this.btnNotBilgisi = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnNüfusBilgileri = new System.Windows.Forms.Button();
            this.btnAdayBilgileri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKisiselBilgiler = new System.Windows.Forms.Button();
            this.btnKursiyerKayıt = new System.Windows.Forms.Button();
            this.btnOdemeGirisi = new System.Windows.Forms.Button();
            this.btnNotGirisi = new System.Windows.Forms.Button();
            this.btnPersonelBK = new System.Windows.Forms.Button();
            this.dGVKursiyerKayit = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKursiyerKayit)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelBilgisi
            // 
            this.btnPersonelBilgisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelBilgisi.Location = new System.Drawing.Point(551, 10);
            this.btnPersonelBilgisi.Name = "btnPersonelBilgisi";
            this.btnPersonelBilgisi.Size = new System.Drawing.Size(139, 37);
            this.btnPersonelBilgisi.TabIndex = 13;
            this.btnPersonelBilgisi.Text = "Personel Bilgisi";
            this.btnPersonelBilgisi.UseVisualStyleBackColor = false;
            this.btnPersonelBilgisi.Click += new System.EventHandler(this.btnPersonelBilgisi_Click);
            // 
            // btnNotBilgisi
            // 
            this.btnNotBilgisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNotBilgisi.Location = new System.Drawing.Point(408, 10);
            this.btnNotBilgisi.Name = "btnNotBilgisi";
            this.btnNotBilgisi.Size = new System.Drawing.Size(131, 37);
            this.btnNotBilgisi.TabIndex = 14;
            this.btnNotBilgisi.Text = "Not Bilgisi";
            this.btnNotBilgisi.UseVisualStyleBackColor = false;
            this.btnNotBilgisi.Click += new System.EventHandler(this.btnNotBilgisi_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdemeler.Location = new System.Drawing.Point(278, 10);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(118, 37);
            this.btnOdemeler.TabIndex = 15;
            this.btnOdemeler.Text = "Ödemeler";
            this.btnOdemeler.UseVisualStyleBackColor = false;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(5, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 470);
            this.panel2.TabIndex = 8;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(1022, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(124, 34);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnNüfusBilgileri
            // 
            this.btnNüfusBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNüfusBilgileri.Location = new System.Drawing.Point(138, 10);
            this.btnNüfusBilgileri.Name = "btnNüfusBilgileri";
            this.btnNüfusBilgileri.Size = new System.Drawing.Size(128, 38);
            this.btnNüfusBilgileri.TabIndex = 16;
            this.btnNüfusBilgileri.Text = "Nüfus Bilgileri";
            this.btnNüfusBilgileri.UseVisualStyleBackColor = false;
            this.btnNüfusBilgileri.Click += new System.EventHandler(this.btnNüfusBilgileri_Click);
            // 
            // btnAdayBilgileri
            // 
            this.btnAdayBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdayBilgileri.Location = new System.Drawing.Point(25, 11);
            this.btnAdayBilgileri.Name = "btnAdayBilgileri";
            this.btnAdayBilgileri.Size = new System.Drawing.Size(107, 37);
            this.btnAdayBilgileri.TabIndex = 10;
            this.btnAdayBilgileri.Text = "Aday Bilgileri";
            this.btnAdayBilgileri.UseVisualStyleBackColor = false;
            this.btnAdayBilgileri.Click += new System.EventHandler(this.btnAdayBilgileri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnKisiselBilgiler);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnKursiyerKayıt);
            this.panel1.Controls.Add(this.btnOdemeGirisi);
            this.panel1.Controls.Add(this.btnNotGirisi);
            this.panel1.Controls.Add(this.btnPersonelBK);
            this.panel1.Location = new System.Drawing.Point(2, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 65);
            this.panel1.TabIndex = 7;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(877, 14);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(124, 32);
            this.btnAyarlar.TabIndex = 11;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kursiyer Listesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(151, 14);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(124, 32);
            this.btnKisiselBilgiler.TabIndex = 13;
            this.btnKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.btnKisiselBilgiler.UseVisualStyleBackColor = true;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnKursiyerKayıt
            // 
            this.btnKursiyerKayıt.Location = new System.Drawing.Point(12, 14);
            this.btnKursiyerKayıt.Name = "btnKursiyerKayıt";
            this.btnKursiyerKayıt.Size = new System.Drawing.Size(124, 32);
            this.btnKursiyerKayıt.TabIndex = 5;
            this.btnKursiyerKayıt.Text = "Kursiyer Kayıt";
            this.btnKursiyerKayıt.UseVisualStyleBackColor = true;
            this.btnKursiyerKayıt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdemeGirisi
            // 
            this.btnOdemeGirisi.Location = new System.Drawing.Point(281, 14);
            this.btnOdemeGirisi.Name = "btnOdemeGirisi";
            this.btnOdemeGirisi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOdemeGirisi.Size = new System.Drawing.Size(124, 32);
            this.btnOdemeGirisi.TabIndex = 8;
            this.btnOdemeGirisi.Text = "Ödeme Girişi";
            this.btnOdemeGirisi.UseVisualStyleBackColor = true;
            this.btnOdemeGirisi.Click += new System.EventHandler(this.btnOdemeGirisi_Click);
            // 
            // btnNotGirisi
            // 
            this.btnNotGirisi.Location = new System.Drawing.Point(411, 14);
            this.btnNotGirisi.Name = "btnNotGirisi";
            this.btnNotGirisi.Size = new System.Drawing.Size(124, 32);
            this.btnNotGirisi.TabIndex = 9;
            this.btnNotGirisi.Text = "Not Girişi";
            this.btnNotGirisi.UseVisualStyleBackColor = true;
            this.btnNotGirisi.Click += new System.EventHandler(this.btnNotGirisi_Click);
            // 
            // btnPersonelBK
            // 
            this.btnPersonelBK.Location = new System.Drawing.Point(541, 14);
            this.btnPersonelBK.Name = "btnPersonelBK";
            this.btnPersonelBK.Size = new System.Drawing.Size(162, 32);
            this.btnPersonelBK.TabIndex = 10;
            this.btnPersonelBK.Text = "Personel Bilgi ve Kayıt";
            this.btnPersonelBK.UseVisualStyleBackColor = true;
            this.btnPersonelBK.Click += new System.EventHandler(this.btnPersonelBK_Click);
            // 
            // dGVKursiyerKayit
            // 
            this.dGVKursiyerKayit.AllowUserToAddRows = false;
            this.dGVKursiyerKayit.AllowUserToDeleteRows = false;
            this.dGVKursiyerKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dGVKursiyerKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKursiyerKayit.Location = new System.Drawing.Point(2, 68);
            this.dGVKursiyerKayit.Name = "dGVKursiyerKayit";
            this.dGVKursiyerKayit.ReadOnly = true;
            this.dGVKursiyerKayit.RowHeadersWidth = 51;
            this.dGVKursiyerKayit.RowTemplate.Height = 24;
            this.dGVKursiyerKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVKursiyerKayit.Size = new System.Drawing.Size(1485, 221);
            this.dGVKursiyerKayit.TabIndex = 19;
            this.dGVKursiyerKayit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKursiyerKayit_CellContentClick_1);
            this.dGVKursiyerKayit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKursiyerKayit_CellEnter);
            this.dGVKursiyerKayit.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVKursiyerKayit_CellMouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnAdayBilgileri);
            this.panel3.Controls.Add(this.btnNüfusBilgileri);
            this.panel3.Controls.Add(this.btnOdemeler);
            this.panel3.Controls.Add(this.btnNotBilgisi);
            this.panel3.Controls.Add(this.btnPersonelBilgisi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 67);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(705, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "KURSİYER ARA:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(851, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 37);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Location = new System.Drawing.Point(807, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 800);
            this.panel5.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1299, 867);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dGVKursiyerKayit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKursiyerKayit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.Button btnPersonelBilgisi;
        public System.Windows.Forms.Button btnNotBilgisi;
        public System.Windows.Forms.Button btnOdemeler;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnNüfusBilgileri;
        public System.Windows.Forms.Button btnAdayBilgileri;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKisiselBilgiler;
        private System.Windows.Forms.Button btnKursiyerKayıt;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnOdemeGirisi;
        private System.Windows.Forms.Button btnNotGirisi;
        private System.Windows.Forms.Button btnPersonelBK;
        public System.Windows.Forms.DataGridView dGVKursiyerKayit;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

