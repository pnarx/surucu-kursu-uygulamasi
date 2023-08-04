
namespace Sürücü_Kursu_Otomasyonu
{
    partial class ayarlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtMevcutSifre = new System.Windows.Forms.TextBox();
            this.btnSifreDegiştir = new System.Windows.Forms.Button();
            this.btnCıikis = new System.Windows.Forms.Button();
            this.label_mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgilerinizi Güncelleyin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mevcut Şifrenizi Güncelleyin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mevcut Şifreniz :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yeni Şifreniz :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yeni Şifreniz Tekrar :";
            // 
            // txtkullanıcıAdı
            // 
            this.txtkullanıcıAdı.Location = new System.Drawing.Point(220, 140);
            this.txtkullanıcıAdı.Name = "txtkullanıcıAdı";
            this.txtkullanıcıAdı.Size = new System.Drawing.Size(172, 22);
            this.txtkullanıcıAdı.TabIndex = 6;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(220, 210);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(172, 22);
            this.txtYeniSifre.TabIndex = 7;
            this.txtYeniSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(220, 258);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(172, 22);
            this.txtYeniSifreTekrar.TabIndex = 8;
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.Location = new System.Drawing.Point(220, 175);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.Size = new System.Drawing.Size(172, 22);
            this.txtMevcutSifre.TabIndex = 9;
            // 
            // btnSifreDegiştir
            // 
            this.btnSifreDegiştir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegiştir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSifreDegiştir.Location = new System.Drawing.Point(248, 373);
            this.btnSifreDegiştir.Name = "btnSifreDegiştir";
            this.btnSifreDegiştir.Size = new System.Drawing.Size(144, 47);
            this.btnSifreDegiştir.TabIndex = 10;
            this.btnSifreDegiştir.Text = "Şifre Değiştir";
            this.btnSifreDegiştir.UseVisualStyleBackColor = true;
            this.btnSifreDegiştir.Click += new System.EventHandler(this.btnSifreDegiştir_Click);
            // 
            // btnCıikis
            // 
            this.btnCıikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıikis.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCıikis.Location = new System.Drawing.Point(870, 391);
            this.btnCıikis.Name = "btnCıikis";
            this.btnCıikis.Size = new System.Drawing.Size(68, 42);
            this.btnCıikis.TabIndex = 11;
            this.btnCıikis.Text = "ÇIKIŞ";
            this.btnCıikis.UseVisualStyleBackColor = true;
            this.btnCıikis.Click += new System.EventHandler(this.btnCıikis_Click);
            // 
            // label_mesaj
            // 
            this.label_mesaj.AutoSize = true;
            this.label_mesaj.Location = new System.Drawing.Point(79, 329);
            this.label_mesaj.Name = "label_mesaj";
            this.label_mesaj.Size = new System.Drawing.Size(46, 17);
            this.label_mesaj.TabIndex = 12;
            this.label_mesaj.Text = "label7";
            this.label_mesaj.Click += new System.EventHandler(this.label_mesaj_Click);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 523);
            this.Controls.Add(this.label_mesaj);
            this.Controls.Add(this.btnCıikis);
            this.Controls.Add(this.btnSifreDegiştir);
            this.Controls.Add(this.txtMevcutSifre);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtkullanıcıAdı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.ayarlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtkullanıcıAdı;
        public System.Windows.Forms.TextBox txtYeniSifre;
        public System.Windows.Forms.TextBox txtYeniSifreTekrar;
        public System.Windows.Forms.TextBox txtMevcutSifre;
        public System.Windows.Forms.Button btnSifreDegiştir;
        public System.Windows.Forms.Button btnCıikis;
        public System.Windows.Forms.Label label_mesaj;
    }
}