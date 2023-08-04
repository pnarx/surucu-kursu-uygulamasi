
namespace Sürücü_Kursu_Otomasyonu
{
    partial class NotBilgisi
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
            this.dGVNotBilgisi = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtİlkYardımSınavNotu = new System.Windows.Forms.TextBox();
            this.txtTrafikfSınavNotu = new System.Windows.Forms.TextBox();
            this.txtMotorSınavNotu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpsınavTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNotBilgisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVNotBilgisi
            // 
            this.dGVNotBilgisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNotBilgisi.Location = new System.Drawing.Point(-5, -4);
            this.dGVNotBilgisi.Name = "dGVNotBilgisi";
            this.dGVNotBilgisi.RowHeadersWidth = 51;
            this.dGVNotBilgisi.RowTemplate.Height = 24;
            this.dGVNotBilgisi.Size = new System.Drawing.Size(921, 189);
            this.dGVNotBilgisi.TabIndex = 0;
            this.dGVNotBilgisi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNotBilgisi_CellEnter);
            // 
            // btnCikis
            // 
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(512, 472);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(78, 36);
            this.btnCikis.TabIndex = 163;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(405, 472);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 36);
            this.btnSil.TabIndex = 162;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGüncelle.Location = new System.Drawing.Point(267, 472);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(122, 36);
            this.btnGüncelle.TabIndex = 161;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtİlkYardımSınavNotu
            // 
            this.txtİlkYardımSınavNotu.Location = new System.Drawing.Point(424, 433);
            this.txtİlkYardımSınavNotu.Name = "txtİlkYardımSınavNotu";
            this.txtİlkYardımSınavNotu.Size = new System.Drawing.Size(162, 22);
            this.txtİlkYardımSınavNotu.TabIndex = 19;
            // 
            // txtTrafikfSınavNotu
            // 
            this.txtTrafikfSınavNotu.Location = new System.Drawing.Point(424, 351);
            this.txtTrafikfSınavNotu.Name = "txtTrafikfSınavNotu";
            this.txtTrafikfSınavNotu.Size = new System.Drawing.Size(162, 22);
            this.txtTrafikfSınavNotu.TabIndex = 18;
            // 
            // txtMotorSınavNotu
            // 
            this.txtMotorSınavNotu.Location = new System.Drawing.Point(424, 388);
            this.txtMotorSınavNotu.Name = "txtMotorSınavNotu";
            this.txtMotorSınavNotu.Size = new System.Drawing.Size(162, 22);
            this.txtMotorSınavNotu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "İlk Yardım Sınav Notu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Motor Sınav Notu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trafik Sınav Notu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sınav Tarihi  :";
            // 
            // dtpsınavTarih
            // 
            this.dtpsınavTarih.Location = new System.Drawing.Point(424, 318);
            this.dtpsınavTarih.Name = "dtpsınavTarih";
            this.dtpsınavTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpsınavTarih.TabIndex = 12;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(424, 280);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(100, 22);
            this.txtTCKimlikNo.TabIndex = 11;
            this.txtTCKimlikNo.TextChanged += new System.EventHandler(this.txtTCKimlikNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 164;
            this.label6.Text = "ID :";
            // 
            // txtIDI
            // 
            this.txtIDI.Enabled = false;
            this.txtIDI.Location = new System.Drawing.Point(424, 244);
            this.txtIDI.Name = "txtIDI";
            this.txtIDI.Size = new System.Drawing.Size(100, 22);
            this.txtIDI.TabIndex = 165;
            // 
            // NotBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDI);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dGVNotBilgisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtİlkYardımSınavNotu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpsınavTarih);
            this.Controls.Add(this.txtMotorSınavNotu);
            this.Controls.Add(this.txtTrafikfSınavNotu);
            this.Controls.Add(this.label2);
            this.Name = "NotBilgisi";
            this.Text = "NotBilgisi";
            this.Load += new System.EventHandler(this.NotBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNotBilgisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dGVNotBilgisi;
        public System.Windows.Forms.TextBox txtİlkYardımSınavNotu;
        public System.Windows.Forms.TextBox txtTrafikfSınavNotu;
        public System.Windows.Forms.TextBox txtMotorSınavNotu;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpsınavTarih;
        public System.Windows.Forms.TextBox txtTCKimlikNo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIDI;
    }
}