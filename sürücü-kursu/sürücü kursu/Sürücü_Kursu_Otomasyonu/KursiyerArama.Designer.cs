
namespace Sürücü_Kursu_Otomasyonu
{
    partial class KursiyerArama
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdTCKimlik = new System.Windows.Forms.RadioButton();
            this.rdİsmeGöre = new System.Windows.Forms.RadioButton();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(406, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kursiyer Arama ve Sorgulama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 46);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdTCKimlik
            // 
            this.rdTCKimlik.AutoSize = true;
            this.rdTCKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTCKimlik.ForeColor = System.Drawing.Color.Maroon;
            this.rdTCKimlik.Location = new System.Drawing.Point(382, 290);
            this.rdTCKimlik.Name = "rdTCKimlik";
            this.rdTCKimlik.Size = new System.Drawing.Size(101, 21);
            this.rdTCKimlik.TabIndex = 5;
            this.rdTCKimlik.TabStop = true;
            this.rdTCKimlik.Text = "TC Kimlik ";
            this.rdTCKimlik.UseVisualStyleBackColor = true;
            // 
            // rdİsmeGöre
            // 
            this.rdİsmeGöre.AutoSize = true;
            this.rdİsmeGöre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdİsmeGöre.ForeColor = System.Drawing.Color.Maroon;
            this.rdİsmeGöre.Location = new System.Drawing.Point(534, 290);
            this.rdİsmeGöre.Name = "rdİsmeGöre";
            this.rdİsmeGöre.Size = new System.Drawing.Size(154, 21);
            this.rdİsmeGöre.TabIndex = 6;
            this.rdİsmeGöre.TabStop = true;
            this.rdİsmeGöre.Text = "İsme Göre Arama";
            this.rdİsmeGöre.UseVisualStyleBackColor = true;
            this.rdİsmeGöre.CheckedChanged += new System.EventHandler(this.rdİsmeGöre_CheckedChanged);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.Color.Maroon;
            this.btnSorgula.Location = new System.Drawing.Point(434, 346);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(153, 49);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "Sorgu / ARA";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // KursiyerArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdTCKimlik);
            this.Controls.Add(this.rdİsmeGöre);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.textBox1);
            this.Name = "KursiyerArama";
            this.Text = "Kursiyer Arama";
            this.Load += new System.EventHandler(this.KursiyerArama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RadioButton rdTCKimlik;
        public System.Windows.Forms.RadioButton rdİsmeGöre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSorgula;
    }
}