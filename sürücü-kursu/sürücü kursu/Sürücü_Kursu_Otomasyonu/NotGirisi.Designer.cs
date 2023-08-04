
namespace Sürücü_Kursu_Otomasyonu
{
    partial class NotGirisi
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
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotorSınavNotu = new System.Windows.Forms.TextBox();
            this.txtTrafikfSınavNotu = new System.Windows.Forms.TextBox();
            this.txtİlkYardımSınavNotu = new System.Windows.Forms.TextBox();
            this.btnBilgileriKaydet = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(244, 115);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(200, 22);
            this.txtTCKimlik.TabIndex = 1;
            this.txtTCKimlik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(244, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sınav Tarihi  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trafik Sınav Notu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motor Sınav Notu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "İlk Yardım Sınav Notu :";
            // 
            // txtMotorSınavNotu
            // 
            this.txtMotorSınavNotu.Location = new System.Drawing.Point(244, 223);
            this.txtMotorSınavNotu.Name = "txtMotorSınavNotu";
            this.txtMotorSınavNotu.Size = new System.Drawing.Size(200, 22);
            this.txtMotorSınavNotu.TabIndex = 7;
            // 
            // txtTrafikfSınavNotu
            // 
            this.txtTrafikfSınavNotu.Location = new System.Drawing.Point(244, 186);
            this.txtTrafikfSınavNotu.Name = "txtTrafikfSınavNotu";
            this.txtTrafikfSınavNotu.Size = new System.Drawing.Size(200, 22);
            this.txtTrafikfSınavNotu.TabIndex = 8;
            // 
            // txtİlkYardımSınavNotu
            // 
            this.txtİlkYardımSınavNotu.Location = new System.Drawing.Point(244, 268);
            this.txtİlkYardımSınavNotu.Name = "txtİlkYardımSınavNotu";
            this.txtİlkYardımSınavNotu.Size = new System.Drawing.Size(200, 22);
            this.txtİlkYardımSınavNotu.TabIndex = 9;
            // 
            // btnBilgileriKaydet
            // 
            this.btnBilgileriKaydet.Location = new System.Drawing.Point(447, 333);
            this.btnBilgileriKaydet.Name = "btnBilgileriKaydet";
            this.btnBilgileriKaydet.Size = new System.Drawing.Size(125, 36);
            this.btnBilgileriKaydet.TabIndex = 90;
            this.btnBilgileriKaydet.Text = "Bilgileri Kaydet";
            this.btnBilgileriKaydet.UseVisualStyleBackColor = true;
            this.btnBilgileriKaydet.Click += new System.EventHandler(this.btnBilgileriKaydet_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(321, 333);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(107, 36);
            this.btnYeniKayit.TabIndex = 89;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(65, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Kursiyer Not Girişi";
            // 
            // NotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 537);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBilgileriKaydet);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.txtİlkYardımSınavNotu);
            this.Controls.Add(this.txtTrafikfSınavNotu);
            this.Controls.Add(this.txtMotorSınavNotu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.label1);
            this.Name = "NotGirisi";
            this.Text = "Not Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMotorSınavNotu;
        public System.Windows.Forms.TextBox txtTrafikfSınavNotu;
        public System.Windows.Forms.TextBox txtİlkYardımSınavNotu;
        public System.Windows.Forms.Button btnBilgileriKaydet;
        public System.Windows.Forms.Button btnYeniKayit;
        public System.Windows.Forms.Label label6;
    }
}